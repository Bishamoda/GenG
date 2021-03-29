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
        private string _x;
        private string _z;
        private string _l1, _c1;
        
        


        public StartTok()
        {
            InitializeComponent();
            textG.ScrollBars = ScrollBars.Both;

            checkBoxG90.Checked = true;
            checkBoxM03.Checked = true;

            ToolTip t03 = new ToolTip();
            t03.SetToolTip(checkBoxM03, "Вращение по часовой стрелке");
            ToolTip t04 = new ToolTip();
            t03.SetToolTip(checkBoxM04, "Вращение против часовой стрелки");

            ToolTip t90 = new ToolTip();
            t90.SetToolTip(checkBoxG90, "При абсолютном способе координаты точек отсчитываются от постоянного начала координат. ");
            ToolTip t91 = new ToolTip();
            t91.SetToolTip(checkBoxG91, "При относительном (инкрементальном) способе отсчета" + Environment.NewLine +
                " за нулевое положение каждый раз принимается положение исполнительного органа, " + Environment.NewLine +
                "которое он занимал перед началом перемещения к следующей опорной точке. ");

            //Создание меню сохраннения файла
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");
            ToolStripMenuItem openItem = new ToolStripMenuItem("Открыть");

            fileItem.DropDownItems.Add(openItem);
            openItem.Click += openItem_Clicked;

            ToolStripMenuItem saveItem = new ToolStripMenuItem("Сохранить");
            saveItem.Click += saveItem_Clicked;
            fileItem.DropDownItems.Add(saveItem);
            menuStrip1.Items.Add(fileItem);
            

        }

        //Кнопка открыть файл c G-Code
        void openItem_Clicked(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                textG.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
                
            }

        }
        //Кнопка сохранение файла с G-Code
        void saveItem_Clicked(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textG.Text, Encoding.Default);
            }

        }

        //Вызов формы задания движения по окружности
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
                    _c1 = cr2.Txt1;
                    textG.SelectionStart = textG.TextLength;
                    textG.ScrollToCaret();
                    textG.Text = textG.Text + Environment.NewLine + _c1;
                }
            }
            else
            {
                cr1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
            }

        }

       //Табличка с G/M кодами
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

        //Кнопка возврата в главное меню
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

        private void faska_Click(object sender, EventArgs e)
        {

        }

      
        //Кнопка удаления строчки в главном текстовом окне
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textG.Text != "G21 G40 G49 G54 G80 G90")
            {
                textG.Text = textG.Text.Remove(textG.Text.LastIndexOf(Environment.NewLine));
            }
            
        }


        private void btn_M03_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtM03.Text))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                string oborotShpindel = txtM03.Text;
                SuccessValue.CheckValueShpindel(oborotShpindel);

                if (SuccessValue.CheckValueShpindel(oborotShpindel) == true)
                {
                    if (checkBoxM03.Checked == true)
                    {
                        textG.SelectionStart = textG.TextLength;
                        textG.ScrollToCaret();
                        textG.Text = textG.Text + Environment.NewLine + "G18 M03 " + oborotShpindel;
                    }

                    if (checkBoxM04.Checked == true)
                    {
                        textG.SelectionStart = textG.TextLength;
                        textG.ScrollToCaret();
                        textG.Text = textG.Text + Environment.NewLine + "G18 M04 " + oborotShpindel;
                    }
                }
                else
                {
                    SuccessValue.InvalidData();
                }
            }

        }

        

        private void btnToolChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTool.Text))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                string ToolChange = txtTool.Text;
                textG.SelectionStart = textG.TextLength;
                textG.ScrollToCaret();
                textG.Text = textG.Text + Environment.NewLine + "M05 " + Environment.NewLine + "M06  T" + ToolChange;

            }
        }


        private void checkBoxG90_Click(object sender, EventArgs e)
        {
            if (checkBoxG91.Checked == true)
            {
                checkBoxG91.Checked = false;
                checkBoxG90.Checked = true;

                textG.SelectionStart = textG.TextLength;
                textG.ScrollToCaret();
                textG.Text = textG.Text + Environment.NewLine + "G90 ";

            }
            else
            {
                checkBoxG91.Checked = true;
                checkBoxG90.Checked = false;
            }
        }

        private void checkBoxG91_Click(object sender, EventArgs e)
        {
            if (checkBoxG90.Checked == true)
            {
                checkBoxG90.Checked = false;
                checkBoxG91.Checked = true;

                textG.SelectionStart = textG.TextLength;
                textG.ScrollToCaret();
                textG.Text = textG.Text + Environment.NewLine + "G91 ";
            }
            else
            {
                checkBoxG91.Checked = true;
                checkBoxG90.Checked = false;
            }
        }

        private void checkBoxM03_Click(object sender, EventArgs e)
        {

            if (checkBoxM04.Checked == true)
            {
                checkBoxM04.Checked = false;
                checkBoxM03.Checked = true;
            }
            else
            {

                checkBoxM04.Checked = true;
                checkBoxM03.Checked = false;
            }
        }

        private void checkBoxM04_Click(object sender, EventArgs e)
        {
            if (checkBoxM03.Checked == true)
            {
                checkBoxM04.Checked = true;
                checkBoxM03.Checked = false;
            }
            else
            {

                checkBoxM04.Checked = false;
                checkBoxM03.Checked = true;
            }

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
                    _l1 = ln2.Txt1;
                    textG.SelectionStart = textG.TextLength;
                    textG.ScrollToCaret();
                    textG.Text = textG.Text + Environment.NewLine + _l1;
                }
            }
            else
            {
                ln1.Activate(); // Активируем форму на передний план (из трея или заднего плана)
                
            } 
        }

    }
}
