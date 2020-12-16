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
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.textG.Text = "G21 G40 G49 G54 G80 G90";
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(18, 27);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(94, 24);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(118, 27);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(78, 24);
            this.buttonCircle.TabIndex = 3;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // Faska
            // 
            this.Faska.Location = new System.Drawing.Point(202, 27);
            this.Faska.Name = "Faska";
            this.Faska.Size = new System.Drawing.Size(79, 24);
            this.Faska.TabIndex = 4;
            this.Faska.Text = "Фаска";
            this.Faska.UseVisualStyleBackColor = true;
            this.Faska.Click += new System.EventHandler(this.Faska_Click);
            // 
            // skrug
            // 
            this.skrug.Location = new System.Drawing.Point(283, 27);
            this.skrug.Name = "skrug";
            this.skrug.Size = new System.Drawing.Size(82, 24);
            this.skrug.TabIndex = 5;
            this.skrug.Text = "Скругление";
            this.skrug.UseVisualStyleBackColor = true;
            this.skrug.Click += new System.EventHandler(this.skrug_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(168, 68);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 24);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Удалить строчку";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGTable
            // 
            this.btnGTable.Location = new System.Drawing.Point(320, 315);
            this.btnGTable.Name = "btnGTable";
            this.btnGTable.Size = new System.Drawing.Size(110, 24);
            this.btnGTable.TabIndex = 7;
            this.btnGTable.Text = "Таблица G/M";
            this.btnGTable.UseVisualStyleBackColor = true;
            this.btnGTable.Click += new System.EventHandler(this.btnGTable_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(719, 600);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 23);
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
            this.panel1.Location = new System.Drawing.Point(320, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 208);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(787, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(625, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Частота оборот шпинделя S:";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(796, 167);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(66, 23);
            this.txtS.TabIndex = 13;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(796, 98);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(66, 23);
            this.txtT.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Инструмент:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Смена инструмента";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StartTok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGTable);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

