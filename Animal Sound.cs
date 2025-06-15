// Decompiled with JetBrains decompiler
// Type: VoiceBridge.Main_Game
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
  public class Main_Game : Form
  {
    private int currentindex = 0;
    private int score = 0;
    private string username;
    private SoundPlayer textBox;
    private SoundPlayer button;
    private SoundPlayer henCorrect;
    private SoundPlayer sheepCorrect;
    private SoundPlayer lionCorrect;
    private SoundPlayer henIncorrect;
    private SoundPlayer sheepIncorrect;
    private SoundPlayer lionIncorrect;
    private SoundPlayer catIncorrect;
    private SoundPlayer catCorrect;
    private SoundPlayer dogIncorrect;
    private SoundPlayer dogCorrect;
    private SoundPlayer roosterCorrect;
    private SoundPlayer roosterIncorrect;
    private SoundPlayer parrotIncorrect;
    private SoundPlayer parrotCorrect;
    private SoundPlayer elephantIncorrect;
    private SoundPlayer elephantCorrect;
    private SoundPlayer mouseIncorrect;
    private SoundPlayer mouseCorrect;
    private SoundPlayer sparrowIncorrect;
    private SoundPlayer sparrowCorrect;
    private SoundPlayer pigeonIncorrect;
    private SoundPlayer pigeonCorrect;
    private SoundPlayer horseIncorrect;
    private SoundPlayer horseCorrect;
    private SoundPlayer goatIncorrect;
    private SoundPlayer goatCorrect;
    private SoundPlayer donkeyIncorrect;
    private SoundPlayer donkeyCorrect;
    private SoundPlayer crowIncorrect;
    private SoundPlayer crowCorrect;
    private List<int> questionOrder;
    private bool quizCompleted = false;
    private 
    #nullable disable
    IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private PictureBox pictureBox1;
    private TextBox textBox1;
    private Button button1;

    public Main_Game(
    #nullable enable
    string username)
    {
      this.InitializeComponent();
      this.SoundPlayers();
      this.HoverEvents();
      this.username = username;
      this.ActiveControl = (Control) this.textBox1;
      this.button1.Click += new EventHandler(this.button1_Click_1);
      this.henCorrect = new SoundPlayer((Stream) Resources.hencorrect);
      this.sheepCorrect = new SoundPlayer((Stream) Resources.sheepcorrect);
      this.lionCorrect = new SoundPlayer((Stream) Resources.lioncorrect);
      this.catCorrect = new SoundPlayer((Stream) Resources.catcorrect);
      this.dogCorrect = new SoundPlayer((Stream) Resources.dogcorrect);
      this.roosterCorrect = new SoundPlayer((Stream) Resources.roostercorrect);
      this.parrotCorrect = new SoundPlayer((Stream) Resources.parrotcorrect);
      this.elephantCorrect = new SoundPlayer((Stream) Resources.elephantcorrect);
      this.mouseCorrect = new SoundPlayer((Stream) Resources.mousecorrect);
      this.sparrowCorrect = new SoundPlayer((Stream) Resources.sparrowcorrect);
      this.pigeonCorrect = new SoundPlayer((Stream) Resources.pigeoncorrect);
      this.horseCorrect = new SoundPlayer((Stream) Resources.horsecorrect);
      this.goatCorrect = new SoundPlayer((Stream) Resources.goatcorrect);
      this.donkeyCorrect = new SoundPlayer((Stream) Resources.donkeycorrect);
      this.crowCorrect = new SoundPlayer((Stream) Resources.crowcorrect);
      this.henIncorrect = new SoundPlayer((Stream) Resources.henincorrect);
      this.sheepIncorrect = new SoundPlayer((Stream) Resources.sheepincorrect);
      this.lionIncorrect = new SoundPlayer((Stream) Resources.lionincorrect);
      this.catIncorrect = new SoundPlayer((Stream) Resources.catincorrect);
      this.dogIncorrect = new SoundPlayer((Stream) Resources.dogincorrect);
      this.roosterIncorrect = new SoundPlayer((Stream) Resources.roosterincorrect);
      this.parrotIncorrect = new SoundPlayer((Stream) Resources.parrotincorrect);
      this.elephantIncorrect = new SoundPlayer((Stream) Resources.elephantincorrect);
      this.mouseIncorrect = new SoundPlayer((Stream) Resources.mouseincorrect);
      this.sparrowIncorrect = new SoundPlayer((Stream) Resources.sparrowincorrect);
      this.pigeonIncorrect = new SoundPlayer((Stream) Resources.pigeonincorrect);
      this.horseIncorrect = new SoundPlayer((Stream) Resources.horseincorrect);
      this.goatIncorrect = new SoundPlayer((Stream) Resources.goatincorrect);
      this.donkeyIncorrect = new SoundPlayer((Stream) Resources.donkeyincorrect);
      this.crowIncorrect = new SoundPlayer((Stream) Resources.crowincorrect);
      this.questionOrder = new List<int>()
      {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        15
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

    private void Form1_Load(object sender, EventArgs e) => this.questions(this.currentindex);

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
            soundPlayer = new SoundPlayer((Stream) Resources.hensound);
            this.label1.Text = "Guess the sound";
            break;
          case 2:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.sheepsound);
            this.label1.Text = "Guess the sound";
            break;
          case 3:
            this.pictureBox1.Image = (Image) Resources.listen3;
            soundPlayer = new SoundPlayer((Stream) Resources.lionsound);
            this.label1.Text = "Guess the sound";
            break;
          case 4:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.catsound);
            this.label1.Text = "Guess the sound";
            break;
          case 5:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.dogsound);
            this.label1.Text = "Guess the sound";
            break;
          case 6:
            this.pictureBox1.Image = (Image) Resources.listen1;
            soundPlayer = new SoundPlayer((Stream) Resources.roostersound);
            this.label1.Text = "Guess the sound";
            break;
          case 7:
            this.pictureBox1.Image = (Image) Resources.listen3;
            soundPlayer = new SoundPlayer((Stream) Resources.parrotsound);
            this.label1.Text = "Guess the sound";
            break;
          case 8:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.elephantsound);
            this.label1.Text = "Guess the sound";
            break;
          case 9:
            this.pictureBox1.Image = (Image) Resources.listen3;
            soundPlayer = new SoundPlayer((Stream) Resources.mousesound);
            this.label1.Text = "Guess the sound";
            break;
          case 10:
            this.pictureBox1.Image = (Image) Resources.listen2;
            soundPlayer = new SoundPlayer((Stream) Resources.sparrowsound);
            this.label1.Text = "Guess the sound";
            break;
          case 11:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.pigeonsound);
            this.label1.Text = "Guess the sound";
            break;
          case 12:
            this.pictureBox1.Image = (Image) Resources.listen3;
            soundPlayer = new SoundPlayer((Stream) Resources.horsesound);
            this.label1.Text = "Guess the sound";
            break;
          case 13:
            this.pictureBox1.Image = (Image) Resources.listen1;
            soundPlayer = new SoundPlayer((Stream) Resources.goatsound);
            this.label1.Text = "Guess the sound";
            break;
          case 14:
            this.pictureBox1.Image = (Image) Resources.l2;
            soundPlayer = new SoundPlayer((Stream) Resources.donkeysound);
            this.label1.Text = "Guess the sound";
            break;
          case 15:
            this.pictureBox1.Image = (Image) Resources.listen3;
            soundPlayer = new SoundPlayer((Stream) Resources.crowsound);
            this.label1.Text = "Guess the sound";
            break;
        }
        soundPlayer?.PlayLooping();
      }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      bool flag = false;
      switch (this.questionOrder[this.currentindex])
      {
        case 1:
          if (this.textBox1.Text.ToLower() == "hen")
          {
            this.pictureBox1.Image = (Image) Resources.hen;
            this.henCorrect.Play();
            ++this.score;
            this.label1.Text = "Correct Answer";
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.henIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.hen;
          break;
        case 2:
          if (this.textBox1.Text.ToLower() == "sheep")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.sheepCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.sheep;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.sheepIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.sheep;
          break;
        case 3:
          if (this.textBox1.Text.ToLower() == "lion")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.lionCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.lion;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.lionIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.lion;
          break;
        case 4:
          if (this.textBox1.Text.ToLower() == "cat")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.catCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.cat;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.catIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.cat;
          break;
        case 5:
          if (this.textBox1.Text.ToLower() == "dog")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.dogCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.dog;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.dogIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.dog;
          break;
        case 6:
          if (this.textBox1.Text.ToLower() == "rooster")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.roosterCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.rooster;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.roosterIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.rooster;
          break;
        case 7:
          if (this.textBox1.Text.ToLower() == "parrot")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.parrotCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.parrot;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.parrotIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.parrot;
          break;
        case 8:
          if (this.textBox1.Text.ToLower() == "elephant")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.elephantCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.elephant;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.elephantIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.elephant;
          break;
        case 9:
          if (this.textBox1.Text.ToLower() == "mouse")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.mouseCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.mouse;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.mouseIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.mouse;
          break;
        case 10:
          if (this.textBox1.Text.ToLower() == "sparrow")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.sparrowCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.sparrow;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.sparrowIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.sparrow;
          break;
        case 11:
          if (this.textBox1.Text.ToLower() == "pigeon")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.pigeonCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.pigeon;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.pigeonIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.pigeon;
          break;
        case 12:
          if (this.textBox1.Text.ToLower() == "horse")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.horseCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.horse;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.horseIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.horse;
          break;
        case 13:
          if (this.textBox1.Text.ToLower() == "goat")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.goatCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.goat;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.goatIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.goat;
          break;
        case 14:
          if (this.textBox1.Text.ToLower() == "donkey")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.donkeyCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.donkey;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.donkeyIncorrect.Play();
          break;
        case 15:
          if (this.textBox1.Text.ToLower() == "crow")
          {
            ++this.score;
            this.label1.Text = "Correct Answer";
            this.crowCorrect.Play();
            this.pictureBox1.Image = (Image) Resources.crow;
            flag = true;
            break;
          }
          this.label1.Text = "Incorrect Answer";
          this.crowIncorrect.Play();
          this.pictureBox1.Image = (Image) Resources.crow;
          break;
      }
          this.label2.Text = "SCORE: " + this.score.ToString();
          this.textBox1.Clear();
            //Timer timer = new Timer();
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
      string cmdText = "INSERT INTO score (username, animalscore) VALUES (@username, @animalscore)";
      using (OleDbConnection connection = new OleDbConnection(connectionString))
      {
        using (OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection))
        {
          oleDbCommand.Parameters.Add(new OleDbParameter("@username", OleDbType.VarChar)).Value = (object) username;
          oleDbCommand.Parameters.Add(new OleDbParameter("@animalscore", OleDbType.Integer)).Value = (object) score;
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
      this.pictureBox1 = new PictureBox();
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.Transparent;
      this.label1.Font = new Font("Stencil", 36f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DarkOliveGreen;
      this.label1.Location = new Point(241, -3);
      this.label1.Name = "label1";
      this.label1.Size = new Size(658, 85);
      this.label1.TabIndex = 0;
      this.label1.Text = "GUESS THE SOUND";
      this.label2.AutoSize = true;
      this.label2.BackColor = Color.Transparent;
      this.label2.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.DarkOliveGreen;
      this.label2.Location = new Point(1103, 49);
      this.label2.Name = "label2";
      this.label2.Size = new Size(132, 48);
      this.label2.TabIndex = 1;
      this.label2.Text = "SCORE";
      this.pictureBox1.BackColor = Color.Transparent;
      this.pictureBox1.Image = (Image) Resources.listen1;
      this.pictureBox1.Location = new Point(700, 158);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(654, 558);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.textBox1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox1.ForeColor = Color.DarkOliveGreen;
      this.textBox1.Location = new Point(600, 737);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(231, 55);
      this.textBox1.TabIndex = 3;
      this.textBox1.TextAlign = HorizontalAlignment.Center;
      this.button1.BackColor = Color.Transparent;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Stencil", 20f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = Color.DarkOliveGreen;
      this.button1.Location = new Point(1025, 737);
      this.button1.Name = "button1";
      this.button1.Size = new Size(168, 55);
      this.button1.TabIndex = 4;
      this.button1.Text = "NEXT";
      this.button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(10f, 25f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) Resources.Animal_Sound;
      this.ClientSize = new Size(1333, 843);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.MdiChildrenMinimizedAnchorBottom = false;
      this.Name = nameof (Main_Game);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "GAME SCREEN";
      this.Load += new EventHandler(this.Form1_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
