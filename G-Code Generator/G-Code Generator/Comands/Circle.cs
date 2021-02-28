using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class Circle : Form
    {
        string a, b, r, f, c;

        public Circle()
        {
            InitializeComponent();
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text) || (string.IsNullOrEmpty(txtF.Text)))))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                c = txtCircle.Text;
                Close();
            }

        }

        public string Txt1
        {

            get
            {

                return c;
            }

        }


        private void btnG2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text) || (string.IsNullOrEmpty(txtF.Text)))))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                a = textBox1.Text;
                b = textBox2.Text;
                r = txtR.Text;
                f = txtF.Text;

                txtCircle.Text = txtCircle.Text + Environment.NewLine + "G02  X " + a + " Z " + b + " R " + r + " F " + f + ";";

                textBox1.Clear();
                textBox2.Clear();
                txtR.Clear();
                
            }
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text) || (string.IsNullOrEmpty(txtF.Text)))))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                a = textBox1.Text;
                b = textBox2.Text;
                r = txtR.Text;
                f = txtF.Text;

                txtCircle.Text = txtCircle.Text + Environment.NewLine + "G03  X " + a + " Z " + b + " R " + r + " F " + f + ";";

                textBox1.Clear();
                textBox2.Clear();
                txtR.Clear();
                
            }
        }
    }
}
