namespace G_Code_Generator
{
    partial class Circle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circle));
            this.label4 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnG3 = new System.Windows.Forms.Button();
            this.btnG2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCircle = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Радиус R:";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(153, 131);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 23);
            this.txtF.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 60);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пример использования команды G02 - перемещение по часовой стрелке.\r\nПеремещается " +
    "из точки А в точку В. \r\nПример кадра: G02 Х0 Z-10 R10.\r\n\r\n";
            // 
            // btnG3
            // 
            this.btnG3.Location = new System.Drawing.Point(308, 379);
            this.btnG3.Name = "btnG3";
            this.btnG3.Size = new System.Drawing.Size(149, 39);
            this.btnG3.TabIndex = 20;
            this.btnG3.Text = "Круг. инт. против часовой";
            this.btnG3.UseVisualStyleBackColor = true;
            this.btnG3.Click += new System.EventHandler(this.btnG3_Click);
            // 
            // btnG2
            // 
            this.btnG2.Location = new System.Drawing.Point(153, 379);
            this.btnG2.Name = "btnG2";
            this.btnG2.Size = new System.Drawing.Size(127, 39);
            this.btnG2.TabIndex = 19;
            this.btnG2.Text = "Кргу. инт. по часовой";
            this.btnG2.UseVisualStyleBackColor = true;
            this.btnG2.Click += new System.EventHandler(this.btnG2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtCircle
            // 
            this.txtCircle.Location = new System.Drawing.Point(38, 187);
            this.txtCircle.Multiline = true;
            this.txtCircle.Name = "txtCircle";
            this.txtCircle.Size = new System.Drawing.Size(242, 162);
            this.txtCircle.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 379);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 39);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Принять";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Координата Z:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Координата Х:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Радиус F:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(153, 97);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 23);
            this.txtR.TabIndex = 24;
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnG3);
            this.Controls.Add(this.btnG2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCircle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Circle";
            this.Text = "Circle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnG3;
        private System.Windows.Forms.Button btnG2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCircle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtR;
    }
}