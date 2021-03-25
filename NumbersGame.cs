using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Start
{
    public partial class NumbersGame : Form
    {
        public NumbersGame()
        {
            InitializeComponent();
        }

        void Play()
        {
            int nbRan1 , nbRan2, nbRan3;
            
            timerNb.Stop();
            Random rdnb = new Random();

            do
            {    
            nbRan1 = rdnb.Next(1, 11);
            nbRan2 = rdnb.Next(1, 11);
            nbRan3 = rdnb.Next(1, 11);
            } while ((nbRan1 == nbRan2) || (nbRan1 == nbRan3) || (nbRan2 == nbRan3));

            int nbRan4 = rdnb.Next(1, 4);

                Bitmap bitnb1 = new Bitmap(Application.StartupPath + "\\Pics\\" + nbRan1 + ".gif");
                Bitmap bitnb2 = new Bitmap(Application.StartupPath + "\\Pics\\" + nbRan2 + ".gif");
                Bitmap bitnb3 = new Bitmap(Application.StartupPath + "\\Pics\\" + nbRan3 + ".gif");
                nb1.Image = bitnb1;
                nb2.Image = bitnb2;
                nb3.Image = bitnb3;
                nb1.Image.Tag = nbRan1;
                nb2.Image.Tag = nbRan2;
                nb3.Image.Tag = nbRan3;

            switch (nbRan4) 
            {
                case 1:
                    labelNb.Text = nbRan1.ToString();
                    mediaplayer.URL =Application.StartupPath+"\\Sounds\\"+"Taper "+nbRan1+".m4a";
                    break;
                case 2:
                    labelNb.Text = nbRan2.ToString();
                    mediaplayer.URL = Application.StartupPath + "\\Sounds\\" + "Taper " + nbRan2 + ".m4a";
                    break;
                default:
                    labelNb.Text = nbRan3.ToString();
                    mediaplayer.URL = Application.StartupPath + "\\Sounds\\" + "Taper " + nbRan3 + ".m4a";
                    break;
            }

        }
        DataRow[] dr;
        private void NumbersGame_Load(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["Nombres"].ToString()) != 0)
            {
                HighScore.Text = "meilleur Score : " + dr[0]["Nombres"]; HighScore.Visible = true;
            }
            Play();
        }
        int Score;
        private void nb1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            mediaplayer.Ctlenabled=true;
            if (pic.Image.Tag.ToString() == labelNb.Text.ToString())
            {
                
                Score = Score+10;

                score.Text = "Score : " + Score;

                timerNb.Start();
                Play();
            }
            else
            {
                mediaplayer.URL = Application.StartupPath + "\\Sounds\\Oops.m4a";
                mediaplayer.Ctlenabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Nombres"].ToString()) < Score)
            {

                dr[0]["Nombres"] = Score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Nombres"].ToString()) < Score) 
            {
                dr[0]["Nombres"] = Score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");  
            } 

            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }
    }
}
