using System.Reflection;

namespace BorderlessGaming.Logic.System
{
    public class AppEnvironment
    {
        public static string Path = Environment.ProcessPath;
        public static string LanguagePath = global::System.IO.Path.Combine(DataPath, "Languages");
        public static string ConfigPath = global::System.IO.Path.Combine(DataPath, "BorderlessGaming.config.json");

        public static string DataPath
        {
            get
            {
                var directoryInfo = new FileInfo(Path).Directory;
                return directoryInfo.ToString();
            }
        }
    }
}