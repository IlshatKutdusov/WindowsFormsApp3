using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double alfa = 0, i = 0;

        private void numericUpDown2_Validated(object sender, EventArgs e)
        {
            i = Convert.ToInt16(numericUpDown2.Value);
            label4.Text = "" + i * Math.Pow(Math.Cos((alfa / 180D) * Math.PI), 2);
        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            alfa = Convert.ToInt16(numericUpDown1.Value);
            label4.Text = "" + i * Math.Pow(Math.Cos((alfa / 180D) * Math.PI),2);
        }
    }
}
