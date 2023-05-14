using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(Length.Text);
            int b = Convert.ToInt32(Breadth.Text);
            int a = l * b;
            RectArea.Text = a.ToString();

        }

        private void RectArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
