using System.Diagnostics;
using System.Globalization;
using BorderlessGaming.Logic.Models;
using BorderlessGaming.Logic.System;

namespace BorderlessGaming.Logic.Core
{
    public class LanguageManager
    {

        public static string CurrentCulture { get; set; }

        private static readonly HashSet<string> CultureNames = CreateCultureNames();

        private static Dictionary<string, Language> Languages { get; set; }

        private static HashSet<string> CreateCultureNames()
        {
            var cultureInfos = CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Where(x => !string.IsNullOrEmpty(x.Name))
                .ToArray();
            var allNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            allNames.UnionWith(cultureInfos.Select(x => x.TwoLetterISOLanguageName));
            allNames.UnionWith(cultureInfos.Select(x => x.Name));
            return allNames;
        }

        private static bool CultureExists(string name)
        {
            return CultureNames.Contains(name);
        }

        public static string Data(string key)
        {
            key = key.ToLower();
            var lang = Languages[CurrentCulture];
            var data = lang.Data(key);
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show($"{lang.Culture} is missing a translation for {key}");
                Environment.Exit(0);
            }
            return data;
        }

        public static void Load()
        {
            Languages = new Dictionary<string, Language>();
            if (!Directory.Exists(AppEnvironment.LanguagePath))
            {
                MessageBox.Show("UI Translations are missing from disk.");
                Environment.Exit(1);
            }
            foreach (var langFile in Directory.GetFiles(AppEnvironment.LanguagePath, "*.lang"))
            {
                var culture = Path.GetFileNameWithoutExtension(langFile);
                if (culture != null && CultureExists(culture) && !Languages.ContainsKey(culture))
                {
                    var lang = new Language { Culture = culture };
                    lang.LoadData(langFile);
                    if (lang.LanguageData != null)
                    {
                        Languages.Add(culture, lang);
                    }
                }
            }
            if (Languages.Count <= 0)
            {
                MessageBox.Show($"No Langauges have been loaded! Ensure {AppEnvironment.LanguagePath} exist with at least one .lang file.");
                Environment.Exit(0);
            }
            var defaultLang = Languages.Values.FirstOrDefault(lang => lang.Culture.Equals(Config.Instance.AppSettings.DefaultCulture));
            defaultLang?.Set();
        }

        public static void Setup(Form mainWindow, ToolStripMenuItem toolStripLanguages)
        {
            foreach (var lang in Languages.Values)
            {
                var item = toolStripLanguages.DropDownItems.Add(new ToolStripMenuItem
                {
                    Text = lang.ToString(),
                    CheckOnClick = true,
                    Checked = IsDefault(lang.DisplayName)
                });
                toolStripLanguages.DropDownItems[item].Click += (s, ea) =>
                {
                    if (s != null)
                    {
                        var tt = (ToolStripMenuItem)s;
                        if (!tt.Checked)
                        {
                            if (tt.Text != null && IsDefault(tt.Text) && !LanguageSelected(toolStripLanguages.DropDownItems))
                            {
                                tt.Checked = true;
                            }
                            return;
                        }
                        foreach (ToolStripMenuItem dropItem in toolStripLanguages.DropDownItems)
                        {
                            if (dropItem != tt)
                            {
                                dropItem.Checked = false;
                            }
                        }
                        SetDefaultLanguage(mainWindow, tt.Text);
                    }
                };
            }
        }

        private static bool LanguageSelected(ToolStripItemCollection dropDownItems)
        {
            var anyChecked = false;
            foreach (ToolStripMenuItem dropItem in dropDownItems)
            {
                anyChecked = dropItem.Checked;
            }
            return anyChecked;
        }

        private static bool IsDefault(string displayName)
        {
            try
            {
                var defaultCulture = Config.Instance.AppSettings.DefaultCulture;
                var langauge = Languages.Values.FirstOrDefault(lang => lang.DisplayName.Equals(displayName));
                return langauge != null && langauge.Culture.Equals(defaultCulture);
            }
            catch
            {

                return false;
            }
        }

        private static void SetDefaultLanguage(Form mainWindow, string tsiText)
        {
            var langauge = Languages.Values.FirstOrDefault(lang => lang.DisplayName.Equals(tsiText));
            if (langauge != null)
            {
                Config.Instance.AppSettings.DefaultCulture = langauge.Culture;
                Config.Save();
                langauge.Set();
                var dialogResult = MessageBox.Show(Data("settingConfirmationPrompt"), Data("settingConfirmationTitle"),
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Process.Start(Info);
                    Application.Exit();
                }
            }
        }
    }
}