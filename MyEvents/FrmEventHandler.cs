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

        private void button1_Click(object sender, EventArgs e)//委派聯動事件
        {
            Class1 x = new Class1();
            x.InvalidPrice += X_InvalidPrice;// +=X_InvalidPrice產生事件方法

            x.OnInvalidPrice(1001);
        }

        private void X_InvalidPrice(int Price)//產生的事件方法
        {
            MessageBox.Show("Invalid Price -" + Price);
        }

        private void button4_Click(object sender, EventArgs e)//(情境)在事件方法無Invoke時
        {
            Class1 y = new Class1();
            y.OnInvalidPrice(1001);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 10000;
            ClsWidget widget1 = new ClsWidget();
            widget1.PercentDone += Widget1_PercentDone;

            widget1.LongTask(10000, 1);
        }

        
        private void Widget1_PercentDone(int percent, ref bool cancel)
        {
            this.label1.Text = ((float)percent/10000).ToString("p"); //百分比//percent.ToString();
            this.progressBar1.Value = percent;

            if(m_Cancel ==true)
            {
                cancel = true;
                this.label1.Text = "0";
                this.progressBar1.Value = 0;
            }
        }

        bool m_Cancel;
        private void button7_Click(object sender, EventArgs e)
        {
            m_Cancel = true;
        }
    }
}
