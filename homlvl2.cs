using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Start 
{
    public partial class homlvl2 : Form
    {
        public homlvl2()
        {
            InitializeComponent(); Hom = new XmlDocument();
            Hom.Load(Application.StartupPath + @"\francais.xml"); CryptageEtHachage.DeCrypNode(Hom  .DocumentElement);
            truerep = Hom.GetElementsByTagName("homophones2")[3].InnerText.Split(',');

        }

        XmlDocument Hom; RoundButton[] lblarr = new RoundButton[10]; string trurp; string[] truerep, lbl1 = { "et", "ces", "où" }, lbl3 = { "est", "C est", "ou" }, lbl2 = { "ses", "ses", "ses" };

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            panel2.Visible = true;
            panel2.BringToFront();
            for (int i = 0; i < 10; i++)
            {
                lblarr[i] = new RoundButton();
                lblarr[i].Size = new Size(30, 30);
                lblarr[i].Location = new Point(13 + i * 30, 11);
                panel1.Controls.Add(lblarr[i]);

            }
            panel1.Visible = true;
            label4.Text = reponsess[i];
            trurp = truerep[i]; 
            label1.Text = lbl1[j];
            label2.Text = lbl2[j]; 
            label3.Text = lbl3[i];
            label1.Visible = true;
            label4.Visible = true; 
            label3.Visible = true;
            panel3.Visible = false;
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tickks++;
            if (tickks == 130) { if (lblarr[i - 1].BackColor == Color.Transparent) lblarr[i - 1].BackColor = Color.Red; tickks = 0; }

        }


        Random r = new Random(); int i = 0, j = 0, scoree = 0, tickks = 0;
        public choixMultiple choiADj = new choixMultiple();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.ShowInTaskbar = true;
            Variables.matiere.Show();
            //panel2.Visible = false; button3.Visible = button2.Visible = false; pictureBox1.Visible = false; panel1.Visible = false; try { choiADj.Dispose(); } catch (NullReferenceException) { return; };

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = button3.Visible = false;
            //choixMultiple.len = 5;
            //choixMultiple.max = 10; 
            //choiADj = new choixMultiple(); 
            //choiADj.rands = ComMethodes.Generate(5, 10); 
            //choiADj.lecon = ;
          

            choixMultiple choiADj = new choixMultiple(ComMethodes.Generate(5, 10), "gugge", panel3, 5, 10, "Francais");
            //choiADj.pan = panel3;
            choiADj.Show();
            choiADj.BringToFront();
            this.Controls.Add(choiADj); choiADj.Dock = DockStyle.Fill;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            cours_Orthographe ortho = new cours_Orthographe();
            this.Hide();
            ortho.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
            pictureBox1.Visible = true;
            button2.Visible = button3.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");


            Application.Exit();
        }

        string[] reponsess = new string[10];
        private void pan(object sender, EventArgs e)
        {
            panel2.Visible = false; pictureBox1.Visible = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.Text == trurp) { scoree += 5; lblarr[i].BackColor = Color.Green; }//sounds true iza bdna
            else lblarr[i].BackColor = Color.Red;
            suivantt();
        }

        private void suivantt()
        {
            label2.Visible = false;
            i++; j++; if (j == 3) j = 0; if (i == 10) { Thread.Sleep(20); panel2.Visible = panel4.Visible = false;  panel1.Visible = false;i = 0;j = 0;foreach (RoundButton b in lblarr) b.Dispose();  }
            else
            {
                label1.Text = lbl1[j]; label2.Text = lbl2[j]; label3.Text = lbl3[j]; label4.Text = reponsess[i]; trurp = truerep[i];
                { if (i == 1 || i == 4 || i == 7) label2.Visible = true; }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = button3.Visible = false;
            //choixMultiple.len = 5; 
            //choixMultiple.max = 10; 
            //choiADj = new choixMultiple();
            //choiADj.rands = ComMethodes.Generate(5, 10);
            //choiADj.lecon = "erEEEz";
            //choiADj.Show();
            //choiADj.BringToFront();
            //choiADj.pan = panel3;
            choixMultiple choiADj = new choixMultiple(ComMethodes.Generate(5, 10), "erEEEz", panel3, 5, 10, "Francais");
           
            choiADj.Show();
            choiADj.BringToFront();
            this.Controls.Add(choiADj);
            choiADj.Dock = DockStyle.Fill;
        }

        private void ortho_Load(object sender, EventArgs e)
        {
            InitializeComponent(); int k = 0; for (int j = 0; j < 4; j++)
            { reponsess[k] = Hom.GetElementsByTagName("homophones2")[0].InnerText.Split(',')[j]; if (j != 3) { reponsess[k + 1] = Hom.GetElementsByTagName("homophones2")[1].InnerText.Split(',')[j]; reponsess[k + 2] = Hom.GetElementsByTagName("homophones2")[2].InnerText.Split(',')[j]; k += 3; } }
            label7.Click += pan; label8.Click += pan; button1.Click += pan;

        }
    }
}
