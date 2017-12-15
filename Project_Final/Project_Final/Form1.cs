using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
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

        private void button2_Click(object sender, EventArgs e)
        {
            The_ABC_Land forma = new The_ABC_Land();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            The_Color_Land formcolor = new The_Color_Land();
            formcolor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            The_Number_Land formnum = new The_Number_Land();
            formnum.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/oilkrit/The-Land-of-Word_");
        }
    }
}
