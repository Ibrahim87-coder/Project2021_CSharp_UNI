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
    public partial class MatiereStart : Form
    {
        public MatiereStart()
        {
            InitializeComponent();
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            Variables.counter = 0;
        }

        public bool cours = false;
        DataRow[] dr;
        private void Maths_Load(object sender, EventArgs e)
        {
            usernameMaths.Text = Variables.intro.username.Text;
            if (Variables.MatiereNomPublic == "MT")
            {
                lvlFrancais.Visible = false;lvlMaths.Visible = true;
                PanelMaths.Visible = true;
                PanelFrancais.Visible = false;

                toolTip1.SetToolTip(Picmt1, "Les Nombres");
                toolTip1.SetToolTip(Picmt2, "Les suites des nombres");
                toolTip1.SetToolTip(Picmt3, "La comparaison");
                toolTip1.SetToolTip(Picmt4, "Addition et soustraction");
            }
            else if (Variables.MatiereNomPublic == "FR")
            {
                PanelFrancais.Visible = true;
                PanelMaths.Visible = false; lvlFrancais.Visible = true; lvlMaths.Visible =false;

                // this.Invoke(new MethodInvoker(() => PanelFrancais .Show ()));
                toolTip1.SetToolTip(Picfr1, "Prononciation");
                // PanelFrancais.Visible = true;
                toolTip1.SetToolTip(Picfr2, "Ecriture");

            }

        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Variables.MatiereNomPublic = "";
            Variables.counter = 0;
            Variables.intro.Show();
            this.Close();
            this.ShowInTaskbar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void matiereStartUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");

            if (Variables.counter > 2) Variables.counter = 2;
            Variables.counter = Variables.counter + 1;

            if (Variables.counter == 1)
            {
                if (Variables.MatiereNomPublic == "MT")
                {
                    lvlFrancais.Visible = false;lvlMaths.Visible = true;
                    if (int.Parse(dr[0]["Nombres"].ToString()) +
                        int.Parse(dr[0]["Suitenb"].ToString()) +
                        int.Parse(dr[0]["Comparaison"].ToString())
                        + int.Parse(dr[0]["PlusMoins"].ToString()) < 250)
                    {
                        lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = true;
                        PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = false;
                    }
                    else
                    {

                        lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = false;lvlMaths.Image = Properties.Resources.crown2;
                        PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = true;
                        if(Variables.levelmt==1){
                            Variables.levelmt = 2;
                            dr[0]["lvlmt"] = 2;
                            Variables.XmlWriter(Application.StartupPath + "\\users.xml");
                        }
                    }


                    PanelMaths.Visible = true;
                    PanelFrancais.Visible = false;

                    toolTip1.SetToolTip(Picmt1, "Foix et divisé");
                    toolTip1.SetToolTip(Picmt2, "Les formes géométeriques");
                    toolTip1.SetToolTip(Picmt3, "Double et moitié");
                    toolTip1.SetToolTip(Picmt4, "Fraction");

                    lbl.Text = "Intermediaire";
                    Picmt1.Name = "Picmt5";
                    Picmt2.Name = "Picmt6";
                    Picmt3.Name = "Picmt7";
                    Picmt4.Name = "Picmt8";

                    for (int i = 5; i < 9; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\mathsLvl" + i + ".png");

                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImage = image;
                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (Variables.MatiereNomPublic == "FR")
                {
                    lvlMaths.Visible = false;lvlFrancais.Visible = true;
                    PanelMaths.Visible = false;
                    PanelFrancais.Visible = true;
                    if (int.Parse(dr[0]["prononciation"].ToString()) + int.Parse(dr[0]["Ecriture"].ToString()) < 2)
                    {
                        lock1.Visible = lock2.Visible = lock3.Visible = true;lvlFrancais.Image = Properties.Resources.crown2;
                        PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = false;
                    }
                    else
                    {
                        lock1.Visible = lock2.Visible = lock3.Visible = false;lvlFrancais.Image = Properties.Resources.crown2;
                        PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = true;
                        if (Variables.levelfr == 1)
                        {
                            Variables.levelfr = 2;
                            dr[0]["lvlfr"] = 2;
                            Variables.XmlWriter(Application.StartupPath + "\\users.xml");
                        }
                    }

                    Picfr3.Visible = true;
                    PicfrCours3.Visible = true;
                    PicfrEX3.Visible = true; PicfrCours1.Visible = true;

                    toolTip1.SetToolTip(Picfr1, "Orthographe");
                    toolTip1.SetToolTip(Picfr2, "Grammaire 1");
                    toolTip1.SetToolTip(Picfr3, "Conjugaison 1");

                    //Picfr3.Name = "Picfr5";
                    Picfr1.Name = "Picfr3";
                    Picfr2.Name = "Picfr4";
                    Picfr3.Name = "Picfr5";
                    lbl.Text = "Intermediaire";

                    for (int i = 3; i < 6; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\frns" + i + ".png");

                        PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImage = image;
                        PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

            }
            else
            if (Variables.counter == 2)
            {
                if (Variables.MatiereNomPublic == "MT")
                {
                    
                    if (int.Parse(dr[0]["MultiDiv"].ToString()) + int.Parse(dr[0]["FormesGeo"].ToString()) + int.Parse(dr[0]["MoitieEtDouble"].ToString()) + int.Parse(dr[0]["Fractions"].ToString()) < 250)
                    {
                        lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = lockmt5.Visible = true;
                        PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtEX5.Enabled = PicmtCours5.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = false;
                    }
                    else
                    {
                        lvlMaths.Image = Properties.Resources.crown3;
                        lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = false;
                        PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = true;

                            Variables.levelmt = 3;
                            dr[0]["lvlmt"] = 3;
                            Variables.XmlWriter(Application.StartupPath + "\\users.xml");
                        
                    }

                    PanelMaths.Visible = true;
                    PanelFrancais.Visible = false;
                    toolTip1.SetToolTip(Picmt1, "L'heure");
                    toolTip1.SetToolTip(Picmt2, "Ordre croissante et décroissante");
                    toolTip1.SetToolTip(Picmt3, "Périmètre");
                    toolTip1.SetToolTip(Picmt4, "Complèment à 10");
                    toolTip1.SetToolTip(Picmt13, "Calcule avec priorité");

                    Picmt1.Name = "Picmt9";
                    Picmt2.Name = "Picmt10";
                    Picmt3.Name = "Picmt11";
                    Picmt4.Name = "Picmt12";

                    Picmt13.Visible = true;
                    PicmtCours5.Visible = true;
                    PicmtEX5.Visible = true;

                    lbl.Text = "Champions";
                    for (int i = 9; i < 14; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\mathsLvl" + i + ".png");

                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImage = image;
                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else if (Variables.MatiereNomPublic == "FR")
                {
                    if (int.Parse(dr[0]["orthographe"].ToString())
                        + int.Parse(dr[0]["conjugaison1"].ToString())
                        + int.Parse(dr[0]["SingulierOuPluriel"].ToString())< 10)
                    {
                        lock1.Visible = lock2.Visible = lock3.Visible = true;
                        PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = false;
                    }
                    else
                    {
                        lock1.Visible = lock2.Visible = lock3.Visible = false; lvlFrancais.Image = Properties.Resources.crown3;
                        PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = true;
                        
                        Variables.levelfr = 3;
                        dr[0]["lvlfr"] = 3;
                        Variables.XmlWriter(Application.StartupPath + "\\users.xml");
                    }

                    //PanelMaths.Visible = false;
                    //PanelFrancais.Visible = true;

                    toolTip1.SetToolTip(Picfr1, "Dictée");
                    toolTip1.SetToolTip(Picfr2, "Grammaire 2");
                    toolTip1.SetToolTip(Picfr3, "Conjugaison 2");
                    PicfrCours1.Visible = false;

                    Picfr1.Name = "Picfr6";
                    Picfr2.Name = "Picfr7";
                    Picfr3.Name = "Picfr8";


                    lbl.Text = "Champions";
                    for (int i = 6; i < 9; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\frns" + i + ".png");

                        PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImage = image;
                        PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }


            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {

            if (Variables.counter < 0) Variables.counter = 0;
            Variables.counter = Variables.counter - 1;



            if (Variables.counter == 0)
            {
                if (Variables.MatiereNomPublic == "MT")

                {


                    // invisualiser les clés
                    lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = lockmt5.Visible = false;
                    PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = true;


                    PanelMaths.Visible = true;
                    PanelFrancais.Visible = false;

                    Picmt13.Visible = false;
                    PicmtCours5.Visible = false;
                    PicmtEX5.Visible = false;

                    Picmt1.Name = "Picmt1";
                    Picmt2.Name = "Picmt2";
                    Picmt3.Name = "Picmt3";
                    Picmt4.Name = "Picmt4";

                    toolTip1.SetToolTip(Picmt1, "Les Nombres");
                    toolTip1.SetToolTip(Picmt2, "Les suites des nombres");
                    toolTip1.SetToolTip(Picmt3, "La comparaison");
                    toolTip1.SetToolTip(Picmt4, "Addition et soustraction");

                    lbl.Text = "Debutant";
                    for (int i = 1; i < 5; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\mathsLvl" + i + ".png");

                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImage = image;
                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else
                {
                    if (Variables.MatiereNomPublic == "FR")
                    {
                        //PanelMaths.Visible = false;
                        //PanelFrancais.Visible = true;
                        lock1.Visible = lock2.Visible = lock3.Visible = false; PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = true;


                        Picfr3.Visible = false;
                        PicfrCours3.Visible = false;
                        PicfrEX3.Visible = false; PicfrCours1.Visible = true;

                        Picfr1.Name = "Picfr1";
                        Picfr2.Name = "Picfr2";
                        Picfr3.Name = "Picfr3";

                        toolTip1.SetToolTip(Picfr1, "Prononciation");
                        toolTip1.SetToolTip(Picfr2, "Ecriture");


                        lbl.Text = "Debutant";
                        for (int i = 1; i < 3; i++)
                        {
                            Image image = Image.FromFile(Application.StartupPath + "\\Pics\\frns" + i + ".png");

                            PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImage = image;
                            PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }

                }

            }
            if (Variables.counter == 1)
            {

                if (Variables.MatiereNomPublic == "MT")
                {
                    lockmt5.Visible = false;

                    if (int.Parse(dr[0]["Nombres"].ToString()) + int.Parse(dr[0]["Suitenb"].ToString()) + int.Parse(dr[0]["Comparaison"].ToString()) + int.Parse(dr[0]["PlusMoins"].ToString()) < 250)
                    {
                        lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = true;
                        PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = false;
                    }
                    else
                    {

                        lockmt1.Visible = lockmt2.Visible = lockmt3.Visible = lockmt4.Visible = false;
                        PicmtEX1.Enabled = PicmtEX2.Enabled = PicmtEX3.Enabled = PicmtCours4.Enabled = PicmtEX4.Enabled = PicmtCours1.Enabled = PicmtCours2.Enabled = PicmtCours3.Enabled = true;
                    }


                    PanelMaths.Visible = true;
                    PanelFrancais.Visible = false;


                    Picmt13.Visible = false;
                    PicmtCours5.Visible = false;
                    PicmtEX5.Visible = false;

                    PanelFrancais.Visible = false;
                    toolTip1.SetToolTip(Picmt1, "Foix et divisé");
                    toolTip1.SetToolTip(Picmt2, "Les formes géométeriques");
                    toolTip1.SetToolTip(Picmt3, "Double et moitié");
                    toolTip1.SetToolTip(Picmt4, "Fraction");

                    lbl.Text = "Intermediaire";
                    Picmt1.Name = "Picmt5";
                    Picmt2.Name = "Picmt6";
                    Picmt3.Name = "Picmt7";
                    Picmt4.Name = "Picmt8";

                    for (int i = 5; i < 9; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\mathsLvl" + i + ".png");

                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImage = image;
                        PanelMaths.Controls["Picmt" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

                else if (Variables.MatiereNomPublic == "FR")
                {
                    PanelMaths.Visible = false;
                    PanelFrancais.Visible = true;
                    if (int.Parse(dr[0]["prononciation"].ToString()) + int.Parse(dr[0]["Ecriture"].ToString()) < 2)

                    {
                        lock1.Visible = lock2.Visible = lock3.Visible = true;
                        PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = false;
                    }
                    else
                    {
                        lock1.Visible = lock2.Visible = lock3.Visible = false;
                        PicfrEX1.Enabled = PicfrEX2.Enabled = PicfrEX3.Enabled = PicfrCours1.Enabled = PicfrCours2.Enabled = PicfrCours3.Enabled = true;
                    }

                    Picfr2.Visible = true; PicfrCours1.Visible = true;

                    toolTip1.SetToolTip(Picfr1, "Orthographe");
                    toolTip1.SetToolTip(Picfr2, "Grammaire 1");
                    toolTip1.SetToolTip(Picfr3, "Conjugaison 1");



                    lbl.Text = "Intermediaire";
                    Picfr1.Name = "Picfr4";
                    Picfr2.Name = "Picfr5";
                    Picfr3.Name = "Picfr3";


                    for (int i = 3; i < 6; i++)
                    {
                        Image image = Image.FromFile(Application.StartupPath + "\\Pics\\frns" + i + ".png");

                        PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImage = image;
                        PanelFrancais.Controls["Picfr" + i.ToString()].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }

        private void PicfrCours1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //cours pronoc
                cours_Prononciation pro = new cours_Prononciation();
                pro.Show();

            }
            else if (Variables.counter == 1)
            {
                //cours orthog
            }
            else if (Variables.counter == 2)
            {
                //cours dictee

            }
        }

        private void PicfrEX1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //ex pronoc
                Apprentissage_1_recone_De_1_sons exPro = new Apprentissage_1_recone_De_1_sons();
                exPro.Show();

            }
            else if (Variables.counter == 1)
            {
                //ex orthog

                homlvl2 orthographe = new homlvl2();
                orthographe.Show();

            }
            else if (Variables.counter == 2)
            {
                //ex dictee
                Dictée dictation = new Dictée();
                dictation.Show();
            }
        }

        private void PicfrCours2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //cours ecriture
                cours_de_ecriture ecrCours = new cours_de_ecriture();
                ecrCours.Show();


            }
            else if (Variables.counter == 1)
            {
                Variables.g = new cours_de_grammaire();
                Variables.g.cours = true;
                Variables.g.gram2 = false;
                Variables.g.Show();

            }
            else if (Variables.counter == 2)
            {
                //cmplement a 10 game

                Variables.g = new cours_de_grammaire();
                Variables.g.cours = true;
                Variables.g.gram2 = true;
                Variables.g.Show();

            }
        }

        private void PicfrEX2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //ex ecriture
                jeux_de_ecriture ecriture = new jeux_de_ecriture();
                ecriture.Show();

            }
            else if (Variables.counter == 1)
            {
                //ex gram 1
                cours_de_grammaire gram = new cours_de_grammaire();
                gram.cours = false;
                gram.gram2 = false;
                gram.Show();


            }
            else if (Variables.counter == 2)
            {
                //ex gram 2
                cours_de_grammaire gram = new cours_de_grammaire();
                gram.cours = false;
                gram.gram2 = true;
                gram.Show();

            }
        }

        private void PicfrCours3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 1)
            {
                //cours conj
                //Cours cours = new Cours();
                //cours.imageConv=cours.im
                Cours c = new Cours();
                c.conjugaison = true;
                c.Show();


            }
            else if (Variables.counter == 2)
            {
                //cours conj2
                cours_de_Conjugaison cours = new cours_de_Conjugaison();
                cours.Show();
            }
        }

        private void PicfrEX3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 1)
            {
                //ex verbes

                jeux_verbes verbes = new jeux_verbes();
                verbes.conj2 = false;
                verbes.Show();

            }
            else if (Variables.counter == 2)
            {
                jeux_verbes verbes = new jeux_verbes();
                verbes.conj2 = true;
                verbes.Show();
            }
        }

        private void PicmtCours1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            if (Variables.counter == 0)
            {
                //cours les nombres ////done
                cours_de_nombres numbersCours = new cours_de_nombres();
                numbersCours.Show();
            }
            else if (Variables.counter == 1)
            {
                cours_de_multip_div multiDivCours = new cours_de_multip_div();
                multiDivCours.Show();

            }
            else if (Variables.counter == 2)
            {
                cours_de_heure dateTimeCours = new cours_de_heure();
                dateTimeCours.Show();
            }
        }

        private void PicmtEX1_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //game les nombres ////done
                NumbersGame numbersGame = new NumbersGame();
                numbersGame.Show();
            }
            else if (Variables.counter == 1)
            {
                MultiDivGame multiDivGame = new MultiDivGame();
                multiDivGame.Show();
            }
            else if (Variables.counter == 2)
            {
                jeux_de_heure dateTime = new jeux_de_heure();
                dateTime.Show();
            }
        }

        private void PicmtCours2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                Cours cours = new Cours();
                cours.debut = 42;cours.fin = 45;
                cours.conjugaison = false;
                cours.Show();
            }
            else if (Variables.counter == 1)
            {
                cours_de_formes_geo formesCours = new cours_de_formes_geo();
                formesCours.Show();
            }
            else if (Variables.counter == 2)
            {
                cours_de_decroi_croi croidecroicours = new cours_de_decroi_croi();
                croidecroicours.Show();
            }
        }

        private void PicmtCours3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;


            if (Variables.counter == 0)
            {
                
                //cours les comparaison ////done
              

            }
            else if (Variables.counter == 1)
            {
                cours_de_moitie_double cours = new cours_de_moitie_double();
                cours.Show();
               
            }
            else if (Variables.counter == 2)
            {
                Périmetre permCours = new Périmetre();
                permCours.meilleur.Visible = false;
                permCours.panel_ex.Visible = false;
                permCours.Show();
            }
        }

        private void PicmtEX3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //game les comparaison ////done

                Jeux_de_comparaison comparaisonGame = new Jeux_de_comparaison();
                comparaisonGame.Show();
            }
            else if (Variables.counter == 1)
            {
                // moitie game
                MoitieGame moitieGame = new MoitieGame();
                moitieGame.Show();
            }
            else if (Variables.counter == 2)
            {
                Périmetre perm = new Périmetre();
                perm.panel_cours.Visible = false;
                perm.meilleur.Visible = true;
                perm.panel_ex.Visible = true;
                perm.panel_ex.BringToFront();
                perm.Show();
            }
        }

        private void PicmtCours4_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;


            if (Variables.counter == 0)
            {
                //cours les calc ////done
                Cours cours = new Cours();
                cours.debut = 36;cours.fin = 42;
                cours.conjugaison = false;
                cours.Show();
            }
            else if (Variables.counter == 1)
            {
                cours_de_fraction fractionCours = new cours_de_fraction();
                fractionCours.Show();
               
            }
            else if (Variables.counter == 2)
            {
                //complement a 10 cours --> Done
                cours_de_complement cours = new cours_de_complement();
                cours.Show();
            }
        }

        private void PicmtEX4_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                //games les calc ////done
                jeux_de_Calcule calcGame = new jeux_de_Calcule();
                calcGame.Show();
            }
            else if (Variables.counter == 1)
            {
                jeux_de_fraction fractionGame = new jeux_de_fraction();
                fractionGame.Show();
            }
            else if (Variables.counter == 2)
            {
                //cmplement a 10 game

                jeux_de_Complement complemGame = new jeux_de_Complement();
                complemGame.Show();
            }
        }

        private void PicmtEX5_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            jeux_de_Priorité prioritéGame = new jeux_de_Priorité();
            prioritéGame.Show();
        }

        private void PicmtCours5_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            //cours priorite
            Cours cours = new Cours();
            cours.debut = 33;cours.fin = 36;
            cours.conjugaison = false; cours.Show();
        }

        private void PicmtEX2_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (Variables.counter == 0)
            {
                this.ShowInTaskbar = false;
                //games suites
                jeux_de_Suites_de_nombres suitesNb = new jeux_de_Suites_de_nombres();
                suitesNb.Show();
                
            }
            else if (Variables.counter == 1)
            {
                this.ShowInTaskbar = false;
                // game formes
                jeux_de_formes_geo formes = new jeux_de_formes_geo();
                formes.Show();
                
            }
            else if (Variables.counter == 2)
            {
                // game croissante et decroissante
                this.ShowInTaskbar = false;
                jeux_de_decroi_croi decroiGame = new jeux_de_decroi_croi();
                decroiGame.Show();
                
            }
        }
    }
}
