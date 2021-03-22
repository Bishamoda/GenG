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

        private string _x, _z, _f, _lineForm;

        public Line()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text))))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                _lineForm = txtLine.Text;
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
                
                return _lineForm;
            }

        }

        private void btnG01_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text))))
            {
                SuccessValue.InvalidData();

            }
            else
            {
                _x = textBox1.Text;
                _z = textBox2.Text;
                _f = txtF.Text;

                SuccessValue.NextValuesLine(_x, _z);
                if (SuccessValue.NextValuesLine(_x, _z) == true)
                {
                    txtLine.Text = txtLine.Text + Environment.NewLine + "G01  X " + _x + " Z " + _z + " F " + _f + ";";
                }
                else
                {
                    SuccessValue.InvalidData();
                }

               
            }
        }

        private void btnG0_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text))))
            {
                SuccessValue.InvalidData();

            }
            else
            {
                _x = textBox1.Text;
                _z = textBox2.Text;
                SuccessValue.NextValuesLine(_x, _z);

                if (SuccessValue.NextValuesLine(_x, _z) == true)
                {
                    txtLine.Text = txtLine.Text + Environment.NewLine + "G00  X " + _x + " Z " + _z + ";";
                }
                else
                {
                    SuccessValue.InvalidData();
                }


            }
        }

        
    }
}
