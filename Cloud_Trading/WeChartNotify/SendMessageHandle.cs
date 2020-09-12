using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeChartNotify
{
    public class SendMessageHandle
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);
        private const int WM_SETTEXT = 0x000C;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);
        private const int WM_GETTEXT = 0x0D;

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
        private static extern void SetForegroundWindow(IntPtr hwnd);

        private const int WM_LBUTTONDOWN = 0x201;
        public const int  WM_LBUTTONUP =   0x202;
        private const int MK_LBUTTON = 0x0001;
        private const int WM_CLICK = 0x00F5;
        private const int BM_CLICK = 0xF5;

        /// <summary>
        /// 下单到按钮
        /// </summary>
        public void SendMessageToButton(IntPtr mainptr,IntPtr buPrt)
        {
            //SendMessage(intptr, WM_LBUTTONDOWN, MK_LBUTTON, 0x00150011);
            //System.Threading.Thread.Sleep(100);
            //SendMessage(intptr, WM_LBUTTONUP, 0, 0x00150011);

            int x = 17;
            int y = 20;

            //写法1
            //PostMessage(intptr, WM_LBUTTONDOWN, 0, (x & 0xFFFF) + (y & 0xFFFF) * 0x10000);
            //PostMessage(intptr, WM_LBUTTONUP, 0, (x & 0xFFFF) + (y & 0xFFFF) * 0x10000);

            //简化下  其实就是Y坐标左移16位,然后再加上X坐标
            //SendMessage(intptr, WM_LBUTTONDOWN, MK_LBUTTON, x + (y << 16));
            //System.Threading.Thread.Sleep(100);
            //SendMessage(intptr, WM_LBUTTONUP, MK_LBUTTON, x + (y << 16));

            SetForegroundWindow(mainptr);
            //SendMessage(buPrt, WM_CLICK, 0, 0);//给子窗体上button发送鼠标点击消息，
            //SendMessage(buPrt, WM_LBUTTONDOWN, 0, 0);
            //PostMessage(buPrt, WM_LBUTTONDOWN, 0, (x & 0xFFFF) + (y & 0xFFFF) * 0x10000);
            //System.Threading.Thread.Sleep(10);
            //PostMessage(buPrt, WM_LBUTTONUP, 0, (x & 0xFFFF) + (y & 0xFFFF) * 0x10000);
            SendMessage(buPrt, BM_CLICK, 0, 0);

        }


        /// <summary>
        /// 下单到TextBox
        /// </summary>
        public void SendMessageToTextBox(IntPtr intPtr,string info)
        {
            SendMessage(intPtr, WM_SETTEXT, IntPtr.Zero, "");
            SendMessage(intPtr, WM_SETTEXT, IntPtr.Zero, info);

        }

        /// <summary>
        /// 获取MC输出窗口信息并清空
        /// </summary>
        public string SendMessageToMCOutPut(IntPtr intPtr)
        {
            const int buffer_size = 65536;
            StringBuilder buffer = new StringBuilder(buffer_size);
            SendMessage(intPtr, WM_GETTEXT, buffer_size, buffer);
            return buffer.ToString();
        }
    }
}
