
namespace G_Code_Generator
{
    partial class StartFrez
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGTable = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.skrug = new System.Windows.Forms.Button();
            this.Faska = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.textG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGTable
            // 
            this.btnGTable.Location = new System.Drawing.Point(671, 48);
            this.btnGTable.Name = "btnGTable";
            this.btnGTable.Size = new System.Drawing.Size(113, 23);
            this.btnGTable.TabIndex = 14;
            this.btnGTable.Text = "Таблица G/M";
            this.btnGTable.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(119, 48);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(128, 23);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Удалить строчку";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // skrug
            // 
            this.skrug.Location = new System.Drawing.Point(590, 48);
            this.skrug.Name = "skrug";
            this.skrug.Size = new System.Drawing.Size(75, 23);
            this.skrug.TabIndex = 12;
            this.skrug.Text = "Скругление";
            this.skrug.UseVisualStyleBackColor = true;
            // 
            // Faska
            // 
            this.Faska.Location = new System.Drawing.Point(495, 48);
            this.Faska.Name = "Faska";
            this.Faska.Size = new System.Drawing.Size(75, 23);
            this.Faska.TabIndex = 11;
            this.Faska.Text = "Фаска";
            this.Faska.UseVisualStyleBackColor = true;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(396, 48);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(75, 23);
            this.buttonCircle.TabIndex = 10;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(296, 48);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 9;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            // 
            // textG
            // 
            this.textG.Location = new System.Drawing.Point(12, 77);
            this.textG.Multiline = true;
            this.textG.Name = "textG";
            this.textG.Size = new System.Drawing.Size(235, 525);
            this.textG.TabIndex = 8;
            this.textG.Text = "G21 G40 G49 G54 G80 G90";
            // 
            // StartFrez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 620);
            this.Controls.Add(this.btnGTable);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.skrug);
            this.Controls.Add(this.Faska);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.textG);
            this.Name = "StartFrez";
            this.Text = "StartFrez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGTable;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button skrug;
        private System.Windows.Forms.Button Faska;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.TextBox textG;
    }
}