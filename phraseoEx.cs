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
    public partial class phraseoEx : UserControl
    {
        public phraseoEx()
        {
            //gram = new XmlDocument();dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            gram.Load(Application.StartupPath + @"\Francais.xml"); CryptageEtHachage.DeCrypNode(gram.DocumentElement);
            InitializeComponent();newEx();
        }
        List<string> mots = new List<string>();
        Label[] motsLabels; string s;int i = -1;XmlDocument gram;int score,vrais;
   

        private void newEx()
        {
            Random r1 = new Random();
            s = gram.GetElementsByTagName("Dictee")[0].InnerText.Split('*')[r1.Next(4)];MessageBox.Show(s);

            mots.AddRange(s.Split(' '));
            motsLabels = new Label[mots.Count];

            Random r = new Random();
            for (int i = 0; i < mots.Count; i++)
            {
                Label l = new Label(); l.BackColor = Color.AliceBlue; l.TextAlign = ContentAlignment.MiddleCenter; l.Font = new Font("Comic SAns MS", 10f);
                this.Controls.Add(l);
                motsLabels[i] = l;

            }
            int k = 0, x = 180;/*int j;*/
            while (k < motsLabels.Length)
            {
                motsLabels[k].Text = mots[k].TrimEnd();

                k++;
            }

            motsLabels = motsLabels.OrderBy(Y => r.Next()).ToArray();
            k = 0;
            while (k < motsLabels.Length)
            {
                motsLabels[k].Location = new Point(x, 230); motsLabels[k].Size = new Size(100, 25);
                motsLabels[k].Tag = motsLabels[k].Left + "," + motsLabels[k].Top;
                x += 100;
                motsLabels[k].Click += mot_Click;
                k++;
            }

        }
        private void mot_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            i++;
            if (i % 2 == 0)
            {
                Thread childThread = new Thread(new ThreadStart(() =>

                {
                    while (true)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        { l.Location = this.PointToClient(Cursor.Position); }));
                        if (i % 2 != 0) break;
                        else
                        {
                            if (l.Left > this.Width - 40 || l.Left < 20 || l.Top > this.Height - 40 || l.Top < 40)
                            {
                                this.Invoke(new MethodInvoker(() =>
                                { l.Location = new Point(int.Parse(l.Tag.ToString().Split(',')[0]), int.Parse(l.Tag.ToString().Split(',')[1])); })); i++; break;
                            }
                        }
                    }
                }));
                childThread.Start();
            }

            else
            {
                l.Location = this.PointToClient(Cursor.Position);
            }

        }
        private void phraseoEx_Load(object sender, EventArgs e)
        { this.Parent.BackgroundImage = new Bitmap(Application.StartupPath + @"\Pics\Francais\backbinding.jpg");
         

        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            score += ((int)(5*vrais / motsLabels.Length));
            Score.Text = "Score : " + score .ToString();
            foreach (Label l in motsLabels) l.Visible = false;vrais = 0;
            nxtBtn.Hide();
            newEx();
        }

        private void comfirmerB_Click(object sender, EventArgs e)
        {

            nxtBtn.Show();
            bool permut = false;
            int i = 0;
            Label aux;
            do
            {
                permut = false;
                for (i = 0; i < motsLabels.Length - 1; i++)
                {
                    if (motsLabels[i].Left > motsLabels[i + 1].Left)
                    {
                        aux = motsLabels[i]; motsLabels[i] = motsLabels[i + 1]; motsLabels[i + 1] = aux;
                        permut = true;
                    }
                }
            } while (permut);

            for (i = 0; i < motsLabels.Length; i++)
            {
                if (motsLabels[i].Text != mots[i]) { motsLabels[i].BackColor = Color.Red; }
                else {motsLabels[i].BackColor = Color.Green; vrais++;
            }
            }
            mots.Clear() ;  
        }
       // DataRow[] dr;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cours_de_grammaire.scores[8] = score;
           //if (int.Parse(dr[0]["sujetETverbe"].ToString()) < score) dr[0]["LaPhrase"] = score; Variables.XmlWriter(Application.StartupPath + "\\users.xml"); 
            this.Dispose();

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
    }
}
