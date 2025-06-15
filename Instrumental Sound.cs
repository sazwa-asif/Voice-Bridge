// Decompiled with JetBrains decompiler
// Type: VoiceBridge.Instrumental_Sound
// Assembly: VoiceBridge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B48CF90A-0D4F-414B-A8ED-A72C65DDB9AB
// Assembly location: C:\Users\Dell\source\repos\VoiceBridge\bin\Debug\net8.0-windows\VoiceBridge.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


#nullable enable
namespace Voice_Bridge
{
  public partial class Instrumental_Sound : Form
  {
    private int currentindex = 0;
    private int score = 0;
    private string username;
    private SoundPlayer textBox;
    private SoundPlayer button;
    private SoundPlayer guitarCorrect;
    private SoundPlayer drumCorrect;
    private SoundPlayer pianoCorrect;
    private SoundPlayer trumpetCorrect;
    private SoundPlayer violinCorrect;
    private SoundPlayer fluteCorrect;
    private SoundPlayer guitarIncorrect;
    private SoundPlayer drumIncorrect;
    private SoundPlayer pianoIncorrect;
    private SoundPlayer trumpetIncorrect;
    private SoundPlayer violinIncorrect;
    private SoundPlayer fluteIncorrect;
    private List<int> questionOrder;
    private bool quizCompleted = false;
        private
#nullable disable
        IContainer components = (IContainer)null;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;

        public Instrumental_Sound(
    #nullable enable
    string username)
    {
      this.InitializeComponent();
      this.SoundPlayers();
      this.HoverEvents();
      this.username = username;
      this.guitarCorrect = new SoundPlayer((Stream) Resources.guitarcorrect);
      this.drumCorrect = new SoundPlayer((Stream) Resources.drumcorrect);
      this.trumpetCorrect = new SoundPlayer((Stream) Resources.trumpetcorrect);
      this.violinCorrect = new SoundPlayer((Stream) Resources.violincorrect);
      this.fluteCorrect = new SoundPlayer((Stream) Resources.flutecorrect);
      this.pianoCorrect = new SoundPlayer((Stream) Resources.pianocorrect);
      this.guitarIncorrect = new SoundPlayer((Stream) Resources.guitarincorrect);
      this.drumIncorrect = new SoundPlayer((Stream) Resources.drumincorrect);
      this.trumpetIncorrect = new SoundPlayer((Stream) Resources.trumpetincorrect);
      this.violinIncorrect = new SoundPlayer((Stream) Resources.violinincorrect);
      this.fluteIncorrect = new SoundPlayer((Stream) Resources.fluteincorrect);
      this.pianoIncorrect = new SoundPlayer((Stream) Resources.pianoincorrect);
      this.questionOrder = new List<int>()
      {
        1,
        2,
        3,
        4,
        5,
        6
      };
      this.Shuffle();
    }

    private void SoundPlayers()
    {
      this.textBox = new SoundPlayer((Stream) Resources.buttonhoover);
      this.button = new SoundPlayer((Stream) Resources.textboxhoover);
    }

    private void HoverEvents()
    {
      this.textBox1.MouseEnter += new EventHandler(this.TextBox1_MouseEnter);
      this.button1.MouseEnter += new EventHandler(this.Button1_MouseEnter);
    }

    private void TextBox1_MouseEnter(object sender, EventArgs e) => this.textBox.Play();

    private void Button1_MouseEnter(object sender, EventArgs e) => this.button.Play();

    private void Instrumental_Sound_Load(object sender, EventArgs e)
    {
      this.questions(this.currentindex);
    }

    private void Shuffle()
    {
      Random random = new Random();
      int count = this.questionOrder.Count;
      while (count > 1)
      {
        --count;
        int index = random.Next(count + 1);
        int num = this.questionOrder[index];
        this.questionOrder[index] = this.questionOrder[count];
        this.questionOrder[count] = num;
      }
    }

