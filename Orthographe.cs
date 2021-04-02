using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Start 
{
    public partial class cours_Orthographe : Form
    {
        public cours_Orthographe()
        {
            InitializeComponent();

            XmlDocument conjugaison = new XmlDocument();
            conjugaison.Load(Application.StartupPath + @"\francais.xml");CryptageEtHachage.DeCrypNode(conjugaison.DocumentElement);
            TrueAnswers = conjugaison.GetElementsByTagName("TrueHom")[0].InnerText.Split(',');
            FalseAnswers = conjugaison.GetElementsByTagName("FalseHom")[0].InnerText.Split(',');
        }
        Random r = new Random(); int ticks = 0, p = 0, score = 0; RoundButton [] lblarr = new RoundButton [10];
        string[] TrueAnswers, FalseAnswers; int[] randoms;string reponse;
        private int[] GenerateRandoms()
        {
            int[] randoms = new int[10];
            do { for (int i = 0; i < 10; i++) randoms[i] = r.Next(20); }
            while (randoms[1] == randoms[2] || randoms[2] == randoms[3] ||
                   randoms[3] == randoms[4] || randoms[4] == randoms[5] ||
                   randoms[5] == randoms[6] || randoms[6] == randoms[7] ||
                   randoms[7] == randoms[8] || randoms[9] == randoms[0] ||
                   randoms[3] == randoms[8] || randoms[4] == randoms[7] || 
                   randoms[0] == randoms[1] || randoms[0] == randoms[4] ||
                   randoms[6] == randoms[2] || randoms[5] == randoms[1] ||
                   randoms[6] == randoms[8] || randoms[0] == randoms[8] ||
                   randoms[3] == randoms[0] || randoms[2] == randoms[4] ||
                   randoms[3] == randoms[5]);
            return randoms;
        }
        string[] TrueFalse(out string[] deux)
        {
            int c = r.Next(2);
            if (c == 1) { deux = TrueAnswers; return FalseAnswers; }
            else deux = FalseAnswers; return TrueAnswers;

        }
      
        private void label2_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender; 
            if (l.Text == reponse ) { score += 5; lblarr[p-1].BackColor = Color.Green; }//sounds true iza bdna
            else lblarr[p - 1].BackColor = Color.Red  ;
            reponse=suivant();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();;hom.Show();
        }
        homlvl2   hom = new homlvl2  ();
        DataRow[] dr;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            dr[0]["orthographe"] = score;
            Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            this.Close();
            hom.Show();
          
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randoms = GenerateRandoms(); timer1.Start(); reponse=suivant();
            for(int i=0;i<10;i++)
            {
                lblarr[i] = new RoundButton ();lblarr[i].Size = new Size(30, 30);
                lblarr[i].Location = new Point (13 + i * 30, 11);panel1.Controls.Add(lblarr[i]);
            }

        }
        private string suivant()
        {
            if (p == 10) {this.Close();hom.Show(); return ""; } 
            int b = randoms[p];
            p++; pictureBox1.Image = imageList1.Images[b]; label1.Text = TrueFalse(out string[] choix)[b]; label2.Text = choix[b];
            return TrueAnswers[b];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++; 
            if (ticks == 130) { if (lblarr[p-1].BackColor == Color.Transparent) lblarr[p-1].BackColor = Color.Red; reponse = suivant();ticks = 0;}
         }
    }
}
