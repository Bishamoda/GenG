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
            this.btn_M03.Location = new System.Drawing.Point(322, 166);
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
            this.label1.Location = new System.Drawing.Point(297, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Частота оборот шпинделя S:";
            // 
            // txtM03
            // 
            this.txtM03.Location = new System.Drawing.Point(468, 132);
            this.txtM03.Name = "txtM03";
            this.txtM03.Size = new System.Drawing.Size(66, 23);
            this.txtM03.TabIndex = 13;
            // 
            // txtTool
            // 
            this.txtTool.Location = new System.Drawing.Point(796, 127);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(66, 23);
            this.txtTool.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Инструмент T:";
            // 
            // btnToolChange
            // 
            this.btnToolChange.Location = new System.Drawing.Point(719, 156);
            this.btnToolChange.Name = "btnToolChange";
            this.btnToolChange.Size = new System.Drawing.Size(143, 30);
            this.btnToolChange.TabIndex = 16;
            this.btnToolChange.Text = "Смена инструмента";
            this.btnToolChange.UseVisualStyleBackColor = true;
            this.btnToolChange.Click += new System.EventHandler(this.btnToolChange_Click);
            // 
            // StartTok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 643);
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
    }
}

