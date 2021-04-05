
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
    public partial class formesGame2 : Form
    {
        //Variables
        //int score = 0; //Our Scores
        Random location = new Random(); //Selects a random value from X and Y list and assign a new location to each card
        List<Point> points = new List<Point>(); //List to hold cards points
        
        PictureBox PendingImage1; //Store first flipped card into this variable
        PictureBox PendingImage2;//----- Second -------------------------------

        public formesGame2()
        {
            InitializeComponent();
        }
        SoundPlayer cercleSound = new SoundPlayer(Application.StartupPath+ "\\Sounds\\Cercle.wav");
        SoundPlayer triangleSound = new SoundPlayer(Application.StartupPath + "\\Sounds\\Triangle.wav");
        SoundPlayer rectangleSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\rectangle.wav");
        SoundPlayer carreSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\Carre.wav");
        SoundPlayer etoileSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\Etoile.wav");
        SoundPlayer paralleloSound = new SoundPlayer(Application.StartupPath+ "\\Sounds\\parallelogramme.wav");
        SoundPlayer pentaSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\pentagone.wav");
        SoundPlayer trapSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\trapeze.wav");
        SoundPlayer demiSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\demi-cercle.wav");
        SoundPlayer losSound = new SoundPlayer(Application.StartupPath+"\\Sounds\\Los.wav");


        private void Game_Load(object sender, EventArgs e)
        {
            FormeText.Visible=false;
            ScoreCounter.Text = "0";
            label1.Text = "5";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
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
            Card3.Image = Properties.Resources.Card3;
            DupCard3.Image = Properties.Resources.Card3;
            Card4.Image = Properties.Resources.Card4;
            DupCard4.Image = Properties.Resources.Card4;
            Card5.Image = Properties.Resources.Card5;
            DupCard5.Image = Properties.Resources.Card5;
            Card6.Image = Properties.Resources.Card6;
            DupCard6.Image = Properties.Resources.Card6;
            Card7.Image = Properties.Resources.Card7;
            DupCard7.Image = Properties.Resources.Card7;
            Card8.Image = Properties.Resources.Card8;
            DupCard8.Image = Properties.Resources.Card8;
            Card9.Image = Properties.Resources.Card9;
            DupCard9.Image = Properties.Resources.Card9;
            Card10.Image = Properties.Resources.Card10;
            DupCard10.Image = Properties.Resources.Card10;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer-1;
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
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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

                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Trapeze";
                    //trapSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

                    FormeText.Visible = true;
                    FormeText.Text = "Un Trapeze";
                    trapSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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

                    paralleloSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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
                    carreSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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

                    carreSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Demi-Cercle";
                    demiSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

                    FormeText.Visible = true;
                    FormeText.Text = "Un Demi-Cercle";
                    demiSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Un Losange";
                    losSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

                    FormeText.Visible = true;
                    FormeText.Text = "Un Losange";
                    losSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            Card8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Une Etoile";
                    etoileSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            FormeText.Visible = false;
            DupCard8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = DupCard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    FormeText.Visible = true;
                    FormeText.Text = "Une Etoile";
                    etoileSound.Play();
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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

                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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

                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {

            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }
    }
}
