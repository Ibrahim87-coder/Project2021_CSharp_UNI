
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Start
{
    public partial class jeux_de_formes_geo : Form
    {
        //Variables
        //int score = 0; //Our Scores
        Random location = new Random(); //Selects a random value from X and Y list and assign a new location to each card
        List<Point> points = new List<Point>(); //List to hold cards points
        
        PictureBox PendingImage1; //Store first flipped card into this variable
        PictureBox PendingImage2;//----- Second -------------------------------

        public jeux_de_formes_geo()
        {
            InitializeComponent();
        }

        SoundPlayer cercleSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\Cercle.wav");
        SoundPlayer triangleSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\Triangle.wav");
        SoundPlayer rectangleSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\rectangle.wav");
        SoundPlayer carreSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\Carre.wav");
        
        SoundPlayer paralleloSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\parallelogramme.wav");
        SoundPlayer pentaSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\pentagone.wav");
       




        int lvl2;

        private void Game_Load(object sender, EventArgs e)
        {

            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            lvl2 = 0;
            allez_a_niveau2.Visible = false;
            FormeText.Visible = false;
            ScoreCounter.Text = "0";
            label1.Text = "5";
            foreach (PictureBox picture in level1.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in level1.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                picture.Height = 115;
                picture.Width = 115;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                points.Remove(p);
            }

            timer2.Start();
            timer1.Start();

            Card1.Image = Properties.Resources.Card1;
            DupCard1.Image = Properties.Resources.Card1;
            Card2.Image = Properties.Resources.Card2;
            DupCard2.Image = Properties.Resources.Card2;
            Card4.Image = Properties.Resources.Card4;
            DupCard4.Image = Properties.Resources.Card4;
            Card5.Image = Properties.Resources.Card5;
            DupCard5.Image = Properties.Resources.Card5;
            Card9.Image = Properties.Resources.Card9;
            DupCard9.Image = Properties.Resources.Card9;
            Card10.Image = Properties.Resources.Card10;
            DupCard10.Image = Properties.Resources.Card10;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in level1.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer - 1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }

        //Change Card Value
        #region Cards
        private void Card1_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card1;

            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag &&  PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Cercle";
                    cercleSound.Play();
                    lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }
        private void DupCard1_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Cercle";
                    cercleSound.Play();
                    lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
          
            GO();
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;

            Card2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Rectangle";
                    rectangleSound.Play();
                    lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Rectangle";
                    rectangleSound.Play();
                  lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Parallelogramme";
                    paralleloSound.Play();
                    lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Parallelogramme";
                    lvl2++;
                    paralleloSound.Play();
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Carre";
                    lvl2++;
                    carreSound.Play();
                    
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Carre";
                    lvl2++;
                    carreSound.Play();
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }


        private void Card9_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card9.Image = Properties.Resources.Card9;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Triangle";
                    triangleSound.Play();

                    lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void DupCard9_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard9.Image = Properties.Resources.Card9;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Triangle";
                    triangleSound.Play();
                    //lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card10.Image = Properties.Resources.Card10;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Pentagone";
                    pentaSound.Play();
                    lvl2++;

                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        private void DupCard10_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard10.Image = Properties.Resources.Card10;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Pentagone";
                    pentaSound.Play();
                    //lvl2++;
                }
                else
                {
                    
                    timer3.Start();
                }
            }
            
            GO();
        }

        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Cover;
            PendingImage2.Image = Properties.Resources.Cover;

            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_Load(sender, e);
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void ScoreCounter_Click(object sender, EventArgs e)
        {

        }

        private void CardsHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            formesGame2 formesGame2 = new formesGame2();
            formesGame2.Show();
        }
      

        private void GO()
        {
            if (ScoreCounter.Text == 60.ToString())
            {
                allez_a_niveau2.Visible = true;
            }
        }
        DataRow[] dr;
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["FormesGeo"].ToString()) < Convert.ToInt32(ScoreCounter.Text))
            {

                dr[0]["FormesGeo"] = Convert.ToInt32(ScoreCounter.Text);
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");


            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["FormesGeo"].ToString()) < Convert.ToInt32(ScoreCounter.Text))
            {

                dr[0]["FormesGeo"] = Convert.ToInt32(ScoreCounter.Text);
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            Variables.matiere.ShowInTaskbar = true;
            Variables.matiere.Show();
            this.Close();
        }
    }
}
