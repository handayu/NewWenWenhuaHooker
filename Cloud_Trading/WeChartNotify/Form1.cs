using System;
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

            InitTextBox();

        }

        private void InitTextBox()
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            IniOperationClass c = new IniOperationClass(path);

            this.textBox_InsHandle.Text = c.IniReadValue("Config", "InsHandle");

            this.textBox_BuyX.Text = c.IniReadValue("Config", "BX");
            this.textBox_BuyY.Text = c.IniReadValue("Config", "BY");
            this.textBox_SellShortX.Text = c.IniReadValue("Config", "SX");
            this.textBox_SellShortY.Text = c.IniReadValue("Config", "SY");
            this.textBox_CoverX.Text = c.IniReadValue("Config", "CX");
            this.textBox_CoverY.Text = c.IniReadValue("Config", "CY");

            this.textBox_OutputHandle.Text = c.IniReadValue("Config", "MCHandle");

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

        private void SendButton(string hexptr, string buStr)
        {
            SendMessageHandle handel = new SendMessageHandle();
            handel.SendMessageToButton((IntPtr)Convert.ToInt32(hexptr, 16), (IntPtr)Convert.ToInt32(buStr, 16));
        }

        /// <summary>
        /// 动态设置坐标
        /// </summary>
        /// <param name="diffX"></param>
        /// <param name="diffY"></param>
        public void SetingMovingXY(int diffX, int diffY)
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

            mouse_event((int)(MouseEventFlags.Absolute | MouseEventFlags.Move), x, y, 0, IntPtr.Zero);

            //用屏幕取点工具可以得到坐标
            //bool ire = SetCursorPos(x, y);
            //if(ire)
            //{
            //    AppendLogInfo("B屏幕取点工具移动鼠标到地点成功...");
            //}
            //else
            //{
            //    AppendLogInfo("B屏幕取点工具移动鼠标到地点失败...");
            //}

            //System.Threading.Thread.Sleep(100);

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

            //用屏幕取点工具可以得到坐

            bool ire = SetCursorPos(x, y);
            if (ire)
            {
                AppendLogInfo("S屏幕取点工具移动鼠标到地点成功...");
            }
            else
            {
                AppendLogInfo("S屏幕取点工具移动鼠标到地点失败...");
            }

            //System.Threading.Thread.Sleep(100);

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
            bool ire = SetCursorPos(x, y);
            if (ire)
            {
                AppendLogInfo("C屏幕取点工具移动鼠标到地点成功...");
            }
            else
            {
                AppendLogInfo("C屏幕取点工具移动鼠标到地点失败...");
            }

            //System.Threading.Thread.Sleep(100);

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
                //每次开启的时候，只要开启，先把oupt的显示直接先清空处理
                //SendString(this.textBox_OutputHandle.Text, "");

                this.timer2.Enabled = true;
                this.timer2.Start();
                m_startStr = string.Empty;
                return;
            }
            else
            {
                this.timer2.Enabled = false;
                this.timer2.Stop();
                m_startStr = string.Empty;
                return;
            }
        }

        private string m_startStr = string.Empty;
        private void TimerEvent_MCOutput(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox_OutputHandle.Text == "")
                {
                    return;
                }

                string content = SendToMulticharts(this.textBox_OutputHandle.Text);

                //加入richBox 分解并判断是否下单
                if (content != null && content != "" && content != m_startStr)
                {                
                    //拆解下单-MC打印的格式如下
                    //ClearPrintLog;
                    //print(date, "|", time, "|", close, "|", symbol, "|", "B");
                    //1200828.00 | 1500.00 | 4844.00 | CFFEX.IF 2009 | B
                    //其中最后一个字段为B/S/C；买入-卖空-平仓，文华可以自动判断

                    string[] conStrArray = content.Split('|');
                    string datetime = conStrArray[0].Trim() + conStrArray[0].Trim();
                    string price = conStrArray[2].Trim();
                    string insArray = conStrArray[3].Trim();
                    string[] ins2 = insArray.Split('.');
                    string ins = ins2[1].Replace(" ", "");

                    string side = conStrArray[4].Trim();

                    AppendLogInfo("切割完成准备下单...");

                    //下单
                    ActionOrder(ins, side);
                    m_startStr = content;

                    AppendLogInfo("下单完毕信息Focus到结尾...");

                    ////
                    this.richTextBox_MCInfos.AppendText(content + "\n");
                    if (richTextBox_MCInfos.Lines.Length > 100)
                    { richTextBox_MCInfos.Clear(); }

                    //========richtextbox滚动条自动移至最后一条记录
                    //让文本框获取焦点   
                    richTextBox_MCInfos.Focus();
                    //设置光标的位置到文本尾   
                    richTextBox_MCInfos.Select(richTextBox_MCInfos.TextLength, 0);
                    //滚动到控件光标处   
                    richTextBox_MCInfos.ScrollToCaret();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void AppendLogInfo(string str)
        {
            this.richTextBox_Loginfo.AppendText(DateTime.Now.ToString() + str + "\n");

            if (richTextBox_Loginfo.Lines.Length > 100)
            { richTextBox_Loginfo.Clear(); }

            //========richtextbox滚动条自动移至最后一条记录
            //让文本框获取焦点   
            richTextBox_Loginfo.Focus();
            //设置光标的位置到文本尾   
            richTextBox_Loginfo.Select(richTextBox_MCInfos.TextLength, 0);
            //滚动到控件光标处   
            richTextBox_Loginfo.ScrollToCaret();

        }

        private void ActionOrder(string ins, string side)
        {
            //输入合约；
            if (this.textBox_InsHandle.Text == "") return;
            SendString(this.textBox_InsHandle.Text, ins);
            AppendLogInfo("输入合约完毕...");

            //下单
            if (side == "B")
            {
                button_Buy_Click(null, null);
                AppendLogInfo("买入已发送...");

                return;
            }

            if (side == "S")
            {
                button_SellShort_Click(null, null);
                AppendLogInfo("卖空已发送...");

                return;
            }

            if (side == "C")
            {
                button_Cover_Click(null, null);
                AppendLogInfo("平仓已发送...");

                return;
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            IniOperationClass c = new IniOperationClass(path);
            c.IniWriteValue("Config", "InsHandle", this.textBox_InsHandle.Text);
            c.IniWriteValue("Config", "BX", this.textBox_BuyX.Text);
            c.IniWriteValue("Config", "BY", this.textBox_BuyY.Text);
            c.IniWriteValue("Config", "SX", this.textBox_SellShortX.Text);
            c.IniWriteValue("Config", "SY", this.textBox_SellShortY.Text);
            c.IniWriteValue("Config", "CX", this.textBox_CoverX.Text);
            c.IniWriteValue("Config", "CY", this.textBox_CoverY.Text);

            c.IniWriteValue("Config", "MCHandle", this.textBox_OutputHandle.Text);
        }

    }
}
