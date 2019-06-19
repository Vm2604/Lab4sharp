using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2sharp
{
    public partial class Form1 : Form
    {
        Rectangle rectangle;
        Prisma parallelepiped;

        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle();
            parallelepiped = new Prisma();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            rectangle.width = Convert.ToDouble(textHeight.Text == " " ? "0" : textHeight.Text);
            parallelepiped.WidthBase = rectangle.width;
            parallelepiped.WidthBase = rectangle.Width;
            richTextBox2.Text = rectangle.ToString();

            parallelepiped.Height_of_Prism = Convert.ToDouble(textHeigth_par.Text == " " ? "0" : textHeigth_par.Text);
            richTextBox1.Text = parallelepiped.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textHeigth_par_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
