using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace G_Code_Generator
{
    public partial class Line : Form
    {

        string a, b;

        public Line()
        {
            InitializeComponent();
        }

        public void Line_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrEmpty(textBox1.Text)) && (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                a = textBox1.Text;
                b = textBox2.Text;
            }

        }

        public string Txt1
        {

            get
            {
                
                return a;
            }

        }

        public string Txt2
        {

            get
            {
                
                return b;
            }
        }


      


    }
}
