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
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Start
{
    public partial class Page_entrée : Form
    {

        public Page_entrée()
        {
            InitializeComponent();
            removeBG(txtIcon, usericon);
            removeBG(txtIcon2, pass1);
        }
       
        void removeBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;

            // this code for make textbox icons background transparent
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string txt = UserTxt.Text;
            if (txt.Equals("Votre nom d'utilisateur"))
            {
                UserTxt.Text = string.Empty;
            }
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            wrongData.Visible = false;
            motcle.Visible = false;
            motclefaux.Visible = false;
           
            if (PassTxt.Text.Equals("Votre mot clé"))
            {
                PassTxt.Text = "";
            }

            PassTxt.UseSystemPasswordChar = true;
        }
         DataSet ds;
        DataTable dt;
        private void FormLogin_Load(object sender, EventArgs e)
        {
           ds = new DataSet();
           ds.ReadXml(Application.StartupPath + "\\users.xml");
           
            dt = ds.Tables["Users"];  
        }
        public static string nom=string.Empty;
        DataRow[] dr;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //zmouseClickButton.Play();

            if ((UserTxt.Text.Length > 0)&& UserTxt.Text!="Votre nom d'utilisateur")
            {

                if (PassTxt.Text.Length > 0)
                    dr = dt.Select("(([user] = '" + CryptageEtHachage.HashPasswordsAndScores(UserTxt.Text )+ "') AND ([pass] = '" + CryptageEtHachage.HashPasswordsAndScores(PassTxt.Text) + "'))");
               if (panel1.Visible == true )
                {
                    dr = dt.Select("(([user] = '" +CryptageEtHachage.HashPasswordsAndScores( UserTxt.Text) + "'))");
                    if (dr.Length == 1)
                    {
                        if (nomText.Text != dr[0]["nom"].ToString()) { InfoFlse.Visible = true; return; }
                        else
                        {
                            panel1.Visible = false; 
                            PassTxt.Text = dr[0]["pass"].ToString();
                        }
                    }else
                    {
                        InfoFlse.Visible = true;return; 
                    }
                }
                if(PassTxt.Text.Length <0)
                { motcle.Visible = true; return; }

                if (dr.Length == 1)
                {
                    
                    Variables.intro = new Introduction();
                    Variables.matiere = new MatiereStart();
                    intro_video intro_ = new intro_video();
                    intro_.Show();

                    if ((CryptageEtHachage.Combine(dr[0]["genre"].ToString())== "mâle") && (CryptageEtHachage.Combine(dr[0]["Type"].ToString()) == "Eleve"))
                    {
                        Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\boy.png");
                        Variables.intro.userphoto.Image = Variables.B;


                    }
                    else if((CryptageEtHachage.Combine(dr[0]["genre"].ToString()) == "femelle") && (CryptageEtHachage.Combine(dr[0]["Type"].ToString())== "Eleve"))
                    {

                        Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\girl.png");
                        Variables.intro.userphoto.Image = Variables.B;


                    }
                    else if ((CryptageEtHachage.Combine(dr[0]["genre"].ToString()) == "mâle")&&(CryptageEtHachage.Combine(dr[0]["Type"].ToString())== "Prof"))
                    {

                        Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\administrator_male.png");
                        Variables.intro.userphoto.Image = Variables.B;


                    }
                    else if ((CryptageEtHachage.Combine(dr[0]["genre"].ToString())== "femelle")&&(CryptageEtHachage.Combine(dr[0]["Type"].ToString())== "Prof"))
                    {
                        Variables.B = new Bitmap(Application.StartupPath + "\\Pics\\woman_profile.png");
                        Variables.intro.userphoto.Image = Variables.B;

                    }


                 
                    this.ShowInTaskbar = false;

                    Variables.exSup = dr[0]["exSupp"].ToString().Split(',');
                    
                    Variables.UserNom = UserTxt.Text;
                    Variables.UserPass = PassTxt.Text;
                    Variables.intro.username.Text = Variables.UserNom;
                    this.Hide();


                }
                else wrongData.Visible = true;
                
            }

            if (PassTxt.Text == "") motcle.Visible = true; 

            
        }
            

        private void label4_Click(object sender, EventArgs e)
        {
          //  mouseClickButton.Play();
            page_Registration registration = new page_Registration();
            registration.Show();
            // this.Hide();
            this.ShowIcon = false;
        }

        private void ClearBoxes()
        {
            UserTxt.Clear();
            PassTxt.Clear();
        }



        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
            wrongData.Visible = false;
            if (PassTxt.Text == "")
            {
                motcle.Visible = true;
            }
            else motcle.Visible = false;

            wrongData.Visible = false ;
        }


        private void hide_Click(object sender, EventArgs e)
        {
            if (PassTxt.UseSystemPasswordChar == false)
            {
                show.BringToFront();
                PassTxt.UseSystemPasswordChar = true;
            }
        }
         private void show_Click(object sender, EventArgs e)
        {
            if (PassTxt.UseSystemPasswordChar == true)
            {
                hide.BringToFront();
                PassTxt.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {
            if (UserTxt.Text == "")
            {
                nomuti.Visible = true;
            }
            else nomuti.Visible = false;
            wrongData.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ForgetPass_Click(object sender, EventArgs e)
        {
            if (UserTxt.Text != null) { panel1.Visible = true; panel1.BringToFront(); }
        }

        private void nomText_TextChanged(object sender, EventArgs e)
        { InfoFlse.Visible = false;
            if (nomText.Text == "") label1.Visible = true;
            else label1.Visible =false ;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;nomText.Text  = "Entrer votre nom";
        }

        private void nomText_MouseClick(object sender, MouseEventArgs e)
        {
            if (nomText.Text == "Entrer votre nom") nomText.Text = "";label1.Visible = true;
        }

        private void UserTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) PassTxt.Focus();
        }

        private void PassTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();

        }

        private void Page_entrée_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }

    
}


