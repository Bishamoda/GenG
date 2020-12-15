using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class StartTok : Form
    {

        double X, Y;
        
        string l1, l2;
        
        


        public StartTok()
        {
            InitializeComponent();
           
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            

            Circle cr1 = (Circle)Application.OpenForms["Circle"];
            if (cr1 == null) // Если форма не существует, то создаём
            {
                Circle cr2 = new Circle();
                cr2.ShowDialog();


                if (cr2.ShowDialog() == DialogResult.OK)
                {
                    cr2.Close();
                }
                else
                {
                    
                //    textG.SelectionStart = textG.TextLength;
                //    textG.ScrollToCaret();
                }
            }
            else
            {
                cr1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
            }

        }

        private void btnGTable_Click(object sender, EventArgs e)
        {
            GMTable gmt1 = (GMTable)Application.OpenForms["GMTable"];
            if (gmt1 == null) // Если форма не существует, то создаём
            {
                GMTable gmt2 = new GMTable();
                gmt2.Show();
            }
            else
            {
                gmt1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вернуться в главное меню?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Focus();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            textG.Text = textG.Text.Remove(textG.Text.LastIndexOf(Environment.NewLine));
        }

        public void buttonLine_Click(object sender, EventArgs e)
        {
            Line ln1 = (Line)Application.OpenForms["Line"];
            if (ln1 == null) // Если форма не существует, то создаём
            {
                Line ln2 = new Line();
                ln2.ShowDialog();

                if (ln2.ShowDialog() == DialogResult.OK)
                {
                    ln2.Close();
                }
                else
                {
                    //l1 = ln2.Txt1;
                    //l2 = ln2.Txt2;
                    //textG.SelectionStart = textG.TextLength;
                    //textG.ScrollToCaret();
                }
            }
            else
            {
                ln1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
                
            } 
        }

    }
}
