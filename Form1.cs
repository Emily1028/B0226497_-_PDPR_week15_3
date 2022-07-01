using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week15_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int a, m, s, en,t;

        private void again_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            art.Checked = false;
            music.Checked = false;
            science.Checked = false;
            enviroment.Checked = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                if (art.Checked)
                {
                    a = 20;
                }
                else
                {
                    a = 0;
                }
                if (music.Checked)
                {
                    m = 20;
                }
                else
                {
                    m = 0;
                }
                if (science.Checked)
                {
                    s = 20;
                }
                else
                {
                    s = 0;
                }
                if (enviroment.Checked)
                {
                    en = 20;
                }
                else
                {
                    en = 0;
                }
                cost.Text += $"\n合計應繳學費：{a+m+s+en}";
            }
            else if (radioButton2.Checked)
            {
                if (art.Checked)
                {
                    a = 45;
                }
                else
                {
                    a = 0;
                }
                if (music.Checked)
                {
                    m = 45;
                }
                else
                {
                    m = 0;
                }
                if (science.Checked)
                {
                    s = 45;
                }
                else
                {
                    s = 0;
                }
                if (enviroment.Checked)
                {
                    en = 45;
                }
                else
                {
                    en = 0;
                }
                cost.Text += $"\n合計應繳學費：{a + m + s + en}";
            }
        }
    }
}
