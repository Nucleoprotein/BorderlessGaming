using System.Diagnostics;
using BorderlessGaming.Logic.Models;

namespace BorderlessGaming.Logic.Windows
{
    public static class ForegroundManager
    {
        static Native.WinEventDelegate _dele = null;
        private static IntPtr _mHhook;

        public static void Subscribe()
        {
            _dele = WinEventProc;
            _mHhook = Native.SetWinEventHook(Native.EVENT_SYSTEM_FOREGROUND, Native.EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, _dele, 0, 0, Native.WINEVENT_OUTOFCONTEXT | Native.WINEVENT_SKIPOWNPROCESS);
        }

        public static void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (Config.Instance.Favorites != null)
            {
                try
                {
                    Native.GetWindowThreadProcessId(hwnd, out uint processId);
                    var details = new ProcessDetails(Process.GetProcessById((int)processId), hwnd);
                    foreach (var fav in Config.Instance.Favorites.Where(favorite => favorite.IsRunning && favorite.MuteInBackground))
                    {

                        if (fav.Matches(details))
                        {
                            if (Native.IsMuted((int)processId))
                            {
                                Native.UnMuteProcess((int)processId);
                            }
                        }
                        else
                        {
                            if (!Native.IsMuted(fav.RunningId))
                            {
                                Native.MuteProcess(fav.RunningId);
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    //
                }
            }

        }
    }
}