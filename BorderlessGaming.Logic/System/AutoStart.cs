using Microsoft.Win32;

namespace BorderlessGaming.Logic.System
{
    public static class AutoStart
    {
        public static bool DeleteLegacy(string shortcutPath)
        {
            if (!string.IsNullOrEmpty(shortcutPath) && File.Exists(shortcutPath))
            {
                File.Delete(shortcutPath);
                return true;
            }

            return false;
        }

        public static void Setup(bool setup, string silentMinimize)
        {
            string appName = "BorderlessGaming";
            string appPath = Environment.ProcessPath;
            string arguments = "-m -s";
            string fullCommand = $"\"{appPath}\" {arguments}";

            if (setup)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(appName, fullCommand);
                key.Close();
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(appName, false);
                key.Close();
            }
        }
    }
}