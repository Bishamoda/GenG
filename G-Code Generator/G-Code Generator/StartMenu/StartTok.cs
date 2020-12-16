using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace G_Code_Generator
{
    public partial class StartTok : Form
    {

        string l1, c1;
        
        


        public StartTok()
        {
            InitializeComponent();


            //Создание меню сохраннения файла
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");
            ToolStripMenuItem openItem = new ToolStripMenuItem("Открыть");
            fileItem.DropDownItems.Add(openItem);
            openItem.Click += openItem_Clicked;
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Сохранить");
            saveItem.Click += saveItem_Clicked;
            fileItem.DropDownItems.Add(saveItem);
            menuStrip1.Items.Add(fileItem);
            //

        }
        void openItem_Clicked(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                textG.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
                
            }

        }
        void saveItem_Clicked(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textG.Text, Encoding.Default);
            }

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
                    c1 = cr2.Txt1;
                    textG.SelectionStart = textG.TextLength;
                    textG.ScrollToCaret();
                    textG.Text = textG.Text + Environment.NewLine + c1;
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

        private void btnBack_Click(object sender, EventArgs e)
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

        

        private void skrug_Click(object sender, EventArgs e)
        {

        }

        private void Faska_Click(object sender, EventArgs e)
        {

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
                    l1 = ln2.Txt1;
                    textG.SelectionStart = textG.TextLength;
                    textG.ScrollToCaret();
                    textG.Text = textG.Text + Environment.NewLine + l1;
                }
            }
            else
            {
                ln1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
                
            } 
        }

    }
}
