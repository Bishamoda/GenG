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
        private string _x, _z;
        private double _zLength, _zWidth;
        private double _xStart, _zStart;
        private enum ButtonRectangel{ R1, R2, R3};
        private enum Razmer { G90, G91 };
        private Razmer razmer = Razmer.G90;
        private string _shpindel;
        private string _tool;
        private string _fast;
        private string _faska;
        private string _skrug;
        private string _slot;
        private string _rectangel1, _rectangle2, _rectangel3;
        private string _newLine = Environment.NewLine;
        private double _sLength, _sWidth;
        private double _rLength, _rWidth;
        private string _chernovayaObr;
        private double _glub;
        public static int _rec;


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

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
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
            if (cr1 == null) 
            {
                Circle cr2 = new Circle();
                cr2.ShowDialog();


                if (cr2.ShowDialog() == DialogResult.OK)
                {
                    cr2.Close();
                }
                else
                {
                    _skrug = cr2.circle  + _fast;
                    SuccessValue.ValidData();
                    checkBox5.Checked = true;
                }
            }
            else
            {
                cr1.Activate(); 
            }

        }

       //Табличка с G/M кодами
        private void btnGTable_Click(object sender, EventArgs e)
        {
            GMTable gmt1 = (GMTable)Application.OpenForms["GMTable"];
            if (gmt1 == null) 
            {
                GMTable gmt2 = new GMTable();
                gmt2.Show();
            }
            else
            {
                gmt1.Activate(); 
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
                        _shpindel = "G18 M03 S" + oborotShpindel;
                    }

                    if (checkBoxM04.Checked == true)
                    {
                        _shpindel = "G18 M04 S" + oborotShpindel;
                    }

                    SuccessValue.ValidData();
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
                
                _tool =  "M05 " + Environment.NewLine + "M06  T" + ToolChange;
                SuccessValue.ValidData();
            }
        }


        private void checkBoxG90_Click(object sender, EventArgs e)
        {
            if (checkBoxG91.Checked == true)
            {
                checkBoxG91.Checked = false;
                checkBoxG90.Checked = true;

                razmer = Razmer.G90;
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
                razmer = Razmer.G91;

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

        private void btn_StartPosition_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxStartX.Text)) || (string.IsNullOrEmpty(textBoxStartZ.Text)))
            {
                SuccessValue.InvalidData();

            }
            else
            {
                _x = textBoxStartX.Text;
                _z = textBoxStartZ.Text;

                _xStart = double.Parse(_x);
                _zStart = double.Parse(_z);
                SuccessValue.ValidData();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {  
           textG.Clear();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

        }


        private void btnFaska_Click(object sender, EventArgs e)
        {
            Faska fs1 = (Faska)Application.OpenForms["Faska"];
            if (fs1 == null) 
            {
                Faska fs2 = new Faska();
                fs2.ShowDialog();

                if (fs2.ShowDialog() == DialogResult.OK)
                {

                    fs2.Close();

                }
                else
                {
                    _faska = "G00 X0 Z" + fs2.z + 
                        _newLine + "G01 X" + fs2.rUp + " Z" + fs2.z + _fast +
                        _newLine + "G01 X" + fs2.rDown + " Z-" + fs2.l + _fast;

                    SuccessValue.ValidData();
                    checkBox1.Checked = true;
                }

            }
            else
            {
                fs1.Activate();
            }

        }

        private void btnChernovayaObr_Click(object sender, EventArgs e)
        {
            Obrabotka obr1 = (Obrabotka)Application.OpenForms["Obrabotka"];

            if (obr1 == null)
            {
                Obrabotka obr2 = new Obrabotka();
                obr2.ShowDialog();

                if (obr2.ShowDialog() == DialogResult.OK)
                {

                    obr2.Close();

                }
                else
                {

                    _glub = obr2._glubina;

                    _chernovayaObr = "G01" + _glub;

                    SuccessValue.ValidData();
                }

            }
            else
            {
                obr1.Activate();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxF.Text))
            {
                SuccessValue.InvalidData();
            }
            else
            {
                SuccessValue.CheckValueSpeed(textBoxF.Text);
                if (SuccessValue.CheckValueSpeed(textBoxF.Text) == true)
                {
                    _fast = " F" + textBoxF.Text;
                    SuccessValue.ValidData();
                }
                else
                {
                    SuccessValue.InvalidData();
                }
                
            }
        }

        private void buttonRectanle_Click(object sender, EventArgs e)
        {
            Rectangel(ButtonRectangel.R1);
        }

        private void btnRectangel2_Click(object sender, EventArgs e)
        {
            Rectangel(ButtonRectangel.R2);
        }

        private void btnRectangel3_Click(object sender, EventArgs e)
        {
            Rectangel(ButtonRectangel.R3);
        }

        private void btnGroove_Click(object sender, EventArgs e)
        {
            Slot sl1 = (Slot)Application.OpenForms["Slot"];
            if (sl1 == null)
            {
                Slot sl2 = new Slot();
                sl2.ShowDialog();


                if (sl2.ShowDialog() == DialogResult.OK)
                {

                    sl2.Close();

                }
                else
                {
                    _sLength = sl2.l;
                    _sWidth = sl2.w;

                    _slot = "G01 Z-" + sl2.z + _fast + 
                        _newLine + "G01 X" + (_rWidth - _sWidth) +_fast +
                        _newLine +"G01 Z-"+ (_rLength + _sLength) + _fast + 
                        _newLine + "G01 X" + ((_rWidth - _sWidth) + _sWidth)+ _fast;

                    SuccessValue.ValidData();

                    checkBox3.Checked = true;
                }

            }
            else
            {
                sl1.Activate();
            }

        }

        private void Rectangel(ButtonRectangel btnRec)
        {
            switch (btnRec)
            {
                case ButtonRectangel.R1:
                    {
                        _rec = 1;

                        Rectangle ra1 = (Rectangle)Application.OpenForms["Rectangle"];
                        if (ra1 == null) 
                        {
                            Rectangle ra2 = new Rectangle();
                            ra2.ShowDialog();

                            if (ra2.ShowDialog() == DialogResult.OK)
                            {
                                ra2.Close();
                            }
                            else
                            {
                                _rWidth = ra2.w;
                                _rLength = ra2.l + ra2.z;

                                _rectangel1 = "G01 Z-" + ra2.z + _fast + 
                                    _newLine + "G01 X" + ra2.w + _fast +
                                     _newLine + "G01 Z-" + (ra2.l + ra2.z) + _fast;

                                SuccessValue.ValidData();
                                checkBox2.Checked = true;

                            }
                        }
                        else
                        {
                            ra1.Activate();

                        }
                    }
                    break;

                case ButtonRectangel.R2:
                    {
                        _rec = 2;

                        Rectangle ra1 = (Rectangle)Application.OpenForms["Rectangle"];
                        if (ra1 == null) 
                        {
                            Rectangle ra2 = new Rectangle();
                            ra2.ShowDialog();

                            if (ra2.ShowDialog() == DialogResult.OK)
                            {
                                ra2.Close();
                            }
                            else
                            {
                                _rWidth = ra2.w;
                                _rLength = ra2.l + ra2.z;

                                _rectangle2 = "G01 Z-" + ra2.z + _fast +
                                    _newLine + "G01 X" + ra2.w + _fast +
                                     _newLine + "G01 Z-" + (ra2.l + ra2.z) + _fast;

                                SuccessValue.ValidData();
                                checkBox4.Checked = true;
                            }
                        }
                        else
                        {
                            ra1.Activate();
                            
                        }
                    }
                    break;

                case ButtonRectangel.R3:
                    {
                        _rec = 3;

                        Rectangle ra1 = (Rectangle)Application.OpenForms["Rectangle"];
                        if (ra1 == null) 
                        {
                            Rectangle ra2 = new Rectangle();
                            ra2.ShowDialog();

                            if (ra2.ShowDialog() == DialogResult.OK)
                            {
                                ra2.Close();
                            }
                            else
                            {
                                _rWidth = ra2.w;
                                _rLength = ra2.l + ra2.z;

                                _rectangel3 = "G01 Z-" + ra2.z + _fast +
                                    _newLine + "G01 X" + ra2.w + _fast +
                                     _newLine + "G01 Z-" + (ra2.l + ra2.z) + _fast;

                                SuccessValue.ValidData();

                                checkBox6.Checked = true;
                            }
                        }
                        else
                        {
                            ra1.Activate();

                        }
                    }
                    break;
            }

            
        }


        private void btn_Zagotovka_Click(object sender, EventArgs e)
        {

            Zagotovka zg1 = (Zagotovka)Application.OpenForms["Zagotovka"];
            if (zg1 == null) 
            {
                Zagotovka zg2 = new Zagotovka();
                zg2.ShowDialog();


                if (zg2.ShowDialog() == DialogResult.OK)
                {

                    zg2.Close();

                }
                else
                {
                    _zLength = zg2.L;
                    _zWidth = zg2.W;

                    SuccessValue.ValidData();
                }

            }
            else
            {
                zg1.Activate();
            }
        }

        

        private void btn_GenG_Click(object sender, EventArgs e)
        {

            var securityString = "G17 G90 G15 G191 G71 G72 G172 G272 G94 G97 G49 G40 G00 G80 G98 G53 G153 G193 G64 BRISK CUT2DF // Строка безопасности";

            switch (razmer)
            {
                case Razmer.G90:
                    if ((checkBox1.Checked) && (checkBox2.Checked) && (checkBox2.Checked) && (checkBox3.Checked) && (checkBox4.Checked) && (checkBox5.Checked) && (checkBox6.Checked) == true)
                    {
                        pictureBox2.Visible = true;
                        pictureBox1.Visible = false;

                        textG.Text = securityString + _newLine + _tool + _newLine + razmer.ToString() + _newLine + _shpindel + _newLine +
                        _faska + _newLine + _rectangel1 + _newLine + _slot + _newLine + _rectangle2 + _newLine + _skrug + _newLine + _rectangel3 + _newLine + "M30";
                    }else
                    {
                        MessageBox.Show("Вы не записали все размеры", "Внимание", MessageBoxButtons.OK);
                    }
                    break;

                case Razmer.G91:
                    
                    break;
            }

        }

       
    }
}
