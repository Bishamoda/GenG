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
        private string _x, _z, _r, _f, _circleForm;
        public string Txt1 { get { return _circleForm; } }

        public Circle()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            txtR.Clear();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtR.Text) || (string.IsNullOrEmpty(txtF.Text)))))
            {
                SuccessValue.InvalidData();

            }
            else
            {
                _circleForm = txtCircle.Text;
                Close();
            }

        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtR.Text) || (string.IsNullOrEmpty(txtF.Text)))))
            {
                SuccessValue.InvalidData();

            }
            else
            {
                _x = textBox1.Text;
                _z = textBox2.Text;
                _r = txtR.Text;
                _f = txtF.Text;
               
                SuccessValue.CheckValuesG02(_x, _z, _r);
                SuccessValue.CheckValueSpeed(_f);
                if (SuccessValue.successR && SuccessValue.CheckValueSpeed(_f)== true)
                {
                        txtCircle.Text = txtCircle.Text + Environment.NewLine + "G02  X " + _x + " Z " + _z + " R " + _r + " F " + _f + ";";
                        
                }
                else
                {
                    SuccessValue.InvalidData();
                }
            }
        }

        


        private void btnG3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtF.Text) || (string.IsNullOrEmpty(txtF.Text)))))
            {
                SuccessValue.InvalidData();

            }
            else
            {

                _x = textBox1.Text;
                _z = textBox2.Text;
                _r = txtR.Text;
                _f = txtF.Text;


                SuccessValue.CheckValuesG03(_x, _z, _r);
                SuccessValue.CheckValueSpeed(_f);
                if (SuccessValue.successR && SuccessValue.CheckValueSpeed(_f) == true)
                {
                    txtCircle.Text = txtCircle.Text + Environment.NewLine + "G03  X " + _x + " Z " + _z + " R " + _r + " F " + _f + ";";
                    
                    
                }
                else 
                {
                    SuccessValue.InvalidData();
                }  
            }
        }

        
    }
}
