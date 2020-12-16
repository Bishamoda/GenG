using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace G_Code_Generator
{
    public partial class StartMenu : Form
    {
        
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btnTok_Click(object sender, EventArgs e)
        {

            StartTok tok1 = (StartTok)Application.OpenForms["StartTok"];
            if (tok1 == null) // Если форма не существует, то создаём
            {
                StartTok tok2 = new StartTok();
                tok2.Show();
            }
            else
            {
                tok1.Activate(); // Активируем форму на передний план (из трея или заднего плана)    
            }
        }

        private void btnFrez_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Извините, в данный момент этот функционал не поддерживается. ");

            //StartFrez frez1 = (StartFrez)Application.OpenForms["StartFrez"];
            //if (frez1 == null) // Если форма не существует, то создаём
            //{
            //    StartFrez frez2 = new StartFrez();
            //    frez2.Show();
            //}
            //else
            //{
            //    frez1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
            //}
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пождаловать в программу генерации G-кода! Для дальнейшей работы выберете вид обработки:" +
                " токарный и приступайте к формированию своего контура детали типа тел вращения. ");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Завершить работу?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Focus();
            }
            
        }
    }
}
