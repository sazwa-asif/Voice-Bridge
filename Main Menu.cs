﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Bridge
{
    public partial class Main_Menu : Form
    {
        private string username;
        public Main_Menu(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Instrumental_Sound i = new Instrumental_Sound(username);
            i.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main_Game m = new Main_Game(username);
            m.Show();
            this.Hide();
        }

        //private void label5_Click(object sender, EventArgs e)
        //{
        //    //Score_Card s = new Score_Card(username);
        //    //s.Show();
        //    //this.Hide();
        //}

        private void label4_Click(object sender, EventArgs e)
        {
            Transport_Sound t = new Transport_Sound(username);
            t.Show();
            this.Hide();
        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}
    }
}
