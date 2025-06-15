using System;
using System.ComponentModel;
using System.Drawing;
//using System.Reflection.Emit;
using System.Windows.Forms;

namespace Voice_Bridge
{
    partial class Login
    {
        private IContainer components = null;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;

        private void InitializeComponent()
        {
            this.textBox1 = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox2 = new TextBox();
            this.label3 = new Label();
            this.button1 = new Button();
            this.label4 = new Label();
            this.label5 = new Label();
            this.SuspendLayout();

            this.textBox1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = Color.Teal;
            this.textBox1.Location = new Point(927, 582);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(271, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);

            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("Stencil", 36f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Teal;
            this.label1.Location = new Point(713, 436);
            this.label1.Name = "label1";
            this.label1.Size = new Size(540, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN TO PLAY";

            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.Teal;
            this.label2.Location = new Point(723, 582);
            this.label2.Name = "label2";
            this.label2.Size = new Size(183, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";

            this.textBox2.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.Teal;
            this.textBox2.Location = new Point(927, 656);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(271, 46);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyDown += new KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.MouseHover += new EventHandler(this.textBox2_MouseHover);

            this.label3.AutoSize = true;
            this.label3.BackColor = Color.Transparent;
            this.label3.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Teal;
            this.label3.Location = new Point(724, 656);
            this.label3.Name = "label3";
            this.label3.Size = new Size(182, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "PASSWORD";

            this.button1.BackColor = Color.Transparent;
            this.button1.Cursor = Cursors.Hand;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.DarkSlateBlue;
            this.button1.Location = new Point(848, 757);
            this.button1.Name = "button1";
            this.button1.Size = new Size(266, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLICK TO PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);

            this.label4.AutoSize = true;
            this.label4.BackColor = Color.Transparent;
            this.label4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.Teal;
            this.label4.Location = new Point(792, 840);
            this.label4.Name = "label4";
            this.label4.Size = new Size(203, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Don't have an account?";

            this.label5.AutoSize = true;
            this.label5.BackColor = Color.Transparent;
            this.label5.Cursor = Cursors.Hand;
            this.label5.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.Teal;
            this.label5.Location = new Point(1001, 840);
            this.label5.Name = "label5";
            this.label5.Size = new Size(128, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Register Here";
            this.label5.Click += new EventHandler(this.label5_Click);
            this.label5.MouseHover += new EventHandler(this.label5_MouseHover);

            this.AutoScaleDimensions = new SizeF(10f, 25f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.Login_Page;
            this.ClientSize = new Size(1898, 1024);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = nameof(Login);
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
