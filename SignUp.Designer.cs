//using System.Reflection.Emit;
using System;

namespace Voice_Bridge
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.button1 = new Button();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("Stencil", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.DarkSlateBlue;
            this.label1.Location = new Point(167, 77);
            this.label1.Name = "label1";
            this.label1.Size = new Size(376, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "GET STARTED!";

            // label2
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Teal;
            this.label2.Location = new Point(117, 272);
            this.label2.Name = "label2";
            this.label2.Size = new Size(183, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME";

            // label3
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.Transparent;
            this.label3.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Teal;
            this.label3.Location = new Point(117, 379);
            this.label3.Name = "label3";
            this.label3.Size = new Size(182, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";

            // textBox1
            this.textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            this.textBox1.Location = new Point(329, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(254, 47);
            this.textBox1.TabIndex = 3;
            this.textBox1.MouseHover += new EventHandler(this.textBox1_MouseHover);

            // textBox2
            this.textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            this.textBox2.Location = new Point(329, 363);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(254, 54);
            this.textBox2.TabIndex = 4;
            this.textBox2.MouseHover += new EventHandler(this.textBox2_MouseHover);

            // button1
            this.button1.BackColor = Color.Transparent;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.DarkSlateBlue;
            this.button1.Location = new Point(246, 495);
            this.button1.Name = "button1";
            this.button1.Size = new Size(186, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "SIGN UP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button1.MouseHover += new EventHandler(this.button1_MouseHover);

            // SignUp Form
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.Signup_Page;
            this.ClientSize = new Size(680, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SIGNUP";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
