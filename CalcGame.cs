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
    public partial class jeux_de_Calcule : Form
    {
        public jeux_de_Calcule()
        {
            InitializeComponent();
            Over.Hide();
           
        }

        bool MoveUp, MoveDown, MoveRight, MoveLeft;

        int x,nb1,nb2,rep,score, life,speed=15,level=1;
     
        Random rnd = new Random();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (int.Parse(dr[0]["PlusMoins"].ToString()) < score)
            {
                dr[0]["PlusMoins"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            } 
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["PlusMoins"].ToString()) < score) dr[0]["PlusMoins"] = score;
            Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            Application.Exit();
        }

        private void Life_index()
        {
            if (life == 0)
            {
                Bitmap b1 = new Bitmap(Application.StartupPath + "\\Pics\\LifeOn.png");
                Life1.Image = b1;

                Bitmap b2 = new Bitmap(Application.StartupPath + "\\Pics\\LifeOn.png");
                Life2.Image = b2;


                Bitmap b3 = new Bitmap(Application.StartupPath + "\\Pics\\LifeOn.png");
                Life3.Image = b3;
            }
            if (life == 1)
            {
                Bitmap b1 = new Bitmap(Application.StartupPath + "\\Pics\\LifeOff.png");
                Life1.Image = b1;
            }
            if (life == 2)
            {
                Bitmap b2 = new Bitmap(Application.StartupPath + "\\Pics\\LifeOff.png");
                Life2.Image = b2;
            }
            if (life == 3)
            {
                Bitmap b3 = new Bitmap(Application.StartupPath + "\\Pics\\LifeOff.png");
                Life3.Image = b3;
                Over.Show();
                timerGame.Stop();

            }
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {
            Over.Visible = false;
            //PlaneMovement();
            //Cloud_Move();
            //Game_Update();
            timerGame.Start();
            life = 0;
            Life_index();
            level = 1;
            score = 0;
            lblScore.Text = "Score : 0";
        }

        private void Game_Update()
        {

            if ((planePic.Bounds.IntersectsWith(cloudOp.Bounds) == true) && (rep.ToString() == lblTarget.Text))
            {
                x = rnd.Next(0, 400);
                cloudOp.Location = new Point(500, x);
                op.Location = new Point(550, x + 35);

                cloudOp.Left -= 6;
                op.Left -= 6;

                score += 10;
                lblScore.Text = "Score : " + score;

                if (score > 50) level = 2;

                if (score < 10)
                {
                    cloudOp.Left -= 6;
                    op.Left -= 6;
                }
                else if (score > 25)
                {
                    cloudOp.Left -= 12;
                    op.Left -= 12;
                }
                else if (score > 50)
                {
                    cloudOp.Left -= 20;
                    op.Left -= 20;
                }


                GenerateNumbers();

            } else
            {
                if ((planePic.Bounds.IntersectsWith(cloudOp.Bounds) == false) && (rep.ToString()==lblTarget.Text) && cloudOp.Left < 0)
                {
                    x = rnd.Next(0, 400);
                    cloudOp.Location = new Point(500, x);
                    op.Location = new Point(550, x+35 );

                    cloudOp.Left -= 6;
                    op.Left -= 6;

                    life++;

                    Life_index();

                    GenerateNumbers();

                }
                if ((planePic.Bounds.IntersectsWith(cloudOp.Bounds) == true) && (rep.ToString() != lblTarget.Text))
                {
                    x = rnd.Next(0, 400);
                    cloudOp.Location = new Point(500, x);
                    op.Location = new Point(550, x +35);

                    cloudOp.Left -= 6;
                    op.Left -= 6;

                    life++;

                    Life_index();

                    GenerateNumbers();
                }
            }
            if (score > 10) speed = 15;
            else if (score > 25) speed = 20;
            else if (score > 50) speed = 30;

        }

        private void GenerateNumbers()
        {
            if (level == 1)

            {
                nb1 = rnd.Next(1, 6);
                nb2 = rnd.Next(1, 6);
                lblTarget.Text = rnd.Next(6, 10).ToString();
                op.Text = nb1.ToString() + "+" + nb2.ToString();
                rep = nb1 + nb2;

            }
            else if (level == 2)
            {
                do
                {
                    nb1 = rnd.Next(1, 11);
                    nb2 = rnd.Next(1, 11);

                } while (nb1<nb2);
               
                lblTarget.Text = rnd.Next(0, 6).ToString();
                op.Text = nb1.ToString() + "-" + nb2.ToString();
                rep = nb1 - nb2;
            }
           
        }
        private void Cloud_Move()
        {
            x = rnd.Next(0, 400);
            cloudOp.Left -= 6;
            op.Left -= 6;
            if (cloudOp.Left < -10 && op.Left<0 )
            {
               
                cloudOp.Location = new Point(500,x);
                op.Location = new Point(550, x+35);
                GenerateNumbers();
            }
        }
        DataRow[] dr;
        private void CalcGame_Load(object sender, EventArgs e)
        { 
            GenerateNumbers();
            lblTarget.Text= rnd.Next(6,10).ToString();
            timerGame.Start();



            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["PlusMoins"].ToString()) != 0)
            {
                HGNB.Text = "Score élevé : " + dr[0]["PlusMoins"]; HGNB.Visible = true;
            }

        }
        private void CalcGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = true;
            }
        }
        private void CalcGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = false;
            }
        }
        private void timerGame_Tick(object sender, EventArgs e)
        {
            PlaneMovement();
            Cloud_Move();
            Game_Update();
        }
        private void PlaneMovement()
        {
            
            if (MoveLeft == true && planePic.Left > 0)
            {
                planePic.Left -= speed;
            }

            if (MoveRight == true && planePic.Left < 500)
            {
                planePic.Left += speed;
            }

            if (MoveUp == true && planePic.Top > 0)
            {
                planePic.Top -= speed;
            }

            if (MoveDown == true && planePic.Top < 350)
            {
                planePic.Top += speed;
            }
        }
    }
}
