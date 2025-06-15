////using System.ComponentModel;
//////using System.Reflection.Emit;
////using System;
////using System.Reflection.Emit;

////namespace Voice_Bridge
////{
////    partial class Instrumental_Sound
////    {
////        private IContainer components = null;
////        //private System.Windows.f Label label1;
////        //private Label label2;
////        //private Button button1;
////        //private TextBox textBox1;
////        private System.Windows.Forms.PictureBox pictureBox1;

////        private System.Windows.Forms.Label label1;
////        private System.Windows.Forms.Label label2;
////        private System.Windows.Forms.TextBox textBox1;
////        private System.Windows.Forms.Button button1;

////        private void InitializeComponent()
////        {
////            //this.label1 = new Label();
////            //this.label2 = new Label();
////            //this.button1 = new Button();
////            //this.textBox1 = new TextBox();
////            //this.pictureBox1 = new PictureBox();
////            //((ISupportInitialize)(this.pictureBox1)).BeginInit();
////            //this.SuspendLayout();

////            //// label1
////            //this.label1.AutoSize = true;
////            //this.label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
////            //this.label1.Location = new Point(30, 20);
////            //this.label1.Name = "label1";
////            //this.label1.Size = new Size(151, 21);
////            //this.label1.Text = "Guess the sound";

////            //// label2
////            //this.label2.AutoSize = true;
////            //this.label2.Location = new Point(30, 300);
////            //this.label2.Name = "label2";
////            //this.label2.Size = new Size(53, 15);
////            //this.label2.Text = "SCORE: 0";

////            //// button1
////            //this.button1.Location = new Point(30, 250);
////            //this.button1.Name = "button1";
////            //this.button1.Size = new Size(120, 30);
////            //this.button1.Text = "Submit";
////            //this.button1.UseVisualStyleBackColor = true;
////            //this.button1.Click += new EventHandler(this.button1_Click);

////            //// textBox1
////            //this.textBox1.Location = new Point(30, 210);
////            //this.textBox1.Name = "textBox1";
////            //this.textBox1.Size = new Size(200, 23);

////            //// pictureBox1
////            //this.pictureBox1.Location = new Point(30, 60);
////            //this.pictureBox1.Name = "pictureBox1";
////            //this.pictureBox1.Size = new Size(200, 130);
////            //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

////            //// Instrumental_Sound
////            //this.AutoScaleDimensions = new SizeF(7F, 15F);
////            //this.AutoScaleMode = AutoScaleMode.Font;
////            //this.ClientSize = new Size(400, 350);
////            //this.Controls.Add(this.pictureBox1);
////            //this.Controls.Add(this.textBox1);
////            //this.Controls.Add(this.button1);
////            //this.Controls.Add(this.label2);
////            //this.Controls.Add(this.label1);
////            //this.Name = "Instrumental_Sound";
////            //this.Text = "Instrumental Sound Quiz";
////            //this.Load += new EventHandler(this.Instrumental_Sound_Load);
////            //((ISupportInitialize)(this.pictureBox1)).EndInit();
////            //this.ResumeLayout(false);
////            //this.PerformLayout();

////            this.label1 = new Label();
////            this.label2 = new Label();
////            this.button1 = new Button();
////            this.textBox1 = new TextBox();
////            this.pictureBox1 = new PictureBox();
////            ((ISupportInitialize)this.pictureBox1).BeginInit();
////            this.SuspendLayout();
////            this.label1.AutoSize = true;
////            this.label1.BackColor = Color.Transparent;
////            this.label1.Font = new Font("Stencil", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
////            this.label1.ForeColor = Color.White;
////            this.label1.Location = new Point(249, 26);
////            this.label1.Name = "label1";
////            this.label1.Size = new Size(658, 85);
////            this.label1.TabIndex = 0;
////            this.label1.Text = "GUESS THE SOUND";
////            this.label2.AutoSize = true;
////            this.label2.BackColor = Color.Transparent;
////            this.label2.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
////            this.label2.ForeColor = Color.White;
////            this.label2.Location = new Point(1121, 52);
////            this.label2.Name = "label2";
////            this.label2.Size = new Size(132, 48);
////            this.label2.TabIndex = 1;
////            this.label2.Text = "SCORE";
////            this.button1.BackColor = Color.Transparent;
////            this.button1.FlatStyle = FlatStyle.Flat;
////            this.button1.Font = new Font("Stencil", 20f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
////            this.button1.ForeColor = Color.White;
////            this.button1.Location = new Point(946, 741);
////            this.button1.Name = "button1";
////            this.button1.Size = new Size(132, 51);
////            this.button1.TabIndex = 2;
////            this.button1.Text = "NEXT";
////            this.button1.UseVisualStyleBackColor = false;
////            this.button1.Click += new EventHandler(this.button1_Click);
////            this.button1.MouseHover += new EventHandler(this.button1_MouseHover);
////            this.textBox1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
////            this.textBox1.ForeColor = Color.MediumVioletRed;
////            this.textBox1.Location = new Point(506, 741);
////            this.textBox1.Multiline = true;
////            this.textBox1.Name = "textBox1";
////            this.textBox1.Size = new Size(221, 51);
////            this.textBox1.TabIndex = 3;
////            this.pictureBox1.BackColor = Color.Transparent;
////            this.pictureBox1.Location = new Point(632, 176);
////            this.pictureBox1.Name = "pictureBox1";
////            this.pictureBox1.Size = new Size(500, 504);
////            this.pictureBox1.TabIndex = 4;
////            this.pictureBox1.TabStop = false;
////            this.AutoScaleDimensions = new SizeF(10f, 25f);
////            this.AutoScaleMode = AutoScaleMode.Font;
////            this.BackgroundImage = (Image)Resources.Instrument_Sound;
////            this.ClientSize = new Size(1342, 900);
////            this.Controls.Add((Control)this.pictureBox1);
////            this.Controls.Add((Control)this.textBox1);
////            this.Controls.Add((Control)this.button1);
////            this.Controls.Add((Control)this.label2);
////            this.Controls.Add((Control)this.label1);
////            this.Name = nameof(Instrumental_Sound);
////            this.Text = "GAME SCREEN";
////            this.Load += new EventHandler(this.Instrumental_Sound_Load);
////            ((ISupportInitialize)this.pictureBox1).EndInit();
////            this.ResumeLayout(false);
////            this.PerformLayout();
////        }

