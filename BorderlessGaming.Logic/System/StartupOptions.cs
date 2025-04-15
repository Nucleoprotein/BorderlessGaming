using CommandLine;

namespace BorderlessGaming.Logic.System
{
    public class StartupOptions
    {
        [Option('m', "minimize", Required = false, HelpText = "Starts the application in a minimized state.")]
        public bool Minimize { get; set; }

        [Option('s', "silent", Required = false, HelpText = "Starts the application silently.")]
        public bool Silent { get; set; }
    }
}
