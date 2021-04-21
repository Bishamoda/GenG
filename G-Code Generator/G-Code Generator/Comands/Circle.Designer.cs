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
            this.label4 = new System.Windows.Forms.Label();
            this.btnG3 = new System.Windows.Forms.Button();
            this.btnG2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Радиус R:";
            // 
            // btnG3
            // 
            this.btnG3.Location = new System.Drawing.Point(167, 154);
            this.btnG3.Name = "btnG3";
            this.btnG3.Size = new System.Drawing.Size(118, 39);
            this.btnG3.TabIndex = 20;
            this.btnG3.Text = "Против часовой";
            this.btnG3.UseVisualStyleBackColor = true;
            this.btnG3.Click += new System.EventHandler(this.btnG3_Click);
            // 
            // btnG2
            // 
            this.btnG2.Location = new System.Drawing.Point(33, 154);
            this.btnG2.Name = "btnG2";
            this.btnG2.Size = new System.Drawing.Size(106, 39);
            this.btnG2.TabIndex = 19;
            this.btnG2.Text = "По часовой";
            this.btnG2.UseVisualStyleBackColor = true;
            this.btnG2.Click += new System.EventHandler(this.btnG2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Конечная координата Z:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "50";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Конечная координата Х:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(222, 105);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 23);
            this.txtR.TabIndex = 24;
            this.txtR.Text = "15";
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 211);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnG3);
            this.Controls.Add(this.btnG2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Circle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Скругление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnG3;
        private System.Windows.Forms.Button btnG2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtR;
    }
}