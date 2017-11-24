using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyEvents_CSharp;

namespace MyEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //註冊button事件，系統產生及 自行產生

            this.buttonX.Click += ButtonX_Click;//系統產生

            this.buttonX.Click += new EventHandler(aaa);//自行產生，()參數方法名稱
         
        }

        private void ButtonX_Click(object sender, EventArgs e)//系統產生
        {
            MessageBox.Show("系統產生的註冊事件buttonX Click");
        }

        void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("自行產生註冊事件的button aaa");
        }
    }
}
