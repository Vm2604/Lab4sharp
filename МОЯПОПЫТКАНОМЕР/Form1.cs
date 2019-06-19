using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew)) 
                using (StreamWriter sw = new StreamWriter(s)) 
                {
                    sw.Write(richTextBox2.Text);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream  myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream=openFileDialog1.OpenFile())!=null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox2.Text = filetext;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox1.Text = filetext;
                }
            }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
