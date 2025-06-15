using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Bridge
{
    public partial class Transport_Sound : Form
    {

        private int currentindex = 0;
        private int score = 0;
        private string username;


        private SoundPlayer textBox;
        private SoundPlayer button;
        private SoundPlayer carCorrect;
        private SoundPlayer aeroplaneCorrect;
        private SoundPlayer helicopterCorrect;
        private SoundPlayer policeCorrect;
        private SoundPlayer ambulanceCorrect;
        private SoundPlayer bicycleCorrect;
        private SoundPlayer trainCorrect;

        private SoundPlayer carIncorrect;
        private SoundPlayer aeroplaneIncorrect;
        private SoundPlayer helicopterIncorrect;
        private SoundPlayer policeIncorrect;
        private SoundPlayer ambulanceIncorrect;
        private SoundPlayer bicycleIncorrect;
        private SoundPlayer trainIncorrect;

        private List<int> questionOrder;
        private bool quizCompleted = false;

        public Transport_Sound(string username)
        {
            InitializeComponent();
            SoundPlayers();
            HoverEvents();
            this.username = username;

            carCorrect = new SoundPlayer(Resources.carcorrect);
            aeroplaneCorrect = new SoundPlayer(Resources.aeroplanecorrect);
            helicopterCorrect = new SoundPlayer(Resources.helicoptercorrect);
            policeCorrect = new SoundPlayer(Resources.policecorrect);
            ambulanceCorrect = new SoundPlayer(Resources.ambulancecorrect);
            bicycleCorrect = new SoundPlayer(Resources.bicyclecorrect);
            trainCorrect = new SoundPlayer(Resources.traincorrect);



            carIncorrect = new SoundPlayer(Resources.carincorrect);
            aeroplaneIncorrect = new SoundPlayer(Resources.aeroplaneincorrect);
            helicopterIncorrect = new SoundPlayer(Resources.helicopterincorrect);
            policeIncorrect = new SoundPlayer(Resources.policeincorrect);
            ambulanceIncorrect = new SoundPlayer(Resources.ambulanceincorrect);
            bicycleIncorrect = new SoundPlayer(Resources.bicycleincorrect);
            trainIncorrect = new SoundPlayer(Resources.trainincorrect);

            questionOrder = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Shuffle();

        }

        private void SoundPlayers()
        {
            textBox = new SoundPlayer(Resources.buttonhoover);
            button = new SoundPlayer(Resources.textboxhoover);
        }

        private void HoverEvents()
        {
            textBox1.MouseEnter += textBox1_MouseEnter;
            button1.MouseEnter += button1_MouseEnter;
        }

        private void Transport_Sound_Load(object sender, EventArgs e)
        {
            questions(currentindex);
        }


        private void Shuffle()
        {
            Random rng = new Random();
            int n = questionOrder.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = questionOrder[k];
                questionOrder[k] = questionOrder[n];
                questionOrder[n] = value;
            }
        }


        private void questions(int questionIndex)
        {
            if (questionIndex >= questionOrder.Count)
            {
                quizCompleted = true;
                return;
            }

            int questionNumber = questionOrder[questionIndex];
            SoundPlayer ss = null;
            textBox1.Clear();

            switch (questionNumber)
            {
                case 1:
                    pictureBox1.Image = Resources.listen1;
                    ss = new SoundPlayer(Resources.carsound);
                    label1.Text = "Guess the sound";
                    break;

                case 2:
                    pictureBox1.Image = Resources.l2;
                    ss = new SoundPlayer(Resources.aeroplanesound);
                    label1.Text = "Guess the sound";
                    break;

                case 3:
                    pictureBox1.Image = Resources.listen3;
                    ss = new SoundPlayer(Resources.helicoptersound);
                    label1.Text = "Guess the sound";
                    break;

                case 4:
                    pictureBox1.Image = Resources.l2;
                    ss = new SoundPlayer(Resources.policesound);
                    label1.Text = "Guess the sound";
                    break;

                case 5:
                    pictureBox1.Image = Resources.l2;
                    ss = new SoundPlayer(Resources.ambulancesound);
                    label1.Text = "Guess the sound";
                    break;

                case 6:
                    pictureBox1.Image = Resources.listen1;
                    ss = new SoundPlayer(Resources.bicyclesound);
                    label1.Text = "Guess the sound";
                    break;

                case 7:
                    pictureBox1.Image = Resources.listen1;
                    ss = new SoundPlayer(Resources.trainsound);
                    label1.Text = "Guess the sound";
                    break;
            }
            ss?.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isCorrect = false;
            int questionNumber = questionOrder[currentindex];

            switch (questionNumber)
            {
                case 1:
                    if (textBox1.Text.ToLower() == "car")
                    {
                        pictureBox1.Image = Resources.car;
                        carCorrect.Play();
                        score++;
                        label1.Text = "Correct Answer";
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        carIncorrect.Play();
                        pictureBox1.Image = Resources.car;
                    }
                    break;

                case 2:
                    if (textBox1.Text.ToLower() == "aeroplane")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        aeroplaneCorrect.Play();
                        pictureBox1.Image = Resources.aeroplane;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        aeroplaneIncorrect.Play();
                        pictureBox1.Image = Resources.aeroplane;
                    }
                    break;

                case 3:
                    if (textBox1.Text.ToLower() == "helicopter")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        helicopterCorrect.Play();
                        pictureBox1.Image = Resources.helicopter;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        helicopterIncorrect.Play();
                        pictureBox1.Image = Resources.helicopter;
                    }
                    break;

                case 4:
                    if (textBox1.Text.ToLower() == "policecar")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        policeCorrect.Play();
                        pictureBox1.Image = Resources.policecar;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        policeIncorrect.Play();
                        pictureBox1.Image = Resources.policecar;
                    }
                    break;


                case 5:
                    if (textBox1.Text.ToLower() == "ambulance")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        ambulanceCorrect.Play();
                        pictureBox1.Image = Resources.ambulance;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        ambulanceIncorrect.Play();
                        pictureBox1.Image = Resources.ambulance;
                    }
                    break;

                case 6:
                    if (textBox1.Text.ToLower() == "bicycle")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        bicycleCorrect.Play();
                        pictureBox1.Image = Resources.bicycle;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        bicycleIncorrect.Play();
                        pictureBox1.Image = Resources.bicycle;
                    }
                    break;

                case 7:
                    if (textBox1.Text.ToLower() == "train")
                    {
                        score++;
                        label1.Text = "Correct Answer";
                        trainCorrect.Play();
                        pictureBox1.Image = Resources.train;
                        isCorrect = true;
                    }
                    else
                    {
                        label1.Text = "Incorrect Answer";
                        trainIncorrect.Play();
                        pictureBox1.Image = Resources.train;
                    }
                    break;

            }

            label2.Text = "SCORE: " + score;
            textBox1.Clear();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (s, args) =>
            {
                currentindex++;
                questions(currentindex);

                if (!quizCompleted)
                {
                    textBox1.Visible = true;
                    button1.Visible = true;
                    textBox1.Enabled = true;
                    button1.Enabled = true;
                }

                timer.Stop();

                if (quizCompleted)
                {
                    SaveScoreToDatabase(Login.LoggedInUsername, score);

                    Score_Card scoreForm = new Score_Card(username, score);
                    scoreForm.Show();
                    this.Hide();
                }
            };
            timer.Start();

            textBox1.Visible = false;
            button1.Visible = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void SaveScoreToDatabase(string username, int score)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\logindata.accdb";
            string query = "INSERT INTO score (username, instrumentscore) VALUES (@username, @instrumentscore)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add(new OleDbParameter("@username", OleDbType.VarChar)).Value = username;
                    command.Parameters.Add(new OleDbParameter("@instrumentscore", OleDbType.Integer)).Value = score;

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        //MessageBox.Show("Score saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving score: " + ex.Message);
                    }
                }
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox.Play();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            textBox.Play();
        }
    }
}
