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

namespace Start
{
    public partial class cours_de_grammaire : Form
    {
       public static  int dest;
        Random r = new Random();
        binding binding2 = new binding();
        XmlDocument gram;
     
        public bool cours, gram2=false;
        public static int[] scores = new int[10];
        public cours_de_grammaire()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gram = new XmlDocument(); 
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            gram.Load(Application.StartupPath + @"\Gramm.xml");
            if (gram2) panel2.Visible = true;
            if (!cours) 
            {  
                button11.Click += lvl1_grams
                    ; button3.Click += lvl1_grams; 
                button4.Click += lvl1_grams; 
                button7.Click += lvl1_grams; 
                button6.Click += lvl1_grams; 
                button9.Click += lvl1_grams;
            }
            CryptageEtHachage.DeCrypNode(gram.DocumentElement);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            
            
            panconv = panel2; if (!cours) pictureBox1.Visible = true;
            else
            {
                Cours cf = new Cours();
                
                cf.debut = 31;cf.fin = 33;cf.Show();
        }
            
        }

        private void button4_Click(object sender, EventArgs e)
        { panconv = panel1; if (!cours) pictureBox1.Visible = true;
            else
            {
                Cours cf = new Cours();

                cf.debut = 27; cf.fin = 29; cf.Show();

            }
           
        }

    

        private void button7_Click(object sender, EventArgs e)
        {
            panconv = panel1;if(!cours) pictureBox1.Visible = true;
            else
            {
                Cours cf = new Cours();
                
                cf.debut = 17; cf.fin = 19; cf.Show();

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panconv = panel1;if(!cours) pictureBox1.Visible = true;
            else
            {
                Cours cf = new Cours();
                cf.debut = 15; cf.fin = 17; cf.Show();

                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            
        }
        private void button9_Click(object sender, EventArgs e)
        {
            panconv = panel1;if(!cours) pictureBox1.Visible = true;
            else
            {
               
                Cours cf = new Cours();cf.conjugaison = false;
                cf.debut = 22; cf.fin = 27; cf.Show();
            }
        }
        private void lvl1_grams(object sender, EventArgs e)
        {
            Button lb = (Button)sender; binding2.Dispose();

            panel1.Hide(); panel2.Visible = false;
            int a = int.Parse(lb.Tag.ToString().Split(',')[0]), b = int.Parse(lb.Tag.ToString().Split(',')[1]);
            binding2 = new binding(lb.Tag.ToString().Split(',')[5], int.Parse(lb.Tag.ToString().Split(',')[3]), int.Parse(lb.Tag.ToString().Split(',')[2]), panconv, ComMethodes.Generate(a, b)); userconv = binding2;
            //binding2.rand = ComMethodes.Generate(a, b); binding2.dest = int.Parse(lb.Tag.ToString().Split(',')[3]);
            //binding2.depart = int.Parse(lb.Tag.ToString().Split(',')[2]); binding2.lecon = lb.Tag.ToString().Split(',')[5]; binding2.Location = new Point(200, 150);binding2.panl = panconv;
            binding2.Location = new Point(200, 150); this.Controls.Add(binding2);
            userconv.Visible = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            panconv = panel1;if (!cours)
            {
                pictureBox1.Visible = true;
                panel1.Hide(); panel2.Hide();
                encadrerEntourer enen = new encadrerEntourer(); userconv = enen; userconv.Visible = true; enen.Dock = DockStyle.Fill; this.Controls.Add(enen);
            }
            else
            {
                Cours cf = new Cours(); cf.conjugaison = false;
                cf.debut = 20; cf.fin = 22; cf.Show();
            }
        }
        Panel panconv;
        private void button10_Click(object sender, EventArgs e)
        {
            panconv = panel2;
            if (!cours)
            {
                panel1.Hide(); panel2.Hide();
                pictureBox1.Visible = true; 
                panel1.Hide(); panel2.Hide(); phraseoEx ep = new phraseoEx(); userconv = ep; userconv.Visible = true; this.Controls.Add(ep); ep.Dock = DockStyle.Fill;
                ep.Show(); pictureBox1.BringToFront();
            }
            else
            {
                Cours cf = new Cours(); cf.conjugaison = false;
                cf.debut = 1;cf.fin = 5;cf.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            panconv = panel2;if(!cours) pictureBox1.Visible = true;
            else
            {
                Cours cf = new Cours();cf.conjugaison = false;
                cf.debut = 5; cf.fin = 7;cf.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panconv = panel2; 
            panel1.Hide();
            panel2.Hide();
            if (!cours)
            {
                pictureBox1.Visible = true; 
                choixMultiple choiprn = new choixMultiple(ComMethodes.Generate(6, 10), "Posses", panconv, 6, 10, "Francais");
               

                userconv = choiprn;
                userconv.Visible = true;
                choiprn.Show();
                choiprn.BringToFront();
                this.Controls.Add(choiprn);
                choiprn.Dock = DockStyle.Fill;
                pictureBox1.BringToFront();
            }
            else
            {
                Cours cf = new Cours();
                cf.conjugaison = false;
                cf.debut = 29;
                cf.fin = 31;
                cf.Show();

            }
        }
       UserControl  userconv;
        private void button14_Click(object sender, EventArgs e)
        {
            panconv = panel1;
            panel1.Hide();
            panel2.Hide();
            if (!cours) 
            {
               
                choixMultiple choiADj = new choixMultiple(ComMethodes.Generate(7, 10), "Adjectifs", panconv, 7, 10, "Francais");
                
                userconv = choiADj;
                userconv.Visible = true;
                choiADj.Show();
                choiADj.BringToFront();
                this.Controls.Add(choiADj); 
                choiADj.Dock = DockStyle.Fill;
                pictureBox1.BringToFront();
            }
            else
            {
                
                Cours cf = new Cours();
                cf.conjugaison = false;
                cf.debut = 7;
                cf.fin = 15;
                cf.Show();

            }
        }
        Bitmap b = new Bitmap(Application.StartupPath + @"/Pics/Francais/BackPro.jpg");

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
            this.BackgroundImage= b;
        }
        int scoreTotal1,scoreTotal2;DataRow []dr;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) scoreTotal1 += scores[i];
            
            for (int i = 0; i < 5; i++) scoreTotal2 += scores[i];
            
            if (scoreTotal1 > int.Parse(dr[0]["SingulierOuPluriel"].ToString()))
            {
                dr[0]["SingulierOuPluriel"] = scoreTotal1;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            if (scoreTotal2 > int.Parse(dr[0]["Grammaire21"].ToString()))
            {
                dr[0]["Grammaire21"] = scoreTotal2;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            }
            this.Close();
            Variables.matiere.ShowInTaskbar = true;
            Variables.matiere.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panconv.Visible = true;
            userconv.Hide(); 
            this.BackgroundImage = b;
            pictureBox1.Visible = false;
        }

        
    }
}
