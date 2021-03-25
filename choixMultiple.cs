using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Xml;

namespace Start  
{
    public partial class choixMultiple : UserControl
    {  
        public choixMultiple()
        {  
            InitializeComponent();//dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
        }
        XmlDocument gram;  public  ArrayList randomss = new ArrayList(), rands;public string choisi, lecon;int i = 0, score = 0;public static  int len, max;public Panel pan;

        SoundPlayer truee =new SoundPlayer( @"Voix\trueAns1.wav"), wrong =new SoundPlayer( @"Voix\wrong.wav");



        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            choisi = b.Text;
                
                }
        //DataRow[] dr;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (choisi == gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[i] * 3]) { score += 5; truee.Play(); lblarr[i].BackColor = Color.Green; } else { wrong.Play(); lblarr[i].BackColor = Color.Red; }
            label2.Text = "Score: " + score;
            i++; if (i == len)
            {
               // if (int.Parse(dr[0][lecon].ToString()) < score/5) dr[0][lecon] = score/5;
                DialogResult rep = MessageBox.Show(score/5 +   "  Reponses correctes. Voulez vous continuez?", lecon, MessageBoxButtons.YesNo, MessageBoxIcon.Question); if (rep == DialogResult.No)
                {
                    pan.Visible = true; this.Dispose();
                    switch(lecon )
                    {
                        case "Adjectifs": cours_de_grammaire.scores[3] = score; break;
                        case "Posses": cours_de_grammaire.scores[6] = score; break;
                        //case "TypesDePhrases": Gram.scores[7] = score; break;
                        default: break;
                    }
                    return;
                } else { i = 0;rands = ComMethodes.Generate(len, max);score = 0; ;label2.Text = "Score: 0"; foreach (RoundButton r in lblarr) r.BackColor = Color.Transparent; }
            }
           label1.Text = gram.GetElementsByTagName(lecon)[0].InnerText.Split(',')[(int)rands[i]];
            randomss = ComMethodes.Generate(3, 3);
            b[(int)randomss[0]].Text = gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[i]*3];
            b[(int)randomss[1]].Text = gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[i]*3+1];
            b[(int)randomss[2]].Text = gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[i]*3+2];
        }
        Button[] b = new Button[3];RoundButton[] lblarr=new RoundButton[len];
        public string xmlFile;
        private void choixMultiple_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < len ; i++)
            {
                lblarr[i] = new RoundButton(); lblarr[i].Size = new Size(30, 30);
                lblarr[i].Location = new Point(13 + i * 30, 11); panel1.Controls.Add(lblarr[i]);

            }
            gram = new XmlDocument();
            if (xmlFile == null)
            {
                gram.Load(Application.StartupPath + @"\Francais.xml"); CryptageEtHachage.DeCrypNode(gram.DocumentElement);
            }
            else
            {
                gram.Load(Application.StartupPath + @"\Prof.xml");
            }
           

            randomss = ComMethodes.Generate(3, 3);
            for (int k = 0; k < 3; k++)
            {
                b[k] = new Button();
                b[k].Size = new Size(200, 70); 
                b[k].Location = new Point(100+200*k,280);
                b[k].MouseEnter += changefont; 
                b[k].BackColor = SystemColors.Info;
                b[k].Font= new Font("Lemon", 10, FontStyle.Regular);
                this.Controls.Add(b[k]);
                b[k].Click += button2_Click;
            }
          
            label1.Text = gram.GetElementsByTagName(lecon)[0].InnerText.Split(',')[(int)rands[i]];
            b[(int)randomss[0]].Text = gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[0] * 3];
            b[(int)randomss[1]].Text = gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[0] * 3+1];
            b[(int)randomss[2]].Text = gram.GetElementsByTagName(lecon)[1].InnerText.Split(',')[(int)rands[0] * 3+2];

        }

        private void changefont(object sender, EventArgs e)
        { Button b = new Button();
           b.Font = new Font("Lemon", 14, FontStyle.Regular);
        }
    }
}
