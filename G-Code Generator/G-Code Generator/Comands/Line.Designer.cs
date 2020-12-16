namespace G_Code_Generator
{
    partial class Line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnG1 = new System.Windows.Forms.Button();
            this.btnG0 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Координата Х:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Координата Z:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Принять";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(40, 166);
            this.txtLine.Multiline = true;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(242, 162);
            this.txtLine.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnG1
            // 
            this.btnG1.Location = new System.Drawing.Point(155, 358);
            this.btnG1.Name = "btnG1";
            this.btnG1.Size = new System.Drawing.Size(127, 39);
            this.btnG1.TabIndex = 7;
            this.btnG1.Text = "Линейная интерполяция";
            this.btnG1.UseVisualStyleBackColor = true;
            this.btnG1.Click += new System.EventHandler(this.btnG01_Click);
            // 
            // btnG0
            // 
            this.btnG0.Location = new System.Drawing.Point(310, 358);
            this.btnG0.Name = "btnG0";
            this.btnG0.Size = new System.Drawing.Size(149, 39);
            this.btnG0.TabIndex = 8;
            this.btnG0.Text = "Ускоренное перемещение";
            this.btnG0.UseVisualStyleBackColor = true;
            this.btnG0.Click += new System.EventHandler(this.btnG0_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пример использования команды G01.\r\n Рабочее перемещение инструмента в точку X 30 " +
    "Z 40.\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Скорость F:";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(155, 98);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 23);
            this.txtF.TabIndex = 10;
            // 
            // Line
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(755, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnG0);
            this.Controls.Add(this.btnG1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Line";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Линейная интерполяция";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnG1;
        private System.Windows.Forms.Button btnG0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtF;
    }
}