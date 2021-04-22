using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class Zagotovka : Form
    {

        private string _zLength, _zWidth;
        private bool successL = false;
        private bool successW = false;
        private float zL, zW;
        public float L, W;


        public Zagotovka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                _zLength = textBox1.Text;
                _zWidth = textBox2.Text;

                successL = float.TryParse(_zLength, out zL);
                successW = float.TryParse(_zWidth, out zW);

                while (successL && successW == true)
                {
                    successL = false;
                    successW = false;

                    L = zL;
                    W = zW;

                    this.Close();
                }

            }
        }
    }
}
