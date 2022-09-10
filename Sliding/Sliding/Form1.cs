using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding
{
    public partial class Form1 : Form
    {
        int PW,PW2;
        bool Hided;

        public Form1()
        {
            InitializeComponent();
            PW = s1.Width;
            PW2 = s2.Width;
            Hided = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hided) button1.Text = "H\nI\nD\nE";
            else button1.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                s1.Width = s1.Width + 100;
                if(s1.Width>=PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();

                }
            }
            else
            {
                s1.Width = s1.Width - 100;
                if(s1.Width<=0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                s2.Width = s2.Width + 100;
                if (s2.Width >= PW)
                {
                    timer2.Stop();
                    Hided = false;
                    this.Refresh();

                }
            }
            else
            {
                s2.Width = s2.Width - 100;
                if (s2.Width <= 0)
                {
                    timer2.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Hided) button2.Text = "H";
            else button2.Text = "S";
            timer2.Start();
        }
    }
}
