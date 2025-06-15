// Decompiled with JetBrains decompiler
// Type: VoiceBridge.Login
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
  public partial class Login : Form
  {
    private OleDbConnection conn = new OleDbConnection();
    private SoundPlayer textBoxHoverSoundPlayer;
    private SoundPlayer textBox1HoverSoundPlayer;
    private SoundPlayer buttonHoverSoundPlayer;
    private SoundPlayer introSoundPlayer;
    private SoundPlayer labelSoundPlayer;
    //private 
    #nullable disable
    //IContainer components = (IContainer) null;
    //private TextBox textBox1;
    //private Label label1;
    //private Label label2;
    //private TextBox textBox2;
    //private Label label3;
    //private Button button1;
    //private Label label4;
    //private Label label5;

    public static 
    #nullable enable
    string LoggedInUsername { get; private set; }

    public Login()
    {
      this.InitializeComponent();
      this.InitializeSoundPlayers();
      this.SetupHoverEvents();
      this.introSoundPlayer = new SoundPlayer((Stream) Resources.intro);
      this.introSoundPlayer.PlayLooping();
      this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\logindata.accdb;Persist Security Info=False;";
    }

    private void InitializeSoundPlayers()
    {
      this.textBoxHoverSoundPlayer = new SoundPlayer((Stream) Resources.usernamehoover);
      this.textBox1HoverSoundPlayer = new SoundPlayer((Stream) Resources.passwordhoover);
      this.buttonHoverSoundPlayer = new SoundPlayer((Stream) Resources.playhoover);
      this.labelSoundPlayer = new SoundPlayer((Stream) Resources.registerhoover);
    }

    private void SetupHoverEvents()
    {
      this.textBox1.MouseHover += new EventHandler(this.TextBox1_MouseHover);
      this.button1.MouseHover += new EventHandler(this.Button1_MouseHover);
    }

    private void TextBox1_MouseHover(object sender, EventArgs e)
    {
      this.textBoxHoverSoundPlayer.Play();
    }

    private void Button1_MouseHover(object sender, EventArgs e)
    {
      this.buttonHoverSoundPlayer.Play();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string username = this.textBox1.Text.Trim();
      string str = this.textBox2.Text.Trim();
      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(str))
      {
        int num1 = (int) MessageBox.Show("Please enter both username and password.");
      }
      else
      {
        this.conn.Open();
        OleDbCommand oleDbCommand = new OleDbCommand();
        oleDbCommand.Connection = this.conn;
        oleDbCommand.CommandText = "select * from account where username = '" + this.textBox1.Text + "' and password ='" + this.textBox2.Text + "'";
        OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
        int num2 = 0;
        while (oleDbDataReader.Read())
          ++num2;
        if (num2 == 1)
        {
          int num3 = (int) MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          Login.LoggedInUsername = username;
          new Main_Menu(username).Show();
          this.Hide();
        }
        else
        {
          int num4 = (int) MessageBox.Show("Username and Password does not exist! Please Register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          new SignUp().Show();
          this.Hide();
        }
      }
    }

    private void label5_Click(object sender, EventArgs e)
    {
      new SignUp().Show();
      this.Hide();
    }

    private void textBox2_MouseHover(object sender, EventArgs e)
    {
      this.textBox1HoverSoundPlayer.Play();
    }

    private void label5_MouseHover(object sender, EventArgs e) => this.labelSoundPlayer.Play();

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.button1.PerformClick();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.textBox2.Focus();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    //private void InitializeComponent()
    //{
    //  this.textBox1 = new TextBox();
    //  this.label1 = new Label();
    //  this.label2 = new Label();
    //  this.textBox2 = new TextBox();
    //  this.label3 = new Label();
    //  this.button1 = new Button();
    //  this.label4 = new Label();
    //  this.label5 = new Label();
    //  this.SuspendLayout();
    //  this.textBox1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.textBox1.ForeColor = Color.Teal;
    //  this.textBox1.Location = new Point(927, 582);
    //  this.textBox1.Multiline = true;
    //  this.textBox1.Name = "textBox1";
    //  this.textBox1.Size = new Size(271, 46);
    //  this.textBox1.TabIndex = 0;
    //  this.textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
    //  this.label1.AutoSize = true;
    //  this.label1.BackColor = Color.Transparent;
    //  this.label1.Font = new Font("Stencil", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.label1.ForeColor = Color.Teal;
    //  this.label1.Location = new Point(713, 436);
    //  this.label1.Name = "label1";
    //  this.label1.Size = new Size(540, 85);
    //  this.label1.TabIndex = 1;
    //  this.label1.Text = "LOGIN TO PLAY";
    //  this.label2.AutoSize = true;
    //  this.label2.BackColor = Color.Transparent;
    //  this.label2.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.label2.ForeColor = Color.Teal;
    //  this.label2.Location = new Point(723, 582);
    //  this.label2.Name = "label2";
    //  this.label2.Size = new Size(183, 38);
    //  this.label2.TabIndex = 2;
    //  this.label2.Text = "USERNAME";
    //  this.textBox2.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.textBox2.ForeColor = Color.Teal;
    //  this.textBox2.Location = new Point(927, 656);
    //  this.textBox2.Multiline = true;
    //  this.textBox2.Name = "textBox2";
    //  this.textBox2.Size = new Size(271, 46);
    //  this.textBox2.TabIndex = 4;
    //  this.textBox2.KeyDown += new KeyEventHandler(this.textBox2_KeyDown);
    //  this.textBox2.MouseHover += new EventHandler(this.textBox2_MouseHover);
    //  this.label3.AutoSize = true;
    //  this.label3.BackColor = Color.Transparent;
    //  this.label3.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.label3.ForeColor = Color.Teal;
    //  this.label3.Location = new Point(724, 656);
    //  this.label3.Name = "label3";
    //  this.label3.Size = new Size(182, 38);
    //  this.label3.TabIndex = 6;
    //  this.label3.Text = "PASSWORD";
    //  this.button1.BackColor = Color.Transparent;
    //  this.button1.Cursor = Cursors.Hand;
    //  this.button1.FlatStyle = FlatStyle.Flat;
    //  this.button1.Font = new Font("Stencil", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.button1.ForeColor = Color.DarkSlateBlue;
    //  this.button1.Location = new Point(848, 757);
    //  this.button1.Name = "button1";
    //  this.button1.Size = new Size(266, 58);
    //  this.button1.TabIndex = 8;
    //  this.button1.Text = "CLICK TO PLAY";
    //  this.button1.UseVisualStyleBackColor = false;
    //  this.button1.Click += new EventHandler(this.button1_Click);
    //  this.label4.AutoSize = true;
    //  this.label4.BackColor = Color.Transparent;
    //  this.label4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.label4.ForeColor = Color.Teal;
    //  this.label4.Location = new Point(792, 840);
    //  this.label4.Name = "label4";
    //  this.label4.Size = new Size(203, 25);
    //  this.label4.TabIndex = 9;
    //  this.label4.Text = "Don't have an account?";
    //  this.label5.AutoSize = true;
    //  this.label5.BackColor = Color.Transparent;
    //  this.label5.Cursor = Cursors.Hand;
    //  this.label5.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.label5.ForeColor = Color.Teal;
    //  this.label5.Location = new Point(1001, 840);
    //  this.label5.Name = "label5";
    //  this.label5.Size = new Size(128, 25);
    //  this.label5.TabIndex = 10;
    //  this.label5.Text = "Register Here";
    //  this.label5.Click += new EventHandler(this.label5_Click);
    //  this.label5.MouseHover += new EventHandler(this.label5_MouseHover);
    //  this.AutoScaleDimensions = new SizeF(10f, 25f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.BackgroundImage = (Image) Resources.Login_Page;
    //  this.ClientSize = new Size(1898, 1024);
    //  this.Controls.Add((Control) this.label5);
    //  this.Controls.Add((Control) this.label4);
    //  this.Controls.Add((Control) this.button1);
    //  this.Controls.Add((Control) this.label3);
    //  this.Controls.Add((Control) this.textBox2);
    //  this.Controls.Add((Control) this.label2);
    //  this.Controls.Add((Control) this.label1);
    //  this.Controls.Add((Control) this.textBox1);
    //  this.FormBorderStyle = FormBorderStyle.FixedSingle;
    //  this.Name = nameof (Login);
    //  this.Text = "LOGIN";
    //  this.ResumeLayout(false);
    //  this.PerformLayout();
    //}
  }
}
