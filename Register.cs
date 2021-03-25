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
    public partial class page_Registration : Form
    {
        public page_Registration()
        {
            InitializeComponent();


        }
        
        private void bunifuThinButton21_KeyDown(object sender, KeyEventArgs e)
        {

        }

        DataSet ds;
        DataTable dt;

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\users.xml");
            dt = ds.Tables["users"];

            if (radioBtnEleve.Checked == true) Datepicker.Show();
            else Datepicker.Hide();
        }






        private void radioBtnEleve_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnEleve.Checked == true) Datepicker.Visible = true;
            else Datepicker.Visible = false;
        }

        private void Confpass_MouseClick(object sender, MouseEventArgs e)
        {
           // string confpass = Confpass.Text;
            if (Confpass.Text.Equals("Confirmer Votre mot"))
            {
                Confpass.Text = "";
            }
        }

        private void PassTxt_MouseClick(object sender, MouseEventArgs e)
        {
           // string pass = PassTxt.Text;
            if (PassTxt.Text.Equals("Votre mot clé"))
            {
                PassTxt.Text = "";
            }
        }
        private void NomTxt_MouseClick(object sender, MouseEventArgs e)
        {
           // string nom = NomTxt.Text;
            if (NomTxt.Text.Equals("Votre nom"))
            {
                NomTxt.Text = "";
            }
        }

        private void usertxt_MouseClick(object sender, MouseEventArgs e)
        {
            string nomutilisateur = usertxt.Text;
            if (nomutilisateur.Equals("Nom utilisateur"))
            {
                usertxt.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            //Variables.formLogin.Show();
            //Variables.formLogin.ShowInTaskbar = true;
            
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            genreq.Visible = false;

            if ((male.Checked == true) && (radioBtnEleve.Checked == true))
            {
                nom.BackColor = Color.White;
                user.BackColor = Color.White;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\boy.png");
                nom.Image = bitmap;
                user.Image = bitmap;
                

            }
            else if((male.Checked == true) && (radioBtnEleve.Checked == false))
            {
                nom.BackColor = Color.White;
                user.BackColor = Color.White;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\administrator_male.png");
                nom.Image = bitmap;
                user.Image = bitmap;
                

            }

        }

        private void femelle_CheckedChanged(object sender, EventArgs e)
        {
            genreq.Visible = false;

            if ((femelle.Checked == true)&& (radioBtnProf.Checked==false))
            {
                nom.BackColor = Color.White;
                user.BackColor = Color.White;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\girl.png");
                nom.Image = bitmap;
                user.Image = bitmap;

            }
            else  if((femelle.Checked == true) && (radioBtnProf.Checked == true))
                {
                    nom.BackColor = Color.White;
                    user.BackColor = Color.White;
                    Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\woman_profile.png");
                    nom.Image = bitmap;
                    user.Image = bitmap;
                }
            
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
            if (PassTxt.Text == "")
            {
                motclereg.Visible = true;
            }
            else motclereg.Visible = false;
        }

        private void Confpass_TextChanged(object sender, EventArgs e)
        {

            if (Confpass.Text == "")
            {
                conf.Visible = true;

            } else
            {
                conf.Visible = false;
                if (Confpass.Text != PassTxt.Text)
                {
                    wrongpass.Visible = true;
                }
                else wrongpass.Visible = false;

            }

        }
        public int age;
        private void btnconf_Click(object sender, EventArgs e)
        {

            //check for nom textbox if empty or not
            if (NomTxt.Text == "" || NomTxt.Text == "Votre nom")
            {
                wrongnom.Visible = true;
            }
            else wrongnom.Visible = false;

            //check for user textbox if empty or not

            if (usertxt.Text == "" || usertxt.Text == "Nom utilisateur")
            {
                wronguser.Visible = true;

            }
            else wronguser.Visible = false;

            //check for password textbox if empty or not

            if (PassTxt.Text == "" || PassTxt.Text == "Votre mot clé")
            {
                motclereg.Visible = true;
            }
            else motclereg.Visible = false;

            //check for password second time textbox if empty or not

            if (Confpass.Text == "" || Confpass.Text == "Confirmer Votre mot")
            {
                conf.Visible = true;
            }
            else conf.Visible = false;

            // check for type de l'utilisateur
            if ((radioBtnEleve.Checked == false) && (radioBtnProf.Checked == false))
            {
                typeq.Visible = true;
            }
            else 
            {
                typeq.Visible = false;

                if (radioBtnEleve.Checked == true)
                {
                    Variables.Type = false;

                }else  Variables.Type = true;
            } 

            //check for genre

            if ((male.Checked == false) && (femelle.Checked == false))
            {
                genreq.Visible = true;
            }
            else genreq.Visible = false;

            // il faut l'eleve de 5 ans et plus
            if (((2021 - Datepicker.Value.Year) < 5) && radioBtnEleve.Checked==true)
            {
                dateq.Visible = true;
            }

            else
            {
                if ((radioBtnEleve.Checked==false)||(radioBtnProf.Checked==false)||(male.Checked==false)||(femelle.Checked==false)) 
                {
                    dateq.Visible = false;

                    if ((usertxt.Text.Length > 0) && (PassTxt.Text.Length > 0) && (usertxt.Text != "Nom utilisateur") && (PassTxt.Text != "Votre mot clé"))
                    {
                        DataRow[] dr = dt.Select("(([user] = '" + usertxt.Text + "') AND ([pass] = '" + PassTxt.Text + "'))");
                        DataRow[] deja = dt.Select("(([user] = '" +CryptageEtHachage.HashPasswordsAndScores( usertxt.Text) + "') AND ([nom] = '" +CryptageEtHachage.HashPasswordsAndScores( NomTxt.Text) + "'))");

                        if (deja.Length == 1)
                        {
                            utilisateurDeja.Visible = true;

                        }
                        else
                        {
                            utilisateurDeja.Visible = false;
                            dateq.Visible = false;

                            DataRow dr2 = dt.NewRow();
                            dr2[0] = usertxt.Text;
                            dr2[1] = PassTxt.Text;
                            dr2[2] = NomTxt.Text;
                            dr2[3] = 2021 - Datepicker.Value.Year;

                            if (Variables.Type == false)
                            {
                                dr2[5] = "Eleve";
                            }
                            else
                            {
                                dr2[5] = "Prof";
                            }
                            if (male.Checked == true) dr2[4] = "mâle";
                            else dr2[4] = "femelle";

                            // set les scores = 0
                            for (int i = 6; i < 39; i++)
                            {
                                dr2[i] = 0;
                            }
                            dr2[23] = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
                            dr2[38] = 60; //metre la meilleur score 60 s dans la jeux de suites de nbss

                            dt.Rows.Add(dr2);
                            ds.WriteXml(Application.StartupPath + "\\users.xml");
                            CryptageEtHachage.HashXmlUsers(usertxt.Text, PassTxt.Text, Application.StartupPath + "\\users.xml");
                            this.ShowInTaskbar = false;
                           

                            Variables.intro = new Introduction();
                            

                            intro_video intro_Video = new intro_video();
                            intro_Video.Show();



                            if ((dr2[4].ToString() == "mâle") && (Variables.Type = false))
                            {

                                Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\boy.png");
                                Variables.intro.userphoto.Image = Variables.B;

                            }
                            else if ((dr2[4].ToString() == "femelle") && (Variables.Type = false))
                            {

                                Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\girl.png");
                                Variables.intro.userphoto.Image = Variables.B;

                            }
                            else if ((dr2[4].ToString() == "mâle") && (Variables.Type = true))
                            {
                                Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\administrator_male.png");
                                Variables.intro.userphoto.Image = Variables.B;

                            }
                            else if ((dr2[4].ToString() == "femelle") && (Variables.Type = true))
                            {
                                Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\woman_profile.png");
                                Variables.intro.userphoto.Image = Variables.B;

                            }

                            Variables.exSup = dr2[23].ToString().Split(',');
                            Variables.intro.userphoto.Image = Variables.B;
                            Variables.UserNom = usertxt.Text;
                            Variables.UserPass = PassTxt.Text;
                            Variables.intro.username.Text = Variables.UserNom;
                            this.Hide();


                        }
                    }
                    else if ((usertxt.Text.Length > 0) && (((PassTxt.Text.Length == 0) || (PassTxt.Text == "Votre mot clé")) || ((Confpass.Text.Length == 0) || (Confpass.Text == "Confirmer Votre mot"))))
                    {
                        motclereg.Visible = true;
                        conf.Visible = true;
                        if ((PassTxt.Text != Confpass.Text))
                        {
                            wrongpass.Visible = true;
                            conf.Visible = false;

                        }
                        else wrongpass.Visible = false;

                    }
                }

               
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                wronguser.Visible = true;
            }
            else wronguser.Visible = false;
        }

        private void NomTxt_TextChanged(object sender, EventArgs e)
        {
            if (NomTxt.Text == "")
            {
                wrongnom.Visible = true;
            }
            else wrongnom.Visible = false;
        }

        private void NomTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) usertxt.Focus();
        }

        private void usertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) PassTxt.Focus();
        }

        private void Confpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Confpass.Focus();
        }

        private void page_Registration_KeyDown(object sender, KeyEventArgs e)
        {
            if(usertxt.Text!="" && usertxt.Text!= "Nom utilisateur"
            && PassTxt.Text!="" && PassTxt.Text != "Votre mot clé"
            && Confpass.Text!="" && Confpass.Text!= "Confirmer Votre mot"
            && NomTxt.Text!="" && NomTxt.Text != "Votre nom")
            {
                if (e.KeyCode == Keys.Enter) btnconf.PerformClick();
            }
           
        }
    }
}
 