using System;
using System.Runtime.InteropServices;

namespace Dota2Timer
{
    internal class Win32
    {
        public const int WS_EX_TRANSPARENT = 0x00000020;
        public const int GWL_EXSTYLE = (-20);

        public const int HOTKEY_ID = 9000;

        public const uint MOD_NONE = 0x0000; //(none)
        public const uint MOD_ALT = 0x0001; //ALT
        public const uint MOD_CONTROL = 0x0002; //CTRL
        public const uint MOD_SHIFT = 0x0004; //SHIFT
        public const uint MOD_WIN = 0x0008; //WINDOWS
        public const uint VK_F5 = 0x74;

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static void MakeTransparent(IntPtr hwnd)
        {
            int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
            Win32.SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle |
            WS_EX_TRANSPARENT);
        }
        public static void MakeNormal(IntPtr hwnd)
        {
            int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
            Win32.SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle & ~WS_EX_TRANSPARENT);
        }
    }
}