////        protected override void Dispose(bool disposing)
////        {
////            if (disposing && (components != null)) components.Dispose();
////            base.Dispose(disposing);
////        }
////    }
////}


//using System.Reflection.Emit;

//namespace Voice_Bridge
//{
//    partial class Instrumental_Sound
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            this.textBox1 = new System.Windows.Forms.TextBox();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.Transparent;
//            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.ForeColor = System.Drawing.Color.White;
//            this.label1.Location = new System.Drawing.Point(249, 26);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(658, 85);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "GUESS THE SOUND";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.BackColor = System.Drawing.Color.Transparent;
//            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.Color.White;
//            this.label2.Location = new System.Drawing.Point(1121, 52);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(132, 48);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "SCORE";
//            // 
//            // button1
//            // 
//            this.button1.BackColor = System.Drawing.Color.Transparent;
//            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button1.ForeColor = System.Drawing.Color.White;
//            this.button1.Location = new System.Drawing.Point(946, 741);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(132, 51);
//            this.button1.TabIndex = 2;
//            this.button1.Text = "NEXT";
//            this.button1.UseVisualStyleBackColor = false;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
//            // 
//            // textBox1
//            // 
//            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.textBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
//            this.textBox1.Location = new System.Drawing.Point(506, 741);
//            this.textBox1.Multiline = true;
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(221, 51);
//            this.textBox1.TabIndex = 3;
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
//            this.pictureBox1.Location = new System.Drawing.Point(632, 176);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(500, 504);
//            this.pictureBox1.TabIndex = 4;
//            this.pictureBox1.TabStop = false;
//            // 
//            // Instrumental_Sound
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = global::Voice_Bridge.Properties.Resources.Instrument_Sound;
//            this.ClientSize = new System.Drawing.Size(1342, 900);
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.textBox1);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Name = "Instrumental_Sound";
//            this.Text = "GAME SCREEN";
//            this.Load += new System.EventHandler(this.Instrumental_Sound_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.TextBox textBox1;
//        private System.Windows.Forms.PictureBox pictureBox1;
//    }
//}




//namespace Voice_Bridge
//{
//    partial class Instrumental_Sound
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.TextBox textBox1;
//        private System.Windows.Forms.PictureBox pictureBox1;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        /// <summary>
//        /// Required method for Designer support — do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            this.textBox1 = new System.Windows.Forms.TextBox();
      




//      this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();

//            // 
//            // label1
//            // 
//            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
//            this.label1.Location = new System.Drawing.Point(50, 30);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(300, 35);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Guess the sound";

//            // 
//            // label2
//            // 
//            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
//            this.label2.Location = new System.Drawing.Point(50, 70);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(200, 30);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "SCORE: 0";

//            // 
//            // button1
//            // 
//            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.button1.Location = new System.Drawing.Point(250, 300);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(100, 40);
//            this.button1.TabIndex = 2;
//            this.button1.Text = "Submit";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            this.button1.MouseEnter += new System.EventHandler(this.Button1_MouseEnter);

//            // 
//            // textBox1
//            // 
//            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
//            this.textBox1.Location = new System.Drawing.Point(50, 250);
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(300, 25);
//            this.textBox1.TabIndex = 3;
//            this.textBox1.MouseEnter += new System.EventHandler(this.TextBox1_MouseEnter);

//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Location = new System.Drawing.Point(50, 110);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(300, 120);
//            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox1.TabIndex = 4;
//            this.pictureBox1.TabStop = false;

//            // 
//            // Instrumental_Sound
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(420, 370);
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.textBox1);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Name = "Instrumental_Sound";
//            this.Text = "Instrumental Sound Quiz";
//            this.Load += new System.EventHandler(this.Instrumental_Sound_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }
//    }
//}
