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
    public partial class exSupp : Form
    {
        public exSupp()
        {
            InitializeComponent();
        }


        Panel panconv;XmlDocument prof;DataSet ds = new DataSet();
        private void roundButton3_Click_1(object sender, EventArgs e)
        {
            Button r = (Button)sender;
            r.BackColor = SystemColors.Info; Variables.exSup[int.Parse(r.Tag.ToString())]= prof.GetElementsByTagName(r.Name)[0].InnerText.Split(',').Length.ToString();

            if (prof.GetElementsByTagName(r.Name)[0].InnerText != "0")
            {
                var len = prof.GetElementsByTagName(r.Name)[0].InnerText.Split(',').Length; 
                var max = prof.GetElementsByTagName(r.Name)[0].InnerText.Split(',').Length; 
                //choixMultiple choiprn = new choixMultiple(); 
                //choiprn.xmlFile = "Prof"; 
                //choiprn.pan = panconv;
                //choiprn.rands = ComMethodes.Generate(choixMultiple.len, choixMultiple.max);
                //choiprn.lecon = r.Name;
                //choiprn.Show(); 
                
                //choiprn.BringToFront();

                choixMultiple choiprn = new choixMultiple(ComMethodes.Generate(len, max), r.Name, panconv, len, max, "Prof");
                this.Controls.Add(choiprn);
                choiprn.Dock = DockStyle.Fill;
                choiprn.BringToFront();
            }
            else 
            {
                panel2.Visible = true;
                panel2.BringToFront();
                pictureBox2.Visible = false; 
            }
        }
        int[] exNombres= new int[19];
      Button [] b= new Button [19];
        enum lecons

        {
            Conjugaison1,Conjugaison2,Grammaire1,Grammaire2,Orthographe,Nombres, AdditionEtSousrtaction, SuitesDenombres,Moitieetdouble, MultiDivision, Fractions,CroissantEtDecroissant,Priorite,Perimetre,FormesGeometriques,Clock,sens,livingorno,planetes

        }
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\Users.xml");

            if(Variables.levelmt!=2 && Variables.levelmt != 3)
            {
                Variables.levelmt = 1;
            }
            if (Variables.levelmt == 1)
            {
                panelMt1.Visible = true;
                panelMt2.Visible = false;
                panelMt3.Visible = false;

                panelMt1.Parent = panel1;
                panelMt1.Location = new Point(35, 35);
               
                panelMt1.BringToFront();

            }
            else if (Variables.levelmt == 2)
            {

                panelMt1.Visible = false;
                panelMt2.Visible = true;
                panelMt3.Visible = false;

                panelMt2.Location = new Point(5, 5);
                panelMt2.Parent = panel1;
                panelMt2.BringToFront();
            }
            else if (Variables.levelmt == 3)
            {

                panelMt1.Visible = false;
                panelMt2.Visible = false;
                panelMt3.Visible = true;

                panelMt3.Location = new Point(5, 5);
                panelMt3.Parent = panel1;
                panelMt3.BringToFront();
            }

            ///////////////////////////////////////

            if (Variables.levelfr == 1)
            {
                panelFr1.Visible = false;
                panelFr2.Visible = false;
            }else if (Variables.levelfr == 2)
               {

                panelFr1.Visible = true;
                panelFr2.Visible = false;
               
               }
            else if (Variables.levelfr == 3)
            {
                panelFr1.Visible = false;
                panelFr2.Visible = true;
            }
            b[0] =Conjugaison1;b[1] = Conjugaison2 ;b[2] =Grammaire1  ;b[3] = Grammaire2;b[4] = Orthographe;b[5] = Nombres; b[6] = AdditionEtSousrtaction   ; b[7] = SuitesDenombres; b[8] = Moitieetdouble;
            b[9] = MultiDivision;b[10] = Fractions;b[11] = CroissantEtDecroissant;b[12] = Priorite;b[13] = Perimetre;b[14] = FormesGeometriques;b[15] = Clock;b[16] = sens;b[17] = livingorno;b[18] = planetes;
            panconv = panel1;
            prof = new XmlDocument(); 
            prof.Load(Application.StartupPath + "\\Prof.xml");
            
            for (lecons lcs = lecons.Conjugaison1; lcs < lecons.Clock; lcs++)
            {
                if (Variables.exSup[i] != prof.GetElementsByTagName(lcs.ToString())[0].InnerText.Split(',').Length.ToString())
                {
                    b[(int)lcs].BackColor = Color.Green;
                }
                i++;
            } 
        }

        string exercices;DataRow[] dr;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 19; i++) exercices += Variables.exSup[i] + ","; exercices = exercices.Remove(exercices.LastIndexOf(',')); dr[0]["exSupp"] = exercices; Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            this.Close();
            Variables.intro.Suppex.Image = Properties.Resources.assignment;
            Variables.intro.Show();
            Variables.intro.ShowInTaskbar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false; 
            pictureBox2.Visible = true;
        }
    }
}
