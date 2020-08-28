using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WeChartNotify
{
    public abstract class NativeMethod
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes(int hwnd, int crKey, byte bAlpha, int dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(int hwnd, int nlndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetWindowLong(int hwnd, int nlndex, int dwNewLong);

        public const int LWA_ALPHA = 2;
        public const int LWA_COLORKEY = 1;
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_TRANSPARENT = 32;
        public const int WS_EX_LAYERED = 524288;
    }
}
