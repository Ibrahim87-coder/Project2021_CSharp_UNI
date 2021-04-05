using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Périmetre : Form
    {
        List<string> imageName;

         int counter = 0;
        bool vraiounon = false;
        public Périmetre()
        {

            InitializeComponent();
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");

            imageName = new List<string>

                {
                    Application.StartupPath+"\\Pics\\permCarre01.png",

                    Application.StartupPath+"\\Pics\\permREC02.png",

                    Application.StartupPath+"\\Pics\\permLOS0.png",


                    Application.StartupPath+"\\Pics\\tri.png",

                    Application.StartupPath+"\\Pics\\permCERCLE0.png"
                };

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;

            this.pi.Visible = false;
        }

        private void PermCours_Load(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["Perim"].ToString()) != 0)
            {
                meilleur.Text = "meilleur Score : " + dr[0]["Perim"]; 
                meilleur.Visible = true;
            }

            var image = Image.FromFile(imageName[0]);

            PermForm.Image = image;
            nbrd1 = 1;
            permpic.Image = bitmaps[0];
            vraiounon = false;
        }
        // tableau pour le sentaxe
        string[] tab = new string[] {
                                       "Le périmètre d'un carré s'exprime en fonction de la longueur de ses côtés",
                                       "Le périmètre d'un rectangle s'exprime en fonction de sa longueur et sa largeur",
                                       "Le périmètre d'un losange s'exprime en fonction de la longueur de ses côtés",
                                       "Le périmètre d'un triangle s'exprime en fonction de la longueur de ses côtés",
                                       "Le périmètre d'un cercle s'exprime en fonction de la longueur de son rayon"
                                       };

        string[] tabCalc = new string[] {

            "Le périmètre d'un carré: ",
            "Le périmètre d'un rectangle: ",
            "Le périmètre d'un losange: ",
            "Le périmètre d'un triangle:",
            "Le périmètre d'un cercle: "

        };
        string[] CaclPerim = new string[]
        {

            "P = c + c + c + c alors P = 4*c ",
            "P = L + L + l + l alors P = 2*L + 2*l",
            "P = c + c + c + c alors P = 4*c ",
            "P = a + b + c",
            "P = 2 * π * r"
        };
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Perim"].ToString()) < score)
            {
                dr[0]["Perim"] = score; Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Calculatrice calculatrice = new Calculatrice();
            calculatrice.Show();
        }
        Bitmap[] bitmaps = {

            new Bitmap(Application.StartupPath+"\\Pics\\perm1.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm2.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm3.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm4.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm5.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm6.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm7.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm8.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm9.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm10.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm11.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm12.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm13.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm14.png"),
            new Bitmap(Application.StartupPath+"\\Pics\\perm15.png"),

        };

        int score, level = 1, nbrd1, count = 0;
        private void suivant()
        {
            permpic.Image = bitmaps[nbrd1];
            nbrd1++;
           
            reptxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {

                //Carre de cote 3
                if ((reptxt.Text == "12") && (nbrd1 == 1))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;

                    suivant();
                    count++;
                    

                }
                else vraiounon = false;

                //triangle de cote 2.7+3.4+4
                if ((reptxt.Text == "10.1") && (nbrd1 == 2))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true; suivant();
                   

                    suivant(); count++;
                    

                }
                else vraiounon = false;

                //rec de cote 8+12+12+8
                if ((reptxt.Text == "40") && (nbrd1 == 3))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;
                   
                    suivant(); count++;
                    

                }
                else vraiounon = false;

                //paralle de cotes 5+5+6+6
                if ((reptxt.Text == "22") && (nbrd1 == 4))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true; 
                    suivant(); count++;
                    
                }
                else vraiounon = false;


                //cercle de rayon 4
                if ((reptxt.Text == "25.12") && (nbrd1 == 5))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;


                   
                    suivant();
                    count++;
                    level++;
                    count = 0;
                    



                }
                else vraiounon = false;

                // na2es nzid l retry

            }
            else

                if (level == 2)
            {
                //quadri de cote 4+4.5+2.3+2
                if ((reptxt.Text == "12.8") && (nbrd1 == 6))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;
                    permpic.Image = bitmaps[nbrd1];
                    suivant(); count++;
                }
                else

                  //quadri de cote 3.2+3+4+2.5
                if ((reptxt.Text == "12.7") && (nbrd1 == 7))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;
                    suivant(); count++;
                    
                }
                else

                 //hex de cotes 3+4+4+3+1.5+2.5
                if ((reptxt.Text == "18") && (nbrd1 == 8))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;
                    permpic.Image = bitmaps[nbrd1];
                    reptxt.Clear();
                    suivant(); count++;
                    

                }
                else

            //cercle de diam 8
            if ((reptxt.Text == "25.12") && (nbrd1 == 9))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;
                    suivant(); count++;
                    
                }
                else


            //hex de cotes 8+5+3+3+2+5
            if ((reptxt.Text == "26") && (nbrd1 == 10))
                {
                    score += 10;
                    scoretxt.Text = "Score: " + score;
                    vraiounon = true;
                    count++; suivant();
                }
                else vraiounon = false;
            }
            else

            {
                if (level == 3)
                {

                    //pent de cote 2.2+3.8+3.3+2.5+2.2
                    if ((reptxt.Text == "14") && (nbrd1 == 11))
                    {
                        score += 10;
                        scoretxt.Text = "Score: " + score;
                        vraiounon = true;
                        suivant();
                        count++;
                       }
                    else vraiounon = false;

                    //quadri de cote 3.4+1.6+1.5+2.3+2.6
                    if ((reptxt.Text == "11.4") && (nbrd1 == 12))
                    {
                        score += 10;
                        scoretxt.Text = "Score: " + score;
                        vraiounon = true;
                        suivant(); count++;
                    }
                    else vraiounon = false;
                    //quadri de cotes 6+4+5+5+2+1+3
                    if ((reptxt.Text == "26") && (nbrd1 == 13))
                    {
                        score += 10;
                        scoretxt.Text = "Score: " + score;
                        vraiounon = true;
                        suivant(); count++;
                    }
                    else vraiounon = false;

                    //quadri de cote 2.9+2.9+4+2.4+2+1.8
                    if ((reptxt.Text == "16") && (nbrd1 == 14))
                    {
                        score += 10;
                        scoretxt.Text = "Score: " + score;
                        vraiounon = true;
                        suivant(); count++;
                    }
                    else vraiounon = false;


                    //cotes 3+4+3+2+6+6.28+4.71
                    if ((reptxt.Text == "28.99") && (nbrd1 == 15))
                    {
                        score += 10;
                        scoretxt.Text = "Score: " + score;
                        vraiounon = true;
                        Fecil.Visible = true;
                    }
                    else vraiounon = false;

                }
            }
        }
        private void labelretry_MouseMove(object sender, MouseEventArgs e)
        {
            labelretry.Visible = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if ((level == 1) && (vraiounon = true))
            {
                permpic.Image = bitmaps[nbrd1];
                permpic.SizeMode = PictureBoxSizeMode.StretchImage;

                labelretry.Visible = false;
                reptxt.Clear();
            }
            else if ((level == 2) && (vraiounon = true))
            {
                permpic.Image = bitmaps[nbrd1];
                permpic.SizeMode = PictureBoxSizeMode.StretchImage;
                labelretry.Visible = false;
                reptxt.Clear();
            }
            else if ((level == 3) && (vraiounon = true))
            {
                permpic.Image = bitmaps[nbrd1];
                permpic.SizeMode = PictureBoxSizeMode.StretchImage;
                labelretry.Visible = false;
                reptxt.Clear();
            }
        }
        DataRow[] dr;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Perim"].ToString()) < score)
            {
                dr[0]["Perim"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        Random random = new Random();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            Image image;
            try { image = Image.FromFile(imageName[counter]); } catch { image = null; }

            PermForm.Image = image;

            if (this.counter == 0)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
            }
            //pour effacer les labels cotes(c)

            if (this.counter == 4) this.pi.Visible = true; // pour voir la figure de pi
            else this.pi.Visible = false;

            this.TextForm.Text = tab[counter]; // pour changer le sentaxe
            this.FormNom.Text = tabCalc[counter];// pour changer le sentaxe
            this.CalcLabel.Text = CaclPerim[counter];// pour changer le sentaxe
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            counter = counter - 1;

            Image image = Image.FromFile(imageName[counter]);

            PermForm.Image = image;

            if (this.counter == 0)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
            }

            if (this.counter == 4) this.pi.Visible = true;
            else this.pi.Visible = false;

            this.TextForm.Text = tab[counter];
            this.FormNom.Text = tabCalc[counter];
            this.CalcLabel.Text = CaclPerim[counter];

        }

    }
}

