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
            this.button1 = new System.Windows.Forms.Button();
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
            this.buttonLine.Location = new System.Drawing.Point(404, 68);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(94, 24);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(504, 68);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(78, 24);
            this.buttonCircle.TabIndex = 3;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // Faska
            // 
            this.Faska.Location = new System.Drawing.Point(588, 68);
            this.Faska.Name = "Faska";
            this.Faska.Size = new System.Drawing.Size(79, 24);
            this.Faska.TabIndex = 4;
            this.Faska.Text = "Фаска";
            this.Faska.UseVisualStyleBackColor = true;
            // 
            // skrug
            // 
            this.skrug.Location = new System.Drawing.Point(669, 68);
            this.skrug.Name = "skrug";
            this.skrug.Size = new System.Drawing.Size(82, 24);
            this.skrug.TabIndex = 5;
            this.skrug.Text = "Скругление";
            this.skrug.UseVisualStyleBackColor = true;
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
            this.btnGTable.Location = new System.Drawing.Point(757, 68);
            this.btnGTable.Name = "btnGTable";
            this.btnGTable.Size = new System.Drawing.Size(110, 24);
            this.btnGTable.TabIndex = 7;
            this.btnGTable.Text = "Таблица G/M";
            this.btnGTable.UseVisualStyleBackColor = true;
            this.btnGTable.Click += new System.EventHandler(this.btnGTable_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(719, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "В главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartTok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGTable);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.skrug);
            this.Controls.Add(this.Faska);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.textG);
            this.HelpButton = true;
            this.Name = "StartTok";
            this.Text = "G Code Generator";
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
        private System.Windows.Forms.Button button1;
    }
}

