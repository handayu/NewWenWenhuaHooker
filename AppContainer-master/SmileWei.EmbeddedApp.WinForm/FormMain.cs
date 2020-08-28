using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SmileWei.EmbeddedApp.WinForm
{
    public partial class FormMain : Form
    {

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;

        private IntPtr inPtr = IntPtr.Zero;

        public FormMain()
        {
            this.appBox = new AppContainer();

            InitializeComponent();
            this.appBox.ShowEmbedResult = true;
            Application.Idle += Application_Idle;
            //appBox.AppFilename = @"C:\Users\DELL\AppData\Local\Google\Chrome\Application\chrome.exe";
            //appBox.Start();

        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (appBox.IsStarted)
            {
                if (!appBox.AppProcess.HasExited)
                {
                    try
                    {
                        lblInfo.Text = string.Format("Main Window Handle:{0}|Original Parent Window Handle:{1}",
                            appBox.AppProcess.MainWindowHandle,
                            appBox.embedResult);
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            //throw new NotImplementedException();
        }

        private void btnBrowseApp_Click(object sender, EventArgs e)
        {
            if (openApp.ShowDialog(this)== DialogResult.OK)
            {
                appBox.AppFilename = openApp.FileName;
                appBox.Start();
                if (appBox.IsStarted)
                {
                    txtAppFilename.Text = appBox.AppFilename;
                    
                }
            }
        }

        private void lblEmbedAgain_Click(object sender, EventArgs e)
        {
            appBox.EmbedAgain();
            //var embedResult = appBox.embedResult;
            //if(embedResult==0)
            //{
            //    var errorString = AppContainer.GetLastError();
            //    MessageBox.Show(errorString);
            //}
        }

        private void lblEmbedHandle_Click(object sender, EventArgs e)
        {
            var frmHandle = new FormHandle();
            if (frmHandle.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                var handle = frmHandle.GetHandle();
                SetParent(handle, this.Handle);
                inPtr = handle;
                Win32API.SetWindowLong(new HandleRef(this.appBox, handle), GWL_STYLE, WS_VISIBLE);       
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        //[DllImport("user32.dll", EntryPoint = "SetWindowLongA", SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        //private static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);
        [DllImport("user32", EntryPoint = "SetWindowLong", SetLastError = true)]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );
        private void lblInfo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.lblInfo.Text);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            var app = appBox.AppProcess;
            if (app == null) { return; }

            var c = Form.FromHandle(app.MainWindowHandle);
            var f = c as Form;
            if (f != null)
            {
                Console.WriteLine(f.Parent == null);
            }

        }

        private void SetOpacity(int hWnd, byte bAlpha)
        {
            int dwExStyle = NativeMethod.GetWindowLong(hWnd, NativeMethod.GWL_EXSTYLE);
            dwExStyle |= NativeMethod.WS_EX_LAYERED;
            NativeMethod.SetWindowLong(hWnd, NativeMethod.GWL_EXSTYLE, dwExStyle);
            if (!NativeMethod.SetLayeredWindowAttributes(hWnd, 0, bAlpha, NativeMethod.LWA_ALPHA))
                throw new Exception("Unable to set the Window Opacity.");
        }

        private int m_Cap = 0;

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if(m_Cap == 0)
            {
                SetOpacity((int)this.Handle, 128);
                if(this.inPtr != IntPtr.Zero) SetOpacity((int)this.inPtr, 128);
                m_Cap = 1;
                return;
            }

            //if (m_Cap == 1)
            //{
            //    SetOpacity((int)this.Handle, 10);
            //    if (this.inPtr != IntPtr.Zero)  SetOpacity((int)this.inPtr, 10);
            //    m_Cap = 0;
            //    return;
            //}

        }

        private bool leftFlag = false;
        private Point mouseStart = new Point();
        private Point mouseoff = new Point();

        private int m_startX = int.MinValue;
        private int m_startY = int.MinValue;

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //点击窗口的鼠标坐标
                mouseStart = Control.MousePosition;
                mouseoff = new Point(e.X, e.Y);
                leftFlag = true;

            }
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            Point nowSet = Control.MousePosition;
            this.toolStripStatusLabel_XY.Text = string.Format("X:{0} Y:{1}", nowSet.X,nowSet.Y);

            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(-mouseoff.X, -mouseoff.Y);//这里注意下-的用意，offset
                Location = mouseSet;
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;

                //放下一瞬间的鼠标坐标
                Point mouseEnd = Control.MousePosition;

                //计算diff
                int diffX = mouseEnd.X - mouseStart.X;
                int diffY = mouseEnd.Y - mouseStart.Y;

                int endX = 0;
                int.TryParse(this.textBox_StartX.Text, out endX);

                int endY = 0;
                int.TryParse(this.textBox_StartY.Text, out endY);

                endX = endX + diffX;
                endY = endY + diffY;

                this.textBox_StartX.Text = endX.ToString();
                this.textBox_StartY.Text = endY.ToString();

            }
        }

        private void MouseMove_AppBox(object sender, MouseEventArgs e)
        {
            Point nowSet = Control.MousePosition;
            this.toolStripStatusLabel_XY.Text = string.Format("X:{0} Y:{1}", nowSet.X, nowSet.Y);
        }
    }
}
