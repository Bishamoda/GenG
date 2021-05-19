using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class Slot : Form
    {
        private string _sLength, _sWidth, _startSZ;
        public double l, w, z;

        public Slot()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(textBoxW.Text)) || (string.IsNullOrEmpty(textBoxW.Text) || (string.IsNullOrEmpty(textBoxStartZ.Text))))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                _startSZ = textBoxStartZ.Text;
                _sLength = textBoxL.Text;
                _sWidth = textBoxW.Text;

                SuccessValue.CheckValueSlot(_sLength, _sWidth, _startSZ);
                if (SuccessValue.valueSlot == true)
                {

                    l = SuccessValue._sLength;
                    w = SuccessValue._sWidth;
                    z = SuccessValue._startSZ;

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
