using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WeChartNotify
{
    public partial class FormHandle : Form
    {
        //根据坐标获取窗口句柄
        [DllImport("user32")]
        private static extern IntPtr WindowFromPoint(
        Point Point  //坐标
        );

        public FormHandle()
        {
            InitializeComponent();
        }
        public IntPtr GetHandle()
        {  
            return (IntPtr)(handle.Value);
        }
        private void btnEmbed_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Timer_Event(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            Point p = new Point(x, y);
            IntPtr handleIntptr = WindowFromPoint(p);//得到窗口句柄
            int ptrValue = ((int)(handleIntptr));
            handle.Value = ptrValue;
        }
    }
}
