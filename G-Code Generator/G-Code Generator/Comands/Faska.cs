using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class Faska : Form
    {

        private string _fLength, _fRadUp, _fRadDown, _startZ;
        public double l, rUp, rDown, z;

        public Faska()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox3.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                _startZ = textBox1.Text;
                _fRadUp = textBox2.Text;
                _fLength = textBox3.Text;
                _fRadDown = textBox4.Text;

                SuccessValue.CheckValueFaska(_fLength, _fRadUp, _fRadDown, _startZ);
                if (SuccessValue.valueFaska == true)
                {

                    l = SuccessValue._fLength;
                    rUp = SuccessValue._fRadUp;
                    rDown = SuccessValue._fRadDown;
                    z = SuccessValue._startfZ;

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
