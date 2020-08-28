using SmileWei.EmbeddedApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCaptureXLib;
using WeChartNotify.Properties;

namespace WeChartNotify
{
    public partial class Form2 : Form
    {
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


        private Form1 m_form = null;

        public Form2()
        {
            InitializeComponent();
            this.appBox = new AppContainer();
            this.appBox.ShowEmbedResult = true;
            Application.Idle += Application_Idle;
            // 
            // appBox
            // 
            this.appBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appBox.AppFilename = "";
            this.appBox.AppProcess = null;
            this.appBox.Location = new System.Drawing.Point(12, 12);
            this.appBox.Name = "appBox";
            this.appBox.ShowEmbedResult = false;
            this.appBox.Size = new System.Drawing.Size(443, 313);
            this.appBox.TabIndex = 0;
            //this.appBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_AppBox);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            
        }

        private void ToolStripMenuItem_Set_Click(object sender, EventArgs e)
        {
            if(m_form == null)
            {
                m_form = new Form1();
                m_form.Show();
                return;
            }
            else
            {
                if (m_form.Visible == true)
                {
                    m_form.Visible = false;
                    return;
                }

                if (m_form.Visible == false)
                {
                    m_form.Visible = true;
                    return;
                }
            }
            
        }

        private int m_Cap = 0;
        private IntPtr inPtr = IntPtr.Zero;
        private void SetOpacity(int hWnd, byte bAlpha)
        {
            int dwExStyle = NativeMethod.GetWindowLong(hWnd, NativeMethod.GWL_EXSTYLE);
            dwExStyle |= NativeMethod.WS_EX_LAYERED;
            NativeMethod.SetWindowLong(hWnd, NativeMethod.GWL_EXSTYLE, dwExStyle);
            if (!NativeMethod.SetLayeredWindowAttributes(hWnd, 0, bAlpha, NativeMethod.LWA_ALPHA))
                throw new Exception("Unable to set the Window Opacity.");
        }
        private void ToolStripMenuItem_Op_Click(object sender, EventArgs e)
        {
            if (m_Cap == 0)
            {
                SetOpacity((int)this.Handle, 128);
                if (this.inPtr != IntPtr.Zero) SetOpacity((int)this.inPtr, 128);
                m_Cap = 1;
                return;
            }
        }

        private void ToolStripMenuItemSetWinodwIn_Click(object sender, EventArgs e)
        {
            var frmHandle = new FormHandle();
            if (frmHandle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var handle = frmHandle.GetHandle();
                SetParent(handle, this.Handle);
                inPtr = handle;
                Win32API.SetWindowLong(new HandleRef(this.appBox, handle), GWL_STYLE, WS_VISIBLE);
            }
        }

        private bool leftFlag = false;
        private Point mouseStart = new Point();
        private Point mouseoff = new Point();
        /// <summary>
        /// 拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                //在这里把form1设置为动态转表的坐标
                Form1SetingMovingXY(diffX, diffY);
            }
        }

        private void Form1SetingMovingXY(int diffX, int diffY)
        {
            if(m_form != null)
            this.m_form.SetingMovingXY(diffX, diffY);
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            Point nowSet = Control.MousePosition;

            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(-mouseoff.X, -mouseoff.Y);//这里注意下-的用意，offset
                Location = mouseSet;
            }
        }

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

        private Point m_location = new Point();
        private void Move_Event(object sender, EventArgs e)
        {
            //计算diff
            int diffX = this.Location.X - m_location.X;
            int diffY = this.Location.Y - m_location.Y;

            //在这里把form1设置为动态转表的坐标
            Form1SetingMovingXY(diffX, diffY);

            m_location = Location;

        }


        private void Form_Load(object sender, EventArgs e)
        {
            this.m_location = this.Location;
        }

    }
}
