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
    public partial class jeux_Flappy_Bird : Form
    {
        int pipeSpeed = 5;
        int gravity = 15;
        public static int Score = 0;



        public jeux_Flappy_Bird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + Score;

            if(pipeBottom.Left< -150)
            {
                pipeBottom.Left = 800;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                Score+=10;

            }
            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                 flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                 flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                 (flappyBird.Top < -25) 
                 )
            {
                endGame();
            }

            if (Score>30)
            {
                pipeSpeed = 15;
            }
        }

        private void GameisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {

                gravity = -15;
            }
        }

        private void GameisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 15;
            }
        }
        
        private void endGame()
        {
            gameTimer.Stop();
            btnRestart.Visible = true;
            scoreText.Text = "meilleur Score : " + dr[0]["FlappyBird"];
            scoreText.Location = new Point(203, 336);
        }

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["FlappyBird"].ToString()) != 0)
            {
                scoreText.Text = "meilleur Score : " + dr[0]["FlappyBird"];
                scoreText.Visible = true;
            }
            if (debut == 0)
                gameTimer.Stop();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.ShowInTaskbar = false;
        }
        int debut = 0;
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            scoreText.Location = new Point(70, 20);
            scoreText.BringToFront();
            scoreText.Text = "Score : " + Score;
            gameTimer.Start();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["FlappyBird"].ToString()) < Score)
            {

                dr[0]["FlappyBird"] = Score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            scoreText.Location = new Point(65, 20);
            debut = 1;
            Score =0;
            btnRestart.Visible = false;
            pipeTop.Location = new Point(590, 9);
            pipeBottom.Location = new Point(460, 500);
            flappyBird.Location = new Point(75, 360);
            ground.Location = new Point(0, 630);
            ground.BringToFront();
            ground.Visible = true;

            gameTimer.Start();
        }
        DataRow[] dr;
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["FlappyBird"].ToString()) < Score)
            {

                dr[0]["FlappyBird"] = Score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["FlappyBird"].ToString()) < Score)
            {
                dr[0]["FlappyBird"] = Score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            this.Close();

            Variables.Jeux.Show();
            Variables.Jeux.ShowInTaskbar = true;
        }
    }
}
