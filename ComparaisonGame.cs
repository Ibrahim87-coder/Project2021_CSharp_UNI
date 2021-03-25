using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Start
{
    public partial class Jeux_de_comparaison : Form
    {
        public Jeux_de_comparaison()
        {
            InitializeComponent();
            
        }
        int nbTop1, nbTop2, nbComp1, nbComp2, nbComp3,score;

        private void ComparaisonGame_Load(object sender, EventArgs e)
        {
        //    Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\Quest.png");
        //    Quest.Image = bitmap;
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["Comparaison"].ToString()) != 0)
            {
                HighScore.Text = "meilleur Score : " + dr[0]["Comparaison"]; HighScore.Visible = true;
            }

            Play();
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            HelpPic.Visible = false;
            Helppic2.Visible = false;
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            HelpPic.Visible = true;
            Helppic2.Visible = true;
        }
         bool Check(int a,int b,int c)
         {
            switch (c)
            {
                case 0: return a < b;
                case 1: return a == b; 
                case 2: return a > b; 
                default: return false;  
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Comparaison"].ToString()) < score) 
            {
                dr[0]["Comparaison"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
           
            Application.Exit();
        }
        DataRow[] dr;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Comparaison"].ToString()) < score)
            {
                dr[0]["Comparaison"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            } 
            this.Close();
            dr=Variables.XmlReader(Application.StartupPath + "\\users.xml");
            this.ShowInTaskbar = false;
            Variables.matiere.ShowInTaskbar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            bool checking = Check(int.Parse(NB1.Text.ToString()), int.Parse(NB2.Text.ToString()),int.Parse(pic.Tag.ToString()));

            if  (checking) 
            {
                score = score + 10;
                lblScore.Text = "score : " + score;
                
                Quest.Image = pic.InitialImage;
                Thread.Sleep(1000);
                TimerGame.Start();
                Play();
            } 
            else
            {
                score = score - 10;
                lblScore.Text = "score : " + score;
            }
        }
    

        Random rd = new Random();
        void GenerateNumbers()
        {
            nbTop1 = rd.Next(1, 11);
            nbTop2 = rd.Next(1, 11);
          
            do
            {   nbComp1 = rd.Next(0,3);
                nbComp2 = rd.Next(0,3);
                nbComp3 = rd.Next(0,3);
            } while ((nbComp1 == nbComp2) || (nbComp1 == nbComp3) || (nbComp2 == nbComp3));

            //nbTop1 --> nb dans la 1ere button
            //nbTop2 --> nb dans la 2 eme button
            //nbImag --> nb des images dans les picturebox
            //nbComp --> nb des symbols des comparaison
        }
        void RandomImages()
        {
            GenerateNumbers();
            pictureBox1.Image = imageList1.Images[nbComp1];
            pictureBox1.Tag = nbComp1.ToString();
            pictureBox2.Image = imageList1.Images[nbComp2];
            pictureBox2.Tag = nbComp2.ToString();
            pictureBox3.Image = imageList1.Images[nbComp3];
            pictureBox3.Tag = nbComp3.ToString();

            //generer les photos du comparaison
            Bitmap nb1 = new Bitmap(Application.StartupPath + "\\Pics\\"+"0" + nbTop1.ToString() + ".png");
            NBGrand.Image = nb1;
            Bitmap nb2 = new Bitmap(Application.StartupPath + "\\Pics\\" + "0" + nbTop2.ToString() + ".png");
            NbPetit.Image = nb2;
            //generer les photos du nb comparé
            NB1.Text = nbTop1.ToString();
            NB2.Text = nbTop2.ToString();
            //generer les nombres dans le text de la 1ere button
            //generer les nombres dans le text de la 2eme button
        }
        void Play()
        {
            TimerGame.Stop();
            GenerateNumbers();
            RandomImages();
            Quest.Image = imageList1.Images[3];
        }
    }
}
