using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplicationTest
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        int poi1 = 0;
        int ps1 = 0;
        int poi2 = 0;
        int ps2 = 0;
        int sta = 0;
        int cal = 0;
        /// <summary>
        /// 1+; 2-; 3*; 4/
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            buttondeng.Focus();
        }
        private void buttonc_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            sta = 0;
            poi1 = 0;
            poi2 = 0;
            ps1 = 0;
            ps2 = 0;
            cal = 0;
            textBox1.Text = "0";
        }
        private void input(int key)
        {
            if (sta == 0)
            {
                if (poi1 != 0)
                {
                    num1 = num1 + key / Math.Pow(10, poi1++);
                }
                else
                {
                    num1 = num1 * 10 + key;
                }
                textBox1.Text = num1.ToString();
            }
            else if (sta == 1)
            {
                if (poi2 != 0)
                {
                    num2 += key / Math.Pow(10, poi2++);
                }
                else
                {
                    num2 = num2 * 10 + key;
                }
                textBox1.Text = num2.ToString();
            }
            else if (sta == 2)
            {
                num1 = 0;
                num2 = 0;
                sta = 0;
                poi1 = 0;
                poi2 = 0;
                ps1 = 0;
                ps2 = 0;
                cal = 0;
                if (poi1 != 0)
                {
                    num1 = num1 + key / Math.Pow(10, poi1++);
                }
                else
                {
                    num1 = num1 * 10 + key;
                }
                textBox1.Text = num1.ToString();
            }
            else if (sta == 3)
            {
                num2 = 0;
                sta = 1;
                poi2 = 0;
                ///对直接按小数点的输入会有问题
                ps2 = 0;
                if (poi2 != 0)
                {
                    num2 += key / Math.Pow(10, poi2++);
                }
                else
                {
                    num2 = num2 * 10 + key;
                }
                textBox1.Text = num2.ToString();
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            input(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            input(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            input(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            input(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            input(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            input(9);
        }
        private void buttondian_Click(object sender, EventArgs e)
        {
            if (sta == 0)
            {
                if (ps1 == 0)
                {
                    poi1 = 1;
                    ps1 = 1;
                }
            }
            else if (sta == 1)
            {
                if (ps2 == 0)
                {
                    poi2 = 1;
                    ps2 = 1;
                }
            }
        }
        private void buttonjia_Click(object sender, EventArgs e)
        {
            if (sta == 0)
            {
                sta = 1;
                cal = 1;
            }
            else if(sta==1)
            {
                ///处理连续按计算符
                switch (cal)
                {
                    case 1:
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case 2:
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    case 3:
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case 4:
                        textBox1.Text = (num1 / num2).ToString();
                        break;
                }
                num1 = double.Parse(textBox1.Text);
                sta = 3;
                cal = 1;
            }
            else if (sta == 2)
            {
                sta = 3;
                cal = 1;
            }
        }
        private void buttonjian_Click(object sender, EventArgs e)
        {
            if (sta == 0)
            {
                sta = 1;
                cal = 2;
            }
            else if (sta == 1)
            {
                ///处理连续按计算符
                switch (cal)
                {
                    case 1:
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case 2:
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    case 3:
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case 4:
                        textBox1.Text = (num1 / num2).ToString();
                        break;
                }
                num1 = double.Parse(textBox1.Text);
                sta = 3;
                cal = 2;
            }
            else if (sta == 2)
            {
                sta = 3;
                cal = 2;
            }
        }
        private void buttoncheng_Click(object sender, EventArgs e)
        {
            if (sta == 0)
            {
                sta = 1;
                cal = 3;
            }
            else if (sta == 1)
            {
                ///处理连续按计算符
                switch (cal)
                {
                    case 1:
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case 2:
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    case 3:
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case 4:
                        textBox1.Text = (num1 / num2).ToString();
                        break;
                }
                num1 = double.Parse(textBox1.Text);
                sta = 3;
                cal = 3;
            }
            else if (sta == 2)
            {
                sta = 3;
                cal = 3;
            }
        }
        private void buttonchu_Click(object sender, EventArgs e)
        {
            if (sta == 0)
            {
                sta = 1;
                cal = 4;
            }
            else if (sta == 1)
            {
                ///处理连续按计算符
                switch (cal)
                {
                    case 1:
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case 2:
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    case 3:
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case 4:
                        textBox1.Text = (num1 / num2).ToString();
                        break;
                }
                num1 = double.Parse(textBox1.Text);
                sta = 3;
                cal = 4;
            }
            else if (sta == 2)
            {
                sta = 3;
                cal = 4;
            }
        }
        private void buttondeng_Click(object sender, EventArgs e)
        {
            switch (cal)
            {
                case 1:
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case 2:
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case 3:
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case 4:
                    textBox1.Text = (num1 / num2).ToString();
                    break;
            }
            num1 = double.Parse(textBox1.Text);
            sta = 2;
        }
        private void buttontui_Click(object sender, EventArgs e)
        {
            if (sta == 0)
            {
                if (ps1 == 1)
                {
                    ///char[] temp = new char[10];
                    ///对小数点后的退格处理
                    if (poi1 == 2)
                    {
                        StringBuilder temp1 = new StringBuilder(num1.ToString());
                        temp1.Remove(temp1.Length - 2, 2);
                        num1 = double.Parse(temp1.ToString());
                        num1 = (double)((int)num1);
                        poi1 = 0;
                        textBox1.Text = num1.ToString();
                        ps1 = 0;
                    }
                    else
                    {
                        StringBuilder temp = new StringBuilder(num1.ToString());
                        temp.Remove(temp.Length - 1, 1);
                        num1 = double.Parse(temp.ToString());
                        poi1--;
                        textBox1.Text = num1.ToString();
                    }
                }
                else
                {
                    num1 = (double)((int)num1 / 10);
                    textBox1.Text = num1.ToString();
                }
            }
            else if (sta == 1)
            {
                if (ps2 == 1)
                {
                    ///对小数点后的退格处理
                    if (poi2 == 2)
                    {
                        StringBuilder temp1 = new StringBuilder(num2.ToString());
                        temp1.Remove(temp1.Length - 2, 2);
                        num2 = double.Parse(temp1.ToString());
                        num2 = (double)((int)num2);
                        poi2 = 0;
                        textBox1.Text = num2.ToString();
                        ps2 = 0;
                    }
                    else
                    {
                        StringBuilder temp = new StringBuilder(num2.ToString());
                        temp.Remove(temp.Length - 1, 1);
                        num2 = double.Parse(temp.ToString());
                        poi2--;
                        textBox1.Text = num2.ToString();
                    }
                }
                else
                {
                    num2 = (double)((int)num2 / 10);
                    textBox1.Text = num2.ToString();
                }
            }
            else
            {
                num1 = 0;
                num2 = 0;
                sta = 0;
                poi1 = 0;
                poi2 = 0;
                ps1 = 0;
                ps2 = 0;
                cal = 0;
                textBox1.Text = "0";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    button0_Click(null, null);
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    button1_Click(null, null);
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    button2_Click(null, null);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    button3_Click(null, null);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    button4_Click(null, null);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    button5_Click(null, null);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    button6_Click(null, null);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    button7_Click(null, null);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    button8_Click(null, null);
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    button9_Click(null, null);
                    break;
                case Keys.Decimal:
                    buttondian_Click(null, null);
                    break;
                case Keys.Subtract:
                    buttonjian_Click(null, null);
                    break;
                case Keys.Add:
                    buttonjia_Click(null, null);
                    break;
                case Keys.Back:
                    buttontui_Click(null, null);
                    break;
                case Keys.Divide:
                    buttonchu_Click(null, null);
                    break;
                case Keys.Multiply:
                    buttoncheng_Click(null, null);
                    break;
                case Keys.Enter:
                    //buttondeng_Click(null, null);
                    break;
            }
            buttondeng.Focus();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            buttondeng.Focus();
        }
    }
}
