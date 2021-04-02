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
using System.Collections;
using System.Media;

namespace Start
{
   
    public partial class binding : UserControl
    {
        RoundButton[] rDep,rDest;
        Random r = new Random();
        int depart,score=0,resolu=0;
        ArrayList rand;Label[] lDep, lDest;XmlDocument gram;
        string lecon;
        int dest;
        Panel panl;
        SoundPlayer reussi = new SoundPlayer(@"Voix\Merveillleux.m4a"), wrong = new SoundPlayer(@"Voix\fail.wav");
        struct Couple
        {
            public Control From;
            public Control To;
        }
        public binding()
        {

        }
        public binding(string chapitre, int destination, int Nbdepart, Panel p, ArrayList r)
        {
            InitializeComponent();
            panl = p;
            dest = destination; 
            depart = Nbdepart; 
            lecon = chapitre;
            rand = r;
            gram = new XmlDocument();
            gram.Load(Application.StartupPath + @"\Gramm.xml");
            CryptageEtHachage.DeCrypNode(gram.DocumentElement);

        }

        private void binding_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            this.Parent.BackgroundImage = new Bitmap(Application.StartupPath + @"\Pics\Francais\backbinding.jpg");
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; 
            rDep = new RoundButton[depart];
            rDest = new RoundButton[dest]; 
            lDep = new Label [depart];
            lDest = new Label [dest];
            for (int i = 0; i < depart; i++)
            {   
                rDep[i] = new RoundButton(); rDep[i].BackColor = Color.WhiteSmoke ;
                rDep[i].Tag = gram.GetElementsByTagName(lecon )[1].InnerText.Split(',')[(int)rand[i]] ;
                rDep[i].Size = new Size(25, 30);
                rDep[i].Location = new Point(300, 50 + i * 30);
                rDep[i].MouseUp += mouseUp; 
                rDep[i].MouseMove += mouse_Mouve;
                this.Controls.Add(rDep[i]);
                lDep[i] = new Label();lDep[i].Size = new Size(280, 30);
                lDep[i].Text= gram.GetElementsByTagName(lecon )[0].InnerText.Split(',')[(int)rand[i]];
                lDep[i].TextAlign = ContentAlignment.TopRight; lDep[i].Location = new Point(10, 50 + i * 30);
                lDep[i].ForeColor = Color.WhiteSmoke; lDep[i].Font = new Font("Lemon", 10, FontStyle.Regular); 
                this.Controls.Add(lDep[i]);
            }
            for (int j = 0; j< dest; j++)
            {
                rDest[j] = new RoundButton(); rDest[j].BackColor = Color.WhiteSmoke ; rDest[j].Tag = j; rDest[j].Size = new Size(25, 30);
                rDest[j].Location = new Point(450, 50 + j * 30); this.Controls.Add(rDest[j]);
                lDest[j] = new Label(); lDest[j].Font = new Font("Lemon", 10, FontStyle.Regular); lDest[j].Size = new Size(200, 30);lDest[j].ForeColor = Color.WhiteSmoke;
                lDest[j].Text = gram.GetElementsByTagName(lecon )[2].InnerText.Split(',')[j]; lDest[j].Location = new Point(480, 50 + j * 30); this.Controls.Add(lDest[j]);
            }
        }
        bool IsBinding = false;
        Graphics g;
        Point FirstPoint;
        Control ControlFrom = null,
        ControlTo = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mouse_Mouve(object sender, MouseEventArgs e)
        {
            RoundButton  b = (RoundButton )sender;
            if (e.Button == MouseButtons.Left)
            {
                ControlFrom = b;
                IsBinding = true;
                b.Cursor = Cursors.PanEast;
                if (e.X > b.Width / 2)
                    FirstPoint = new Point(b.Left + b.Width, b.Top + b.Height / 2);
                else
                    FirstPoint = new Point(b.Left, b.Top + b.Height / 2);
            }
            else
            {
                IsBinding = false;
                ControlFrom = null;
                b.Cursor = Cursors.Arrow;
            }
             }

        private void comfirmerB_Click(object sender, EventArgs e)
        {
            switch (lecon)
            {
                case "SingulierOuPluriel": cours_de_grammaire.scores[0] = score;break;
                case "FemininOumasculin": cours_de_grammaire.scores[1] = score; break;
                case "NompropreVsNomcommun": cours_de_grammaire.scores[2] = score; break;
                case "PronomsPersonnels": cours_de_grammaire.scores[5] = score; break;
                case "demon": cours_de_grammaire.scores[7] = score; break;
                case "TypesDePhrases": cours_de_grammaire.scores[7] = score; break;
                default: break;
            }
            { if (score >= 10) reussi.Play(); else wrong.Play(); MessageBox.Show((score / 2).ToString() + "Reponses correctes."); panl.Visible = true; this.Dispose ();panl.Visible = true; }

        }

        RoundButton p;
        private void mouseUp(object sender, MouseEventArgs e)
        {
            int k = 0;
            RoundButton b = (RoundButton)sender;
            while (k < dest)
            {      if ((e.Button == MouseButtons.Left) && IsBinding)
                {
                    if ((e.X + b.Left > rDest[k].Left) && (e.X + b.Left < rDest[k].Left + rDest[k].Width))


                        if ((e.Y + b.Top > rDest[k].Top) && (e.Y + b.Top < rDest[k].Top + rDest[k].Width)) { p = rDest[k]; break; }
                }
            k++; }
           ControlTo = p;
            if (ControlTo != null)
            {
                Dessiner(b, ControlTo);
                Couple couple;
                couple.From = b;
                couple.To = ControlTo;
                b.Tag = couple;
                b.Cursor = Cursors.Arrow;
            }
            ControlFrom = null; 
            //ControlTo.Tag = couple;
        }

        private void binding_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                IsBinding = false;
                ControlFrom = null;
            }
        }

        private void Dessiner(Control ControlFrom, Control ControlTo)
        {   
            Point SecondPoint;
            if (ControlFrom.Left < ControlTo.Left)
                SecondPoint = new Point(ControlTo.Left + ControlTo.Width, ControlTo.Top + ControlTo.Height / 2);
            else
                SecondPoint = new Point(ControlTo.Left, ControlTo.Top + ControlTo.Height / 2);
            g.DrawLine(new Pen(Color.Navy, 2), FirstPoint, SecondPoint);ControlFrom.MouseMove -= mouse_Mouve;ControlTo.MouseUp -= mouseUp;
            if (ControlTo.Tag.ToString() == ControlFrom.Tag.ToString()) { score += 2;}
            IsBinding = false;
            resolu++;
            ControlFrom = null;p = null;
        }
        private void closing(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

      
    }
