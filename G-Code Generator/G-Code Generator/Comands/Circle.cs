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
        private string _x, _z, _r;
        public string circle;

        public Circle()
        {
            InitializeComponent();
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtR.Text))))
            {
                SuccessValue.InvalidData();

            }
            else
            {
                _x = textBox1.Text;
                _z = textBox2.Text;
                _r = txtR.Text;
               
                SuccessValue.CheckValuesG02(_x, _z, _r); 
                if (SuccessValue.successR == true)
                {
                    circle = "G02  X"+ _x + " Z-" + _z + " R" + _r;
                    
                    this.Close();
                }
                else
                {
                    SuccessValue.InvalidData();
                }
            }
        }

        


        private void btnG3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(txtR.Text))))
            {
                SuccessValue.InvalidData();

            }
            else
            {

                _x = textBox1.Text;
                _z = textBox2.Text;
                _r = txtR.Text;

                SuccessValue.CheckValuesG03(_x, _z, _r);
                if (SuccessValue.successR == true)
                {

                    circle = "G03  X" + _x + " Z-" + _z + " R" + _r;
                    this.Close();
                }
                else 
                {
                    SuccessValue.InvalidData();
                }  
            }
        }

        
    }
}
