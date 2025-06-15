using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Bridge
{
    public partial class Score_Card : Form
    {
        private string username;

        public Score_Card(string username, int score)
        {
            InitializeComponent();
            label1.Text = username;
            label2.Text = score.ToString();

        
        }

    }
}

