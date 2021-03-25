using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class jeux_verbes : Form
    {
        public bool conj2 ;RoundButton[] lblarr= new RoundButton [10];
        public jeux_verbes()
        {
            InitializeComponent();
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
                XmlDocument conjugaison = new XmlDocument();
                conjugaison.Load(Application.StartupPath + @"\francais.xml"); CryptageEtHachage.DeCrypNode(conjugaison .DocumentElement);
            presentt = conjugaison.GetElementsByTagName("present"); passeCompose = conjugaison.GetElementsByTagName("passeCompose");
            passesimple = conjugaison.GetElementsByTagName("passeSimple");futursimple = conjugaison.GetElementsByTagName("futureSimple");imparfait = conjugaison.GetElementsByTagName("imparfait");
        }
            XmlNodeList presentt, passeCompose,passesimple,futursimple,imparfait,flsse,truee; XmlNodeList[] verbs = new XmlNodeList[6]; Random r = new Random(); int a, b, d, f = 0, score = 0, reponses = 0; RadioButton choisi;
            string[] sujets = { "Je/J'", "Tu", "Il_Elle", "Nous", "Vous", "Ils_Elles" };
        DataRow[] dr;
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Verbes_Load(object sender, EventArgs e)
        {
            if (conj2) { imaparfaitBtn.Visible = true; present.Text = "Passe Simple"; passeComp.Text = "Futur Simple"; }
        }

        public bool aux;

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();

            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        string trueanswr;


            private void pictureBox2_Click(object sender, EventArgs e)
            {
                { panel1.Visible = true; panel2.Visible = false; }
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void NewConj()
        {

            label1.Visible = true;
            int  sujet = r.Next(6);
            if (a == 2) verbe = r.Next(a); else try { verbe = r.Next(3,a); } catch (Exception e) { MessageBox.Show("Le temps present est choisi par defaut"); verbe = 0; };
            if (b == 0)
            {

                if (!conj2) { trueanswr = presentt[verbe].InnerText.Split(',')[sujet + 1]; truee = presentt; flsse = passeCompose; }
                else { trueanswr = passesimple[verbe].InnerText.Split(',')[sujet + 1]; flsse = futursimple; truee = passesimple; }
            }
            else if (b == 1)

            {
                if (!conj2){trueanswr = passeCompose[verbe].InnerText.Split(',')[sujet + 1]; flsse = presentt; truee = passeCompose; }
            else trueanswr = futursimple[verbe].InnerText.Split(',')[sujet + 1]; flsse = imparfait ; truee = futursimple;
            }
            else if (b == 2) {trueanswr = imparfait[verbe].InnerText.Split(',')[sujet + 1]; flsse = passesimple; truee = imparfait; }
            int[] rand = GenerateRandoms(); d = r.Next(3, 7);

                label1.Text = presentt[verbe].InnerText.Split(',')[0];
                SujetLbl.Text = sujets[sujet];
                foreach (Control c in groupBox1.Controls)
                {
                    RadioButton b1 = (RadioButton)c; if (b1.TabIndex == d) b1.Text = trueanswr;
                    else { do {if(!conj2) b1.Text = falseAnswers(trueanswr, verbe, b)[rand[f]]; else b1.Text = falseAnswers2(trueanswr, verbe, b)[rand[f]]; } while (b1.Text == trueanswr); if (f < 3) f++; }
                }
            }
        private void  rdBtn()
        {  
            Panel panel3 = new Panel(); panel3.Location = new Point(130, 160); panel3.Size = new Size(350, 100); this.Controls.Add(panel3);

            for (int i = 0; i < 10; i++)
            {
                lblarr[i] = new RoundButton(); lblarr[i].Size = new Size(30, 30);
                lblarr[i].Location = new Point(13 + i * 30, 11); panel3.Controls.Add(lblarr[i]);

            } 
        }
            private void button2_Click(object sender, EventArgs e)
        {

            rdBtn();
            reponses = 0; score = 0;
                if (present.Checked && auxilliaires.Checked) { a = 2; b = 0; }
                if (present.Checked && autres.Checked) { a = 8; b = 0; }
                if (passeComp.Checked && auxilliaires.Checked) { a = 2; b = 1; }
                if (passeComp.Checked && autres.Checked) { a = 8; b = 1; }
                if (imaparfaitBtn.Checked && auxilliaires .Checked) { a = 2; b = 2; }
                if (imaparfaitBtn.Checked && autres.Checked) { a = 8; b = 2; }
                NewConj();
                panel2.Visible = true; panel1.Visible = false;//Ê, â, ô, î et û,e, è, é, ê, ë

        }
            private void commencer1_Click(object sender, EventArgs e)
            {
            if (reponses < 10)
            {
                foreach (Control c in groupBox1.Controls) { RadioButton b = (RadioButton)c; if (b.Checked) choisi = b; }
                if (choisi.Text == trueanswr) { score += 5; lblarr[reponses].BackColor = Color.Green; } else lblarr[reponses].BackColor = Color.Red; //AddTrue sounds  else add false sounds
                reponses++; NewConj();
            }
            else
            {
                DialogResult rep = MessageBox.Show(score / 5 + @" Reponses Exactes. Voulez vous continuer?", "Courage", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (rep == DialogResult.Yes) { foreach (RoundButton r in lblarr) r.BackColor = Color.Transparent; reponses = 0; score = 0; NewConj(); }
                else
                {
                    panel1.Visible = true; panel2.Visible = false;
                    foreach (RoundButton r in lblarr) r.BackColor = Color.Transparent;
                    if (!conj2) { if ((int.Parse(dr[0]["conjugaison1"].ToString())) < score) dr[0]["conjugaison1"] = score; Variables.XmlWriter(Application.StartupPath + "\\users.xml"); }
                    else { if ((int.Parse(dr[0]["conjugaison2"].ToString())) < score) dr[0]["conjugaison2"] = score; Variables.XmlWriter(Application.StartupPath + "\\users.xml"); }
                }
            }
            }
        int verbe;
        private string[] falseAnswers2(string reponse, int a, int b)//trueChoice//verb//presOuPasse
        {
            int taille = reponse.Length; string[] choices = new string[7], term1 = { "âmes", "âtes", "iront", "îmes", "îtes", "èrent", "iront", "ais", "ait", "ions", "irez", "issent", "issons", "as", "a", "is", "it", "ssent" }; int a1 = 6, a2 = 18;
            do
            {
                choices[0] = reponse.Remove(taille - 1) + term1[r.Next(18)]; choices[1] = flsse[r.Next(1, 8)].InnerText.Split(',')[r.Next(1, 6)].ToString();
                choices[5] = reponse.Remove(taille - 1) + term1[r.Next(18)];
                choices[2] = truee[r.Next(1, 8)].InnerText.Split(',')[r.Next(6)].ToString();
            } while (choices[0] == trueanswr || choices[1] == trueanswr || choices[2] == trueanswr || choices[3] == trueanswr);


            if (b == 0) { choices[3] = truee[verbe ].InnerText.Split(',')[r.Next(6)].ToString(); choices[4] = truee[verbe ].InnerText.Split(',')[r.Next(6)].ToString(); }
            else { choices[3] = flsse[verbe ].InnerText.Split(',')[r.Next(6)].ToString(); choices[4] = flsse[verbe ].InnerText.Split(',')[r.Next(6)].ToString(); }
            return choices;
        }
        private string[] falseAnswers(string reponse, int a, int b)//trueChoice//verb//presOuPasse
        {
            int taille = reponse.Length; string[] choices = new string[5], term = { "ons", "ez", "ent", "ions", "iez", "issez", "es" };
            do
            {
                choices[0] = reponse.Remove(taille - 1) + term[r.Next(6)]; choices[1] = presentt[r.Next(1, 8)].InnerText.Split(',')[r.Next(1, 6)].ToString();
                choices[2] = passeCompose[r.Next(1, 8)].InnerText.Split(',')[r.Next(6)].ToString();
            } while (choices[0] == trueanswr || choices[1] == trueanswr || choices[2] == trueanswr || choices[3] == trueanswr);


            if (b == 0) { choices[3] = presentt[a].InnerText.Split(',')[r.Next(6)].ToString(); choices[4] = presentt[a].InnerText.Split(',')[r.Next(6)].ToString(); }
            else { choices[3] = passeCompose[a].InnerText.Split(',')[r.Next(6)].ToString(); choices[4] = passeCompose[a].InnerText.Split(',')[r.Next(6)].ToString(); }
            return choices;
        }
        private int[] GenerateRandoms()
            {
                int[] rand = new int[4];
                do
                {
                    for (int i = 0; i < 4; i++) rand[i] = r.Next(5);

                } while (rand[1] == rand[2] || rand[2] == rand[3] || rand[3] == rand[0] || rand[2] == rand[0] || rand[1] == rand[0]);
                return rand;

            }

        }
    
    }

