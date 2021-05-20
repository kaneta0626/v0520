using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0520
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
            button1.Left = button1.Left - 10;
            //button1.Left = button1.Left + 10;
            //button1.Left + 10;=button1.Leftはできない

            //-もできる(逆方向に動く)

           // button1.Top = button1.Top + 10;
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
            button3.Left = button3.Left - 30;        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
            button4.Left = button4.Left + 30;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            button2.Left = button2.Left + 30;     
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
            MessageBox.Show(100.ToString());
            MessageBox.Show(""+100);
            MessageBox.Show($"{100}");

            MessageBox.Show(3.14f.ToString());
            MessageBox.Show(""+3.14f);
            MessageBox.Show($"{3.14f}");

            MessageBox.Show((1+1).ToString());
            MessageBox.Show(""+(1+1));
            MessageBox.Show($"{1+1}");

            MessageBox.Show((1.23f*1.23f).ToString());
            MessageBox.Show("" + (1.23f * 1.23f));
            MessageBox.Show($"{1.23f*1.23f}");

            //MessageBox.Show("1+1");←使えない？
            MessageBox.Show("1"+"1");
        }
    }
}
