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
            numericUpDown1.Value = 3;
            numericUpDown1.Minimum = 3;
            numericUpDown1.Maximum = 5;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (numericUpDown1.Value)
            {
                case 3:
                    _glubina = 3;
                break;

                case 4:
                    _glubina = 4;
                    break;

                case 5:
                    _glubina = 5;
                    break;
            }
            this.Close();

        }
    }
}
