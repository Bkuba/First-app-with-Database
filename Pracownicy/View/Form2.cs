using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //public Form2(string text)
        //{
        //    label1.Text = text;

        //}
        //Form1 f1 = new Form1();

        private void Form2_Load(object sender, EventArgs e)
        {
            ////Form1 f1 = new Form1();
            //tbnapis.Text = Form1.txtbImietext;
        }

        public string ModifyTextBoxValue
        {
            get { return tbnapis.Text; }
            set { tbnapis.Text = value; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (TextBoxWithSameText != null)
            //    TextBoxWithSameText.Text = tbnapis.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = tbnapis.Text + textBox1.Text;
        }
    }
}
