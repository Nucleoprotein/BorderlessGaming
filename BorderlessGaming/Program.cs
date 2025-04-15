using BorderlessGaming.Forms;
using BorderlessGaming.Logic.System;
using BorderlessGaming.Logic.Windows;

namespace BorderlessGaming
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "BorderlessGamingMutex");

        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                return;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetColorMode(SystemColorMode.System);
            Tools.Setup();
            ForegroundManager.Subscribe();
            Application.Run(new MainWindow());
            mutex.ReleaseMutex();
        }
    }
}
