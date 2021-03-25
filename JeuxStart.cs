using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Jeux : Form
    {
        public Jeux()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.intro.Show();
        }

        private void JeuxStart_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(game1, "Flappy Bird jeux");
            toolTip1.SetToolTip(game2, "Tic Toe");
            toolTip1.SetToolTip(game3, "Les Nombres");
        }

        private void game1_Click(object sender, EventArgs e)
        {
            this.Hide();
            jeux_Flappy_Bird flappy_ = new jeux_Flappy_Bird();
            flappy_.Show();
        }

        private void game3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coloriage coloriage = new Coloriage();
            coloriage.Show();
        }

        private void game2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicTacToe ticTac = new TicTacToe();
            ticTac.Show();
        }
    }
}
