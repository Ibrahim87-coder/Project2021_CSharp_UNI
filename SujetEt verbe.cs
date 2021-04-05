using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Start
{
    public partial class encadrerEntourer : UserControl
    {
        public encadrerEntourer()
        {
            InitializeComponent();//dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            pictureBox1.AllowDrop = true; pictureBox2.AllowDrop = true;
        }
        List<string> mots = new List<string>(); SoundPlayer reussi = new SoundPlayer(@"Voix\lvl Up.wav"), wrong = new SoundPlayer(@"Voix\fail.wav");
        Label[] motsLabels; string s; XmlDocument gram;
        ArrayList ar;
        // static bool dessCarre = false, dessRond = false;
        Panel[] pp = new Panel[5];
        public string[] lecon;
        private void encadrerEntourer_Load(object sender, EventArgs e)
        {
            gram = new XmlDocument();
            gram.Load(Application.StartupPath + @"\francais.xml"); CryptageEtHachage.DeCrypNode(gram.DocumentElement);
            suivant();
            //for (int j = 0; j < 5; j++)
            //{
            //    s = gram.GetElementsByTagName("VerbesEtSujets")[0].InnerText.Split('=')[(int)ar[j]].Trim(' ');
            //mots.AddRange(s.Split('8'));
            //motsLabels = new Label[mots.Count];
            
            //    //pp[j] = new Panel(); pp[j].Size = new Size(750, 50); pp[j].BackColor = Color.Transparent; pp[j].Location = new Point(20, j * 50 + j * 5);// pp[j].MouseDown += pp_mousedwn; pp[j].MouseMove += pp_mousemove; pp[j].MouseUp += pp_mouseUp;
            //    //this.Controls.Add(pp[j]);
            //    for (int i = 0; i < mots.Count; i++)
            //    {
            //        Label l = new Label(); l.BackColor =; l.ForeColor = Color.Black; l.TextAlign = ContentAlignment.MiddleCenter; l.Font = new Font("Comic SAns MS", 8f);
            //        l.Location = new Point(100 + i * 100, 50*j+10);

            //        motsLabels[i] = l;
            //        if (mots[i][mots[i].Length - 1] == '1') { mots[i] = mots[i].Remove(mots[i].Length - 1); answr1.Add(motsLabels[i]); }
            //        else if (mots[i][mots[i].Length - 1] == '2') { mots[i] = mots[i].Remove(mots[i].Length - 1);  answr2.Add(motsLabels[i]); }
            //        motsLabels[i].Text = mots[i];motsLabels[i].MouseDown += lbl_mousemouve;motsLabels[i].MouseMove += lbl_mousedwn;panel1 .Controls.Add(motsLabels[i]); motsLabels[i].BringToFront();
                  

            //    }
            //    motsLabels = null; mots = new List<string>();
            //}
        }
        Point MouseDownLocation=new Point(0,0);
        private void lbl_mousedwn(object sender, MouseEventArgs e)
        {

            Label btn = (Label)sender;
            btn.DoDragDrop(btn, DragDropEffects.Move); 
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    MouseDownLocation = e.Location;
            //}
        }

        private void lbl_mousemouve(object sender, MouseEventArgs e)
        {
            //Label  pictureBox1 = (Label )sender;
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
            //    pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;
            //}
        }
       private void suivant()
        {
            panel1.Controls.Clear();
            ar = ComMethodes.Generate(5, 10);
            for (int j = 0; j < 5; j++)
            {
                s = gram.GetElementsByTagName("VerbesEtSujets")[0].InnerText.Split('=')[(int)ar[j]].Trim(' ');
                mots.AddRange(s.Split('8'));
                motsLabels = new Label[mots.Count];

                //pp[j] = new Panel(); pp[j].Size = new Size(750, 50); pp[j].BackColor = Color.Transparent; pp[j].Location = new Point(20, j * 50 + j * 5);// pp[j].MouseDown += pp_mousedwn; pp[j].MouseMove += pp_mousemove; pp[j].MouseUp += pp_mouseUp;
                //this.Controls.Add(pp[j]);
                for (int i = 0; i < mots.Count; i++)
                {
                    Label l = new Label(); l.BackColor =System.Drawing.SystemColors.Info   ; l.ForeColor = Color.Black ; l.TextAlign = ContentAlignment.MiddleCenter; l.Font = new Font("Comic SAns MS", 8f);
                    l.Location = new Point(100 + i * 100, 50 * j + 10);

                    motsLabels[i] = l;
                    if (mots[i][mots[i].Length - 1] == '1') { mots[i] = mots[i].Remove(mots[i].Length - 1); answr1.Add(motsLabels[i]); }
                    else if (mots[i][mots[i].Length - 1] == '2') { mots[i] = mots[i].Remove(mots[i].Length - 1); answr2.Add(motsLabels[i]); }
                    motsLabels[i].Text = mots[i]; motsLabels[i].MouseDown += lbl_mousemouve; motsLabels[i].MouseMove += lbl_mousedwn; panel1 .Controls.Add(motsLabels[i]); motsLabels[i].BringToFront();


                }
                motsLabels = null; mots = new List<string>();
            }
        }
        ArrayList carres = new ArrayList(), ronds = new ArrayList(), answr1 = new ArrayList(), answr2 = new ArrayList(), bools1 = new ArrayList(), bools2 = new ArrayList();
        int trueans = 0, flseanswr = 0, plusSuj, moinsSuj, plusVerb, moinsVerb;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cours_de_grammaire.scores[4] = score;
            //if (int.Parse(dr[0]["sujetETverbe"].ToString()) < score) dr[0]["sujetETverbe"] = score;//Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            this.Dispose();
        }

        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (count1 > 5) plusSuj = count1 - 5; else moinsSuj = 5 - count1; if (count2 > 5) plusVerb = count1 - 5; else moinsVerb = 5 - count1;if (trueans < 5) wrong.Play(); else reussi.Play(); MessageBox.Show("Reponses correctes : " + trueans + ". Reponses fausses : " + flseanswr );
            //MessageBox.Show("false :" + flseanswr + "true: " + trueans + "moins :" + moinsSuj + "plus" + plusSuj +"moinsV :" + moinsVerb + "plusV" + plusVerb);
            count1 = count2 = plusSuj = moinsSuj=moinsVerb=plusVerb  = flseanswr=trueans= 0; answr1.Clear();answr2.Clear(); suivant();

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            ((Label )e.Data.GetData(typeof(Label ))).Parent = p;
            foreach (Control c in p.Controls)
                if (p == pictureBox1) { if (answr1.Contains(c)) trueans++; else flseanswr++;p.Controls.Clear(); }
                else if (p == pictureBox2) { if (answr2.Contains(c)) trueans++; else flseanswr++; p.Controls.Clear(); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int count1 =0, count2=0;
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.AllowDrop = true;if (p == pictureBox2) count2++; else count1  ++;
            e.Effect = DragDropEffects.Move;
        }

        
        //private void roundButton1_Click(object sender, EventArgs e)
        //{
        //    choosen = 0;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    choosen =1;
        //}

        int  score = 0;
     
              

       
    }
}
