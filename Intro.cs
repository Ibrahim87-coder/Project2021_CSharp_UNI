using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Start
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        AxWMPLib.AxWindowsMediaPlayer mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();

        DataRow[] dr;
        enum lecons

        {
            Conjugaison1, Conjugaison2, Grammaire1, Grammaire2, Orthographe, Nombres, AdditionEtSousrtaction, SuitesDenombres, Moitieetdouble, MultiDivision, Fractions, CroissantEtDecroissant, Priorite, Perimetre, FormesGeometriques, Clock, sens, livingorno, planetes

        }XmlDocument prof = new XmlDocument();int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            CryptageEtHachage.CombineUsersElements(CryptageEtHachage.HashPasswordsAndScores(Variables.UserNom),CryptageEtHachage.HashPasswordsAndScores( Variables.UserPass), Application.StartupPath + "\\users.xml");
            // Audio manzu3 hek wahdu
            prof.Load(Application.StartupPath + "\\Prof.xml");
            if (Variables.ExisteMessage(Variables.UserNom)) pictureBox2.Image = Properties.Resources.newMsg;
            for (lecons lcs = lecons.Conjugaison1; lcs < lecons.Clock; lcs++)
            {

                prof.Load(Application.StartupPath + "\\Prof.xml");

                if ((int)lcs < 5) { if (Variables.exSup[i] != prof.SelectSingleNode("Prof/Francais/" + lcs + " / Questions").InnerText.Split(',').Length.ToString()) { Suppex.Image = Properties.Resources.newASsignment; break; }; i++; }
                else  if ((int)lcs < 16){ if (Variables.exSup[i] != prof.SelectSingleNode("Prof/Maths/" + lcs + "/Questions").InnerText.Split(',').Length.ToString()) { Suppex.Image = Properties.Resources.newASsignment; break; }; i++; }
              else  {if (Variables.exSup[i] != prof.SelectSingleNode("Prof/Sciences/" + lcs + "/Questions").InnerText.Split(',').Length.ToString()) { Suppex.Image = Properties.Resources.newASsignment; break; }; i++; }
            }
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            Variables.exSup = dr[0]["exSupp"].ToString().Split(',');

            if ((string)dr[0]["Type"] == "Prof")

            {

                Suppex.Visible = false;
                addFile.Visible = true;
            }
            else
            {
                addFile.Visible = false;
                Suppex.Visible = true;
            }

            mediaplayer.CreateControl();
            mediaplayer.URL = Application.StartupPath + "\\Sounds\\Intro0.m4a";
            mediaplayer.Ctlcontrols.play();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            mediaplayer.URL = Application.StartupPath+ @"Sounds/Intro0.m4a";
            mediaplayer.Ctlcontrols.play();
            btnON.BringToFront();
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            mediaplayer.URL = Application.StartupPath + @"Sounds/Intro0.m4a";
            mediaplayer.Ctlcontrols.pause();
            btnOff.BringToFront();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");



            Application.Exit();
        }

        private void MathsOpen_Click(object sender, EventArgs e)
        {
           
            Variables.MatiereNomPublic = "MT";
            Variables.counter = 0;
            this.Hide();

            Variables.matiere = new MatiereStart();
            Variables.matiere.userphoto.Image = Variables.B;
            Variables.matiere.username.Text = Variables.UserNom;
            Variables.matiere.Show();
            this.ShowInTaskbar = false;

        }

        private void francaisOpen_Click(object sender, EventArgs e)
        {
            Variables.MatiereNomPublic = "FR";
            this.Hide();
            Variables.counter = 0;

            Variables.matiere = new MatiereStart();
            Variables.matiere.userphoto.Image = Variables.B;
            Variables.matiere.username.Text = Variables.UserNom;
            Variables.matiere.Show();

            this.ShowInTaskbar = false;

        }

        private void ScienceOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.science = new ScienceStart();
            Variables.science.userphoto.Image = Variables.B;
            Variables.science.username.Text = Variables.UserNom;
            Variables.science.Show();
            this.ShowInTaskbar = false;
        }

        private void JeuxOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.Jeux = new Jeux();
            Variables.Jeux.userphoto.Image = Variables.B;
            Variables.Jeux.username.Text = Variables.UserNom;
            Variables.Jeux.Show();

            this.ShowInTaskbar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");
            Variables.formLogin = new Page_entrée();
            Variables.formLogin.Show(); 

            this.Close();
            Variables.formLogin.ShowInTaskbar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            exSupp exSupp = new exSupp();
            exSupp.Show();
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            addEx add = new addEx();
            add.Show();
        }

        private void Introduction_FormClosed(object sender, FormClosedEventArgs e)
        {

           // CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Variables.m = new Message();
            Variables.m.Show();
        }
    }
}
