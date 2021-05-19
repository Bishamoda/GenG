using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class Obrabotka : Form
    {
        public int _glubina;

        

        public Obrabotka()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 3;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (numericUpDown1.Value)
            {
                case 1:
                    _glubina = 1;
                break;

                case 2:
                    _glubina = 2;
                    break;

                case 3:
                    _glubina = 3;
                    break;
            }
            this.Close();

        }
    }
}
