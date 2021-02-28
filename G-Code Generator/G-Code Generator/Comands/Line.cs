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

        string a, b, c, l;

        public Line()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text))))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                l = txtLine.Text;
                Close();
            }

        }

        private void btnClearCoord_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public string Txt1
        {

            get
            {
                
                return l;
            }

        }

        private void btnG01_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text))))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                a = textBox1.Text;
                b = textBox2.Text;
                c = txtF.Text;


                txtLine.Text = txtLine.Text + Environment.NewLine + "G01  X "+ a + " Z "+ b + " F " + c + ";";

               
            }
        }

        private void btnG0_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text))))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                a = textBox1.Text;
                b = textBox2.Text;
                
                txtLine.Text = txtLine.Text + Environment.NewLine + "G00  X " + a + " Z " + b + ";";

               
            }
        }





    }
}