    private void questions(int questionIndex)
    {
      if (questionIndex >= this.questionOrder.Count)
      {
        this.quizCompleted = true;
      }
      else
      {
        int num = this.questionOrder[questionIndex];
        SoundPlayer soundPlayer = (SoundPlayer) null;
        this.textBox1.Clear();
        switch (num)
        {
          case 1:
            this.pictureBox1.Image = (Image) Resources.listen1;
            soundPlayer = new SoundPlayer((Stream) Resources.guitarsound);
            this.label1.Text = "Guess the sound";
            break;
          case 2:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.pianosound);
            this.label1.Text = "Guess the sound";
            break;
          case 3:
            this.pictureBox1.Image = (Image) Resources.listen3;
            soundPlayer = new SoundPlayer((Stream) Resources.drumsound);
            this.label1.Text = "Guess the sound";
            break;
          case 4:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.trumpetsound);
            this.label1.Text = "Guess the sound";
            break;
          case 5:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.flutesound);
            this.label1.Text = "Guess the sound";
            break;
          case 6:
            this.pictureBox1.Image = (Image) Resources.listen1;
            soundPlayer = new SoundPlayer((Stream) Resources.violinsound);
            this.label1.Text = "Guess the sound";
            break;
        }
        soundPlayer?.PlayLooping();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      bool flag = false;
      switch (this.questionOrder[this.currentindex])
      {
        case 1:
          if (this.textBox1.Text.ToLower() == "guitar")
          {
            this.pictureBox1.Image = (Image) Resources.guitar;
            this.guitarCorrect.Play();
            ++this.score;
            this.label1.Text = "Correct Answer";
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.guitarIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.guitar;
          break;
        case 2:
          if (this.textBox1.Text.ToLower() == "piano")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.pianoCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.piano;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.pianoIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.piano;
          break;
        case 3:
          if (this.textBox1.Text.ToLower() == "drum")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.drumCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.drum;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.drumIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.drum;
          break;
        case 4:
          if (this.textBox1.Text.ToLower() == "trumpet")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.trumpetCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.trumpet;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.trumpetIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.trumpet;
          break;
        case 5:
          if (this.textBox1.Text.ToLower() == "flute")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.fluteCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.flute;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.fluteIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.flute;
          break;
        case 6:
          if (this.textBox1.Text.ToLower() == "violin")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.violinCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.violin;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.violinIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.violin;
          break;
      }
      this.label2.Text = "SCORE: " + this.score.ToString();
      this.textBox1.Clear();
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      timer.Interval = 5000;
      timer.Tick += (EventHandler) ((s, args) =>
      {
        ++this.currentindex;
        this.questions(this.currentindex);
        if (!this.quizCompleted)
        {
          this.textBox1.Visible = true;
          this.button1.Visible = true;
          this.textBox1.Enabled = true;
          this.button1.Enabled = true;
        }
        timer.Stop();
        if (!this.quizCompleted)
          return;
        this.SaveScoreToDatabase(Login.LoggedInUsername, this.score);
        new Score_Card(this.username, this.score).Show();
        this.Hide();
      });
      timer.Start();
      this.textBox1.Visible = false;
      this.button1.Visible = false;
      this.textBox1.Enabled = false;
      this.button1.Enabled = false;
    }

    private void SaveScoreToDatabase(string username, int score)
    {
      string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Dell\\Documents\\logindata.accdb";
      string cmdText = "INSERT INTO score (username, instrumentscore) VALUES (@username, @instrumentscore)";
      using (OleDbConnection connection = new OleDbConnection(connectionString))
      {
        using (OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection))
        {
          oleDbCommand.Parameters.Add(new OleDbParameter("@username", OleDbType.VarChar)).Value = (object) username;
          oleDbCommand.Parameters.Add(new OleDbParameter("@instrumentscore", OleDbType.Integer)).Value = (object) score;
          try
          {
            connection.Open();
            oleDbCommand.ExecuteNonQuery();
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show("Error saving score: " + ex.Message);
          }
        }
      }
    }

    private void button1_MouseHover(object sender, EventArgs e)
    {
    }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("Stencil", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new Size(658, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUESS THE SOUND";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(1121, 52);
            this.label2.Name = "label2";
            this.label2.Size = new Size(132, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            this.button1.BackColor = Color.Transparent;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Stencil", 20f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(946, 741);
            this.button1.Name = "button1";
            this.button1.Size = new Size(132, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button1.MouseHover += new EventHandler(this.button1_MouseHover);
            this.textBox1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.textBox1.ForeColor = Color.MediumVioletRed;
            this.textBox1.Location = new Point(506, 741);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(221, 51);
            this.textBox1.TabIndex = 3;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Location = new Point(632, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(500, 504);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(10f, 25f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = (Image)Resources.Instrument_Sound;
            this.ClientSize = new Size(1342, 900);
            this.Controls.Add((Control)this.pictureBox1);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Name = nameof(Instrumental_Sound);
            this.Text = "GAME SCREEN";
            this.Load += new EventHandler(this.Instrumental_Sound_Load);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
