using System;

namespace WeChartNotify
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_InsHandle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Ins = new System.Windows.Forms.TextBox();
            this.button_InsTest = new System.Windows.Forms.Button();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Buy = new System.Windows.Forms.Button();
            this.textBox_BuyY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_BuyX = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_SellShort = new System.Windows.Forms.Button();
            this.textBox_SellShortY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_SellShortX = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_AutoSetingXY = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Cover = new System.Windows.Forms.Button();
            this.textBox_CoverY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_CoverX = new System.Windows.Forms.TextBox();
            this.richTextBox_MCInfos = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_TimeEvent = new System.Windows.Forms.CheckBox();
            this.textBox_outputInfo = new System.Windows.Forms.TextBox();
            this.button_OutPut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_OutputHandle = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox_Loginfo = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Notify = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "实时动态X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "实时动态Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_InsHandle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Ins);
            this.groupBox1.Controls.Add(this.button_InsTest);
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合约测试";
            // 
            // textBox_InsHandle
            // 
            this.textBox_InsHandle.Location = new System.Drawing.Point(129, 17);
            this.textBox_InsHandle.Name = "textBox_InsHandle";
            this.textBox_InsHandle.Size = new System.Drawing.Size(67, 21);
            this.textBox_InsHandle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "合约:";
            // 
            // textBox_Ins
            // 
            this.textBox_Ins.Location = new System.Drawing.Point(53, 17);
            this.textBox_Ins.Name = "textBox_Ins";
            this.textBox_Ins.Size = new System.Drawing.Size(64, 21);
            this.textBox_Ins.TabIndex = 8;
            this.textBox_Ins.Text = "IF2009";
            // 
            // button_InsTest
            // 
            this.button_InsTest.Location = new System.Drawing.Point(202, 15);
            this.button_InsTest.Name = "button_InsTest";
            this.button_InsTest.Size = new System.Drawing.Size(90, 23);
            this.button_InsTest.TabIndex = 10;
            this.button_InsTest.Text = "合约输入测试";
            this.button_InsTest.Click += new System.EventHandler(this.Button_testInput_Click);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(80, 6);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.ReadOnly = true;
            this.textBox_X.Size = new System.Drawing.Size(64, 21);
            this.textBox_X.TabIndex = 6;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(232, 6);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.ReadOnly = true;
            this.textBox_Y.Size = new System.Drawing.Size(64, 21);
            this.textBox_Y.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_Buy);
            this.groupBox2.Controls.Add(this.textBox_BuyY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_BuyX);
            this.groupBox2.Location = new System.Drawing.Point(4, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 39);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "买入测试";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "SetX:";
            // 
            // button_Buy
            // 
            this.button_Buy.Location = new System.Drawing.Point(248, 12);
            this.button_Buy.Name = "button_Buy";
            this.button_Buy.Size = new System.Drawing.Size(55, 23);
            this.button_Buy.TabIndex = 0;
            this.button_Buy.Text = "买";
            this.button_Buy.UseVisualStyleBackColor = true;
            this.button_Buy.Click += new System.EventHandler(this.button_Buy_Click);
            // 
            // textBox_BuyY
            // 
            this.textBox_BuyY.Location = new System.Drawing.Point(168, 11);
            this.textBox_BuyY.Name = "textBox_BuyY";
            this.textBox_BuyY.Size = new System.Drawing.Size(64, 21);
            this.textBox_BuyY.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "SetY:";
            // 
            // textBox_BuyX
            // 
            this.textBox_BuyX.Location = new System.Drawing.Point(53, 13);
            this.textBox_BuyX.Name = "textBox_BuyX";
            this.textBox_BuyX.Size = new System.Drawing.Size(64, 21);
            this.textBox_BuyX.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.button_SellShort);
            this.groupBox4.Controls.Add(this.textBox_SellShortY);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox_SellShortX);
            this.groupBox4.Location = new System.Drawing.Point(4, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 47);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "卖空测试";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "SetX:";
            // 
            // button_SellShort
            // 
            this.button_SellShort.Location = new System.Drawing.Point(248, 16);
            this.button_SellShort.Name = "button_SellShort";
            this.button_SellShort.Size = new System.Drawing.Size(55, 23);
            this.button_SellShort.TabIndex = 0;
            this.button_SellShort.Text = "卖";
            this.button_SellShort.UseVisualStyleBackColor = true;
            this.button_SellShort.Click += new System.EventHandler(this.button_SellShort_Click);
            // 
            // textBox_SellShortY
            // 
            this.textBox_SellShortY.Location = new System.Drawing.Point(168, 19);
            this.textBox_SellShortY.Name = "textBox_SellShortY";
            this.textBox_SellShortY.Size = new System.Drawing.Size(64, 21);
            this.textBox_SellShortY.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "SetY:";
            // 
            // textBox_SellShortX
            // 
            this.textBox_SellShortX.Location = new System.Drawing.Point(52, 20);
            this.textBox_SellShortX.Name = "textBox_SellShortX";
            this.textBox_SellShortX.Size = new System.Drawing.Size(64, 21);
            this.textBox_SellShortX.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_AutoSetingXY);
            this.groupBox5.Controls.Add(this.button_Clear);
            this.groupBox5.Location = new System.Drawing.Point(326, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 81);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "自动追踪坐标设置";
            // 
            // button_AutoSetingXY
            // 
            this.button_AutoSetingXY.Location = new System.Drawing.Point(15, 20);
            this.button_AutoSetingXY.Name = "button_AutoSetingXY";
            this.button_AutoSetingXY.Size = new System.Drawing.Size(110, 23);
            this.button_AutoSetingXY.TabIndex = 1;
            this.button_AutoSetingXY.Text = "自动设置XY追踪";
            this.button_AutoSetingXY.UseVisualStyleBackColor = true;
            this.button_AutoSetingXY.Click += new System.EventHandler(this.button_AutoSetingXY_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(15, 49);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(110, 23);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "清空所有";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button_Cover);
            this.groupBox3.Controls.Add(this.textBox_CoverY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox_CoverX);
            this.groupBox3.Location = new System.Drawing.Point(4, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 47);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "平仓测试";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "SetX:";
            // 
            // button_Cover
            // 
            this.button_Cover.Location = new System.Drawing.Point(248, 16);
            this.button_Cover.Name = "button_Cover";
            this.button_Cover.Size = new System.Drawing.Size(55, 23);
            this.button_Cover.TabIndex = 0;
            this.button_Cover.Text = "平仓";
            this.button_Cover.UseVisualStyleBackColor = true;
            this.button_Cover.Click += new System.EventHandler(this.button_Cover_Click);
            // 
            // textBox_CoverY
            // 
            this.textBox_CoverY.Location = new System.Drawing.Point(168, 19);
            this.textBox_CoverY.Name = "textBox_CoverY";
            this.textBox_CoverY.Size = new System.Drawing.Size(64, 21);
            this.textBox_CoverY.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "SetY:";
            // 
            // textBox_CoverX
            // 
            this.textBox_CoverX.Location = new System.Drawing.Point(52, 20);
            this.textBox_CoverX.Name = "textBox_CoverX";
            this.textBox_CoverX.Size = new System.Drawing.Size(64, 21);
            this.textBox_CoverX.TabIndex = 0;
            // 
            // richTextBox_MCInfos
            // 
            this.richTextBox_MCInfos.Location = new System.Drawing.Point(7, 44);
            this.richTextBox_MCInfos.Name = "richTextBox_MCInfos";
            this.richTextBox_MCInfos.Size = new System.Drawing.Size(207, 53);
            this.richTextBox_MCInfos.TabIndex = 1;
            this.richTextBox_MCInfos.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox_MCInfos);
            this.groupBox6.Controls.Add(this.checkBox_TimeEvent);
            this.groupBox6.Location = new System.Drawing.Point(5, 108);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(220, 112);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "时钟定时器扫描并下单";
            // 
            // checkBox_TimeEvent
            // 
            this.checkBox_TimeEvent.AutoSize = true;
            this.checkBox_TimeEvent.Location = new System.Drawing.Point(7, 21);
            this.checkBox_TimeEvent.Name = "checkBox_TimeEvent";
            this.checkBox_TimeEvent.Size = new System.Drawing.Size(216, 16);
            this.checkBox_TimeEvent.TabIndex = 0;
            this.checkBox_TimeEvent.Text = "是否开启定时器并扫描满足条件下单";
            this.checkBox_TimeEvent.UseVisualStyleBackColor = true;
            this.checkBox_TimeEvent.CheckedChanged += new System.EventHandler(this.ChenckChanged_IsTmer);
            // 
            // textBox_outputInfo
            // 
            this.textBox_outputInfo.Location = new System.Drawing.Point(6, 53);
            this.textBox_outputInfo.Name = "textBox_outputInfo";
            this.textBox_outputInfo.Size = new System.Drawing.Size(183, 21);
            this.textBox_outputInfo.TabIndex = 21;
            // 
            // button_OutPut
            // 
            this.button_OutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_OutPut.Location = new System.Drawing.Point(5, 78);
            this.button_OutPut.Name = "button_OutPut";
            this.button_OutPut.Size = new System.Drawing.Size(184, 23);
            this.button_OutPut.TabIndex = 20;
            this.button_OutPut.Text = "获取输出内容";
            this.button_OutPut.UseVisualStyleBackColor = false;
            this.button_OutPut.Click += new System.EventHandler(this.Button_OutPut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "输出窗口句柄:";
            // 
            // textBox_OutputHandle
            // 
            this.textBox_OutputHandle.Location = new System.Drawing.Point(92, 26);
            this.textBox_OutputHandle.Name = "textBox_OutputHandle";
            this.textBox_OutputHandle.Size = new System.Drawing.Size(97, 21);
            this.textBox_OutputHandle.TabIndex = 19;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.textBox_outputInfo);
            this.groupBox7.Controls.Add(this.button_OutPut);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox_OutputHandle);
            this.groupBox7.Location = new System.Drawing.Point(328, 92);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(231, 226);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Multicharts下单信号获取";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(4, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(317, 104);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.TimerEvent_MCOutput);
            // 
            // richTextBox_Loginfo
            // 
            this.richTextBox_Loginfo.Location = new System.Drawing.Point(4, 321);
            this.richTextBox_Loginfo.Name = "richTextBox_Loginfo";
            this.richTextBox_Loginfo.Size = new System.Drawing.Size(555, 53);
            this.richTextBox_Loginfo.TabIndex = 2;
            this.richTextBox_Loginfo.Text = "";
            // 
            // richTextBox_Notify
            // 
            this.richTextBox_Notify.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Notify.ForeColor = System.Drawing.Color.Red;
            this.richTextBox_Notify.Location = new System.Drawing.Point(565, 5);
            this.richTextBox_Notify.Name = "richTextBox_Notify";
            this.richTextBox_Notify.Size = new System.Drawing.Size(141, 369);
            this.richTextBox_Notify.TabIndex = 19;
            this.richTextBox_Notify.Text = "启动系统:\n1.默认是关闭时钟的，等MC设置完毕，清空输出窗口；\n2.打开时钟定时器开始搜索输出信号源；\n3.确认焦点起始在文华财经上，否则移动鼠标会捕获失败；\n" +
    "\n中途干预：\n1.立即关闭时钟信号定时器，或者干预后立即关闭；\n2.设置好MC信号，并一定清空输出窗口；\n3.打开时钟信号源开始继续搜索；\n4.确认焦点在文华财" +
    "经，不在MC上，在MC上将无法获取鼠标；";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.richTextBox_Notify);
            this.Controls.Add(this.richTextBox_Loginfo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "股指Multicharts-文华财经信号映射工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RadioButton_Stop_CheckedChanged(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Ins;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Buy;
        private System.Windows.Forms.TextBox textBox_BuyY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_BuyX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_SellShort;
        private System.Windows.Forms.TextBox textBox_SellShortY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_SellShortX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_AutoSetingXY;
        private System.Windows.Forms.Button button_InsTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Cover;
        private System.Windows.Forms.TextBox textBox_CoverY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_CoverX;
        private System.Windows.Forms.TextBox textBox_InsHandle;
        private System.Windows.Forms.RichTextBox richTextBox_MCInfos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox_TimeEvent;
        private System.Windows.Forms.TextBox textBox_outputInfo;
        private System.Windows.Forms.Button button_OutPut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_OutputHandle;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox richTextBox_Loginfo;
        private System.Windows.Forms.RichTextBox richTextBox_Notify;
    }
}

