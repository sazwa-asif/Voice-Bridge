// Decompiled with JetBrains decompiler
// Type: VoiceBridge.SignUp
// Assembly: VoiceBridge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B48CF90A-0D4F-414B-A8ED-A72C65DDB9AB
// Assembly location: C:\Users\Dell\source\repos\VoiceBridge\bin\Debug\net8.0-windows\VoiceBridge.dll

using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


#nullable enable
namespace Voice_Bridge
{
  public partial class SignUp : Form
  {
    private OleDbConnection conn = new OleDbConnection();
    private SoundPlayer textBoxHoverSoundPlayer;
    private SoundPlayer textBox1HoverSoundPlayer;
    private SoundPlayer buttonHoverSoundPlayer;
    //private 
    #nullable disable
    //IContainer components = (IContainer) null;
    //private Label label1;
    //private Label label2;
    //private Label label3;
    //private TextBox textBox1;
    //private TextBox textBox2;
    //private Button button1;

    public SignUp()
    {
      this.InitializeComponent();
      this.InitializeSoundPlayers();
      this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\logindata.accdb;\r\nPersist Security Info=False;";
    }

    private void InitializeSoundPlayers()
    {
      this.textBoxHoverSoundPlayer = new SoundPlayer((Stream) Resources.usernamehoover);
      this.textBox1HoverSoundPlayer = new SoundPlayer((Stream) Resources.passwordhoover);
      this.buttonHoverSoundPlayer = new SoundPlayer((Stream) Resources.signuphoover);
    }

    private void button1_Click(
    #nullable enable
    object sender, EventArgs e)
    {
      string str1 = this.textBox1.Text.Trim();
      string str2 = this.textBox2.Text.Trim();
      if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
      {
        int num1 = (int) MessageBox.Show("Please enter both username and password.");
      }
      else
      {
        try
        {
          this.conn.Open();
          using (OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO account ([username], [password]) VALUES (?, ?)", this.conn))
          {
            oleDbCommand.Parameters.AddWithValue("@username", (object) this.textBox1.Text);
            oleDbCommand.Parameters.AddWithValue("@password", (object) this.textBox2.Text);
            oleDbCommand.ExecuteNonQuery();
          }
          int num2 = (int) MessageBox.Show("One record has been inserted");
        }
        catch (Exception ex)
        {
          int num3 = (int) MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
          this.conn.Close();
        }
        new Login().Show();
        this.Hide();
      }
    }

    private void textBox1_MouseHover(object sender, EventArgs e)
    {
      this.textBoxHoverSoundPlayer.Play();
    }

    private void textBox2_MouseHover(object sender, EventArgs e)
    {
      this.textBox1HoverSoundPlayer.Play();
    }

    private void button1_MouseHover(object sender, EventArgs e)
    {
      this.buttonHoverSoundPlayer.Play();
    }

    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.label1 = new Label();
    //  this.label2 = new Label();
    //  this.label3 = new Label();
    //  this.textBox1 = new TextBox();
    //  this.textBox2 = new TextBox();
    //  this.button1 = new Button();
    //  this.SuspendLayout();
    //  this.label1.AutoSize = true;
    //  this.label1.BackColor = Color.Transparent;
    //  this.label1.Font = new Font("Stencil", 26f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.label1.ForeColor = Color.DarkSlateBlue;
    //  this.label1.Location = new Point(167, 77);
    //  this.label1.Name = "label1";
    //  this.label1.Size = new Size(376, 61);
    //  this.label1.TabIndex = 0;
    //  this.label1.Text = "GET STARTED!";
    //  this.label2.AutoSize = true;
    //  this.label2.BackColor = Color.Transparent;
    //  this.label2.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.label2.ForeColor = Color.Teal;
    //  this.label2.Location = new Point(117, 272);
    //  this.label2.Name = "label2";
    //  this.label2.Size = new Size(183, 38);
    //  this.label2.TabIndex = 1;
    //  this.label2.Text = "USERNAME";
    //  this.label3.AutoSize = true;
    //  this.label3.BackColor = Color.Transparent;
    //  this.label3.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.label3.ForeColor = Color.Teal;
    //  this.label3.Location = new Point(117, 379);
    //  this.label3.Name = "label3";
    //  this.label3.Size = new Size(182, 38);
    //  this.label3.TabIndex = 2;
    //  this.label3.Text = "PASSWORD";
    //  this.textBox1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.textBox1.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
    //  this.textBox1.Location = new Point(329, 263);
    //  this.textBox1.Multiline = true;
    //  this.textBox1.Name = "textBox1";
    //  this.textBox1.Size = new Size(254, 47);
    //  this.textBox1.TabIndex = 3;
    //  this.textBox1.MouseHover += new EventHandler(this.textBox1_MouseHover);
    //  this.textBox2.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.textBox2.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
    //  this.textBox2.Location = new Point(329, 363);
    //  this.textBox2.Multiline = true;
    //  this.textBox2.Name = "textBox2";
    //  this.textBox2.Size = new Size(254, 54);
    //  this.textBox2.TabIndex = 4;
    //  this.textBox2.MouseHover += new EventHandler(this.textBox2_MouseHover);
    //  this.button1.BackColor = Color.Transparent;
    //  this.button1.FlatStyle = FlatStyle.Flat;
    //  this.button1.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.button1.ForeColor = Color.DarkSlateBlue;
    //  this.button1.Location = new Point(246, 495);
    //  this.button1.Name = "button1";
    //  this.button1.Size = new Size(186, 63);
    //  this.button1.TabIndex = 8;
    //  this.button1.Text = "SIGN UP";
    //  this.button1.UseVisualStyleBackColor = false;
    //  this.button1.Click += new EventHandler(this.button1_Click);
    //  this.button1.MouseHover += new EventHandler(this.button1_MouseHover);
    //  this.AutoScaleDimensions = new SizeF(10f, 25f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.BackgroundImage = (Image) Resources.Signup_Page;
    //  this.ClientSize = new Size(680, 664);
    //  this.Controls.Add((Control) this.button1);
    //  this.Controls.Add((Control) this.textBox2);
    //  this.Controls.Add((Control) this.textBox1);
    //  this.Controls.Add((Control) this.label3);
    //  this.Controls.Add((Control) this.label2);
    //  this.Controls.Add((Control) this.label1);
    //  this.Name = nameof (SignUp);
    //  this.StartPosition = FormStartPosition.CenterScreen;
    //  this.Text = "SIGNUP";
    //  this.ResumeLayout(false);
    //  this.PerformLayout();
    //}
  }
}
