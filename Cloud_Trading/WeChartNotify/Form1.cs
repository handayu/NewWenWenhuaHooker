﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmileWei;

namespace WeChartNotify
{
    public partial class Form1 : Form
    {
        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(int hWnd);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;//timer控件的执行频率
            this.textBox_Ins.Text = "IF2009";

        }

        public enum MouseEventFlags
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            Wheel = 0x0800,
            Absolute = 0x8000
        }

        private string m_nowX = "";
        private string m_nowY = "";
        private int m_spreadTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox_X.Text = Control.MousePosition.X.ToString();
            this.textBox_Y.Text = Control.MousePosition.Y.ToString();

            if (!m_autoSetingXY) return;

            m_nowX = Control.MousePosition.X.ToString();
            m_nowY = Control.MousePosition.Y.ToString();

            m_spreadTime = m_spreadTime + 10;

            if (Control.MousePosition.X.ToString().CompareTo(m_nowX) != 0
                || Control.MousePosition.Y.ToString().CompareTo(m_nowY) != 0)
            {
                m_spreadTime = 0;
            }

            if (Control.MousePosition.X.ToString().CompareTo(m_nowX) == 0
                && Control.MousePosition.Y.ToString().CompareTo(m_nowY) == 0
                && m_spreadTime >= 2000)
            {             
                // 1.buy坐标
                if (this.textBox_BuyX.Text == "" && this.textBox_BuyY.Text == "")
                {
                    this.textBox_BuyX.Text = Control.MousePosition.X.ToString();
                    this.textBox_BuyY.Text = Control.MousePosition.Y.ToString();
                    m_spreadTime = 0;
                    return;
                }

                //1.sellshort坐标
                if (this.textBox_SellShortX.Text == "" && this.textBox_SellShortY.Text == "")
                {
                    this.textBox_SellShortX.Text = Control.MousePosition.X.ToString();
                    this.textBox_SellShortY.Text = Control.MousePosition.Y.ToString();
                    m_spreadTime = 0;
                    return;
                }

                //1.cover坐标
                if (this.textBox_CoverX.Text == "" && this.textBox_CoverY.Text == "")
                {
                    this.textBox_CoverX.Text = Control.MousePosition.X.ToString();
                    this.textBox_CoverY.Text = Control.MousePosition.Y.ToString();
                    m_spreadTime = 0;
                    return;
                }

            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            this.textBox_BuyX.Clear();
            this.textBox_BuyY.Clear();

            this.textBox_CoverX.Clear();
            this.textBox_CoverY.Clear();

            this.textBox_SellShortX.Clear();
            this.textBox_SellShortY.Clear();
        }

        private bool m_autoSetingXY = false;
        private void button_AutoSetingXY_Click(object sender, EventArgs e)
        {
            if (m_autoSetingXY == false)
            {
                m_autoSetingXY = true;

            }
            else
            {
                m_autoSetingXY = false;
            }
        }

        private void Button_testInput_Click(object sender, EventArgs e)
        {
            if (this.textBox_InsHandle.Text == "")
            {
                MessageBox.Show("请输入合约的句柄...");
                return;
            }

            try
            {
                SendString(this.textBox_InsHandle.Text, this.textBox_Ins.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SendString(string hexptr, string info)
        {
            SendMessageHandle handel = new SendMessageHandle();
            handel.SendMessageToTextBox((IntPtr)Convert.ToInt32(hexptr, 16), info);
        }

        /// <summary>
        /// 动态设置坐标
        /// </summary>
        /// <param name="diffX"></param>
        /// <param name="diffY"></param>
        public void  SetingMovingXY(int diffX,int diffY)
        {
            //Content
            int cX = 0;
            int cY = 0;
            int.TryParse(this.textBox_CoverX.Text, out cX);
            int.TryParse(this.textBox_CoverY.Text, out cY);

            this.textBox_CoverX.Text = (cX + diffX).ToString();
            this.textBox_CoverY.Text = (cY + diffY).ToString();

            //Enter
            int eX = 0;
            int eY = 0;
            int.TryParse(this.textBox_BuyX.Text, out eX);
            int.TryParse(this.textBox_BuyY.Text, out eY);

            this.textBox_BuyX.Text = (eX + diffX).ToString();
            this.textBox_BuyY.Text = (eY + diffY).ToString();

            //Voice
            int vX = 0;
            int vY = 0;
            int.TryParse(this.textBox_SellShortX.Text, out vX);
            int.TryParse(this.textBox_SellShortY.Text, out vY);

            this.textBox_SellShortX.Text = (vX + diffX).ToString();
            this.textBox_SellShortY.Text = (vY + diffY).ToString();

        }

        #region 买- 卖 - 平
        private void button_Buy_Click(object sender, EventArgs e)
        {
            int x = int.MinValue;
            int y = int.MinValue;

            if (this.textBox_BuyX.Text == "")
            {
                MessageBox.Show("请输入要测试点击按钮的X的Int坐标！");
                return;
            }
            else
            {
                int.TryParse(this.textBox_BuyX.Text, out x);
            }

            if (this.textBox_BuyY.Text == "")
            {
                MessageBox.Show("请输入要测试点击按钮的y的Int坐标！");
                return;
            }
            else
            {
                int.TryParse(this.textBox_BuyY.Text, out y);
            }

            //用屏幕取点工具可以得到坐标
            SetCursorPos(x, y);
            //点击
            mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.LeftUp), x, y, 0, IntPtr.Zero);

        }

        private void button_SellShort_Click(object sender, EventArgs e)
        {
            int x = int.MinValue;
            int y = int.MinValue;

            if (this.textBox_SellShortX.Text == "")
            {
                MessageBox.Show("请输入要测试微信语音点击按钮的X的Int坐标！");
                return;
            }
            else
            {
                int.TryParse(this.textBox_SellShortX.Text, out x);
            }

            if (this.textBox_SellShortY.Text == "")
            {
                MessageBox.Show("请输入要测试微信语音点击按钮的Y的Int坐标！");
                return;
            }
            else
            {
                int.TryParse(this.textBox_SellShortY.Text, out y);
            }

            //用屏幕取点工具可以得到坐标
            SetCursorPos(x, y);
            //点击
            mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.LeftUp), x, y, 0, IntPtr.Zero);
        }

        private void button_Cover_Click(object sender, EventArgs e)
        {
            int x = int.MinValue;
            int y = int.MinValue;

            if (this.textBox_CoverX.Text == "")
            {
                MessageBox.Show("请输入要测试微信语音点击按钮的X的Int坐标！");
                return;
            }
            else
            {
                int.TryParse(this.textBox_CoverX.Text, out x);
            }

            if (this.textBox_CoverY.Text == "")
            {
                MessageBox.Show("请输入要测试微信语音点击按钮的Y的Int坐标！");
                return;
            }
            else
            {
                int.TryParse(this.textBox_CoverY.Text, out y);
            }

            //用屏幕取点工具可以得到坐标
            SetCursorPos(x, y);
            //点击
            mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.LeftUp), x, y, 0, IntPtr.Zero);
        }
        #endregion

        private void Button_OutPut_Click(object sender, EventArgs e)
        {
            if (this.textBox_OutputHandle.Text == "")
            {
                MessageBox.Show("请输入MC-OutPut的句柄...");
                return;
            }

            try
            {
                string content = SendToMulticharts(this.textBox_OutputHandle.Text);
                if (content != null && content != "")
                {
                    this.textBox_outputInfo.AppendText(content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private string SendToMulticharts(string hexptr)
        {
            SendMessageHandle handel = new SendMessageHandle();
            return handel.SendMessageToMCOutPut((IntPtr)Convert.ToInt32(hexptr, 16));
        }

        private void ChenckChanged_IsTmer(object sender, EventArgs e)
        {
            if (this.checkBox_TimeEvent.Checked)
            {
                this.timer1.Enabled = true;
                this.timer1.Start();
                return;
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                return;
            }
        }

        private string m_startStr = string.Empty;

        private void TimerEvent_MCOutput(object sender, EventArgs e)
        {
            if (this.textBox_OutputHandle.Text == "") return;
            string content = SendToMulticharts(this.textBox_OutputHandle.Text);

            //加入richBox 分解并判断是否下单
            if (content != null && content != "" && content != m_startStr)
            {
                this.richTextBox_MCInfos.AppendText(content + "\n");

                //拆解下单




                m_startStr = content;
            }
        }
    }
}