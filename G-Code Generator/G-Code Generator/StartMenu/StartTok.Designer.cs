namespace G_Code_Generator
{
    partial class StartTok
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textG = new System.Windows.Forms.TextBox();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.Faska = new System.Windows.Forms.Button();
            this.skrug = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGTable = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_M03 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtM03 = new System.Windows.Forms.TextBox();
            this.txtTool = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToolChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxG90 = new System.Windows.Forms.CheckBox();
            this.checkBoxG91 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxStartZ = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.btn_StartPosition = new System.Windows.Forms.Button();
            this.checkBoxM03 = new System.Windows.Forms.CheckBox();
            this.checkBoxM04 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textG
            // 
            this.textG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textG.Location = new System.Drawing.Point(12, 98);
            this.textG.Multiline = true;
            this.textG.Name = "textG";
            this.textG.Size = new System.Drawing.Size(281, 525);
            this.textG.TabIndex = 1;
            this.textG.Text = "G21 G40 G49 G54 G80 G90\r\n";
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(26, 18);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(104, 36);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(136, 18);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(78, 36);
            this.buttonCircle.TabIndex = 3;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // Faska
            // 
            this.Faska.Location = new System.Drawing.Point(222, 18);
            this.Faska.Name = "Faska";
            this.Faska.Size = new System.Drawing.Size(79, 36);
            this.Faska.TabIndex = 4;
            this.Faska.Text = "Фаска";
            this.Faska.UseVisualStyleBackColor = true;
            this.Faska.Click += new System.EventHandler(this.faska_Click);
            // 
            // skrug
            // 
            this.skrug.Location = new System.Drawing.Point(317, 18);
            this.skrug.Name = "skrug";
            this.skrug.Size = new System.Drawing.Size(82, 36);
            this.skrug.TabIndex = 5;
            this.skrug.Text = "Скругление";
            this.skrug.UseVisualStyleBackColor = true;
            this.skrug.Click += new System.EventHandler(this.skrug_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(168, 60);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 32);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Удалить строчку";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGTable
            // 
            this.btnGTable.Location = new System.Drawing.Point(414, 18);
            this.btnGTable.Name = "btnGTable";
            this.btnGTable.Size = new System.Drawing.Size(110, 36);
            this.btnGTable.TabIndex = 7;
            this.btnGTable.Text = "Таблица G/M";
            this.btnGTable.UseVisualStyleBackColor = true;
            this.btnGTable.Click += new System.EventHandler(this.btnGTable_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(719, 590);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 33);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "В главное меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.skrug);
            this.panel1.Controls.Add(this.buttonLine);
            this.panel1.Controls.Add(this.buttonCircle);
            this.panel1.Controls.Add(this.Faska);
            this.panel1.Controls.Add(this.btnGTable);
            this.panel1.Location = new System.Drawing.Point(320, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 69);
            this.panel1.TabIndex = 9;
            // 
            // btn_M03
            // 
            this.btn_M03.Location = new System.Drawing.Point(769, 127);
            this.btn_M03.Name = "btn_M03";
            this.btn_M03.Size = new System.Drawing.Size(75, 30);
            this.btn_M03.TabIndex = 10;
            this.btn_M03.Text = "Записать";
            this.btn_M03.UseVisualStyleBackColor = true;
            this.btn_M03.Click += new System.EventHandler(this.btn_M03_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Частота оборотов шпинделя S:";
            // 
            // txtM03
            // 
            this.txtM03.Location = new System.Drawing.Point(769, 98);
            this.txtM03.Name = "txtM03";
            this.txtM03.Size = new System.Drawing.Size(75, 23);
            this.txtM03.TabIndex = 13;
            // 
            // txtTool
            // 
            this.txtTool.Location = new System.Drawing.Point(414, 98);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(66, 23);
            this.txtTool.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Инструмент T:";
            // 
            // btnToolChange
            // 
            this.btnToolChange.Location = new System.Drawing.Point(322, 127);
            this.btnToolChange.Name = "btnToolChange";
            this.btnToolChange.Size = new System.Drawing.Size(158, 30);
            this.btnToolChange.TabIndex = 16;
            this.btnToolChange.Text = "Смена инструмента";
            this.btnToolChange.UseVisualStyleBackColor = true;
            this.btnToolChange.Click += new System.EventHandler(this.btnToolChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "1) Назначаем номер инструмента:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "2) Записываем частоту оборотов шпинделя:";
            // 
            // checkBoxG90
            // 
            this.checkBoxG90.AutoSize = true;
            this.checkBoxG90.Location = new System.Drawing.Point(322, 227);
            this.checkBoxG90.Name = "checkBoxG90";
            this.checkBoxG90.Size = new System.Drawing.Size(218, 19);
            this.checkBoxG90.TabIndex = 19;
            this.checkBoxG90.Text = "G90 - абсолютная (по умолчанию)";
            this.checkBoxG90.UseVisualStyleBackColor = true;
            this.checkBoxG90.Click += new System.EventHandler(this.checkBoxG90_Click);
            // 
            // checkBoxG91
            // 
            this.checkBoxG91.AutoSize = true;
            this.checkBoxG91.Location = new System.Drawing.Point(322, 252);
            this.checkBoxG91.Name = "checkBoxG91";
            this.checkBoxG91.Size = new System.Drawing.Size(139, 19);
            this.checkBoxG91.TabIndex = 20;
            this.checkBoxG91.Text = "G91 - относительная";
            this.checkBoxG91.UseVisualStyleBackColor = true;
            this.checkBoxG91.Click += new System.EventHandler(this.checkBoxG91_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "3) Выбираем систему координат:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "4) Назначаем начальную точку:\r\n";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(683, 223);
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(75, 23);
            this.textBoxStartX.TabIndex = 24;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(591, 226);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(85, 15);
            this.labelX.TabIndex = 23;
            this.labelX.Text = "Координата Х:";
            // 
            // textBoxStartZ
            // 
            this.textBoxStartZ.Location = new System.Drawing.Point(683, 252);
            this.textBoxStartZ.Name = "textBoxStartZ";
            this.textBoxStartZ.Size = new System.Drawing.Size(75, 23);
            this.textBoxStartZ.TabIndex = 26;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(591, 255);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(86, 15);
            this.labelZ.TabIndex = 25;
            this.labelZ.Text = "Коорлината Z:";
            // 
            // btn_StartPosition
            // 
            this.btn_StartPosition.Location = new System.Drawing.Point(683, 281);
            this.btn_StartPosition.Name = "btn_StartPosition";
            this.btn_StartPosition.Size = new System.Drawing.Size(75, 30);
            this.btn_StartPosition.TabIndex = 27;
            this.btn_StartPosition.Text = "Записать";
            this.btn_StartPosition.UseVisualStyleBackColor = true;
            // 
            // checkBoxM03
            // 
            this.checkBoxM03.AutoSize = true;
            this.checkBoxM03.Location = new System.Drawing.Point(591, 127);
            this.checkBoxM03.Name = "checkBoxM03";
            this.checkBoxM03.Size = new System.Drawing.Size(49, 19);
            this.checkBoxM03.TabIndex = 28;
            this.checkBoxM03.Text = "M03";
            this.checkBoxM03.UseVisualStyleBackColor = true;
            this.checkBoxM03.Click += new System.EventHandler(this.checkBoxM03_Click);
            // 
            // checkBoxM04
            // 
            this.checkBoxM04.AutoSize = true;
            this.checkBoxM04.Location = new System.Drawing.Point(670, 127);
            this.checkBoxM04.Name = "checkBoxM04";
            this.checkBoxM04.Size = new System.Drawing.Size(49, 19);
            this.checkBoxM04.TabIndex = 29;
            this.checkBoxM04.Text = "M04";
            this.checkBoxM04.UseVisualStyleBackColor = true;
            this.checkBoxM04.Click += new System.EventHandler(this.checkBoxM04_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "5) Используем нужную операцию:\r\n";
            // 
            // StartTok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 643);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxM04);
            this.Controls.Add(this.checkBoxM03);
            this.Controls.Add(this.btn_StartPosition);
            this.Controls.Add(this.textBoxStartZ);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.textBoxStartX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxG91);
            this.Controls.Add(this.checkBoxG90);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToolChange);
            this.Controls.Add(this.txtTool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtM03);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_M03);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.textG);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StartTok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Токарная обработка";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button Faska;
        private System.Windows.Forms.Button skrug;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGTable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_M03;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtM03;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToolChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxG90;
        private System.Windows.Forms.CheckBox checkBoxG91;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxStartZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button btn_StartPosition;
        private System.Windows.Forms.CheckBox checkBoxM03;
        private System.Windows.Forms.CheckBox checkBoxM04;
        private System.Windows.Forms.Label label7;
    }
}

