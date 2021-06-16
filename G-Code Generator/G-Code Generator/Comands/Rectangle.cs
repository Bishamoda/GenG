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
    public partial class Rectangle : Form
    {
        private string _rLength, _rWidth, _startZ;
        public double l, w, z;

        private void txtStartZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxW_TextChanged(object sender, EventArgs e)
        {

        }

        public Rectangle()
        {
            InitializeComponent();

            switch (StartTok._rec)
            {
                case 1:
                    txtStartZ.Text = "2";
                    textBoxL.Text = "8";
                    textBoxW.Text = "15";
                    break;

                case 2:
                    txtStartZ.Text = "15";
                    textBoxL.Text = "20";
                    textBoxW.Text = "15";
                    break;

                case 3:
                    txtStartZ.Text = "50";
                    textBoxL.Text = "30";
                    textBoxW.Text = "30";
                    break;

            }

        }

        


        private void btnOK_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(textBoxL.Text)) || (string.IsNullOrEmpty(textBoxW.Text) || (string.IsNullOrEmpty(txtStartZ.Text))))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                _startZ = txtStartZ.Text;
                _rLength = textBoxL.Text;
                _rWidth = textBoxW.Text;

                SuccessValue.CheckValueRectangle(_rWidth, _rLength, _startZ);

                if (SuccessValue.valueRectangle == true)
                {

                    l = SuccessValue._rLength;
                    w = SuccessValue._rWidth;
                    z = SuccessValue._startRZ;

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
