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
using System.Text.RegularExpressions;
using System.Collections;

namespace Start
{
    public partial class Dictée : Form
    {
        public Dictée()
        {
            InitializeComponent();
            conjugaison = new XmlDocument();
            conjugaison.Load(Application.StartupPath + @"\conjugaison.xml"); CryptageEtHachage.DeCrypNode(conjugaison .DocumentElement);
        }
        Random r = new Random ();string vrai11, vrai12, vrai13, vrai21, vrai22; int a = 1;

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowInTaskbar = false;
        }

        public static  int [] t =new int[5];
        string[] Repponses;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Repponses = Reponses();
             dic1.texts(); 


        }

        XmlDocument conjugaison;float  noteLevel;string remarques=null ;

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataRow []dr;

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            dic1.texts();
            if (a == 1)
            {
                {
                    for (int i = 0; i < Repponses.Length; i++)
                    {
                        remarques +=i + ")" + test(dic1.Texte[i], Repponses[i], out float Current) + "\n";//dic1.vn.URL = @"Voix/Dic" + t[i] + 1;
                        noteLevel += Current;
                    }
                    {
                        string message; if (noteLevel > 22){ message = "Ton Note est" + noteLevel.ToString() + "/50 .\n  Courage Champ! \n Voulez vous repeter?"; DialogResult rep = MessageBox.Show(message, "Dictee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);if (rep == DialogResult.Yes) { dic1.newEx(); remarques = ""; noteLevel = 0;Repponses = Reponses();
                            
                              
                            } else this.Close(); } else {message = "Ton Note est" + noteLevel.ToString() + "/50  . \n :( Ressayer"; MessageBox.Show(message + remarques); Repponses = Reponses();
                            dic1.newEx(); remarques = ""; noteLevel = 0; } // if (noteLevel > 0) { a++; dic1.Dispose(); dic2.Visible = true; noteLevel = 0; remarques = null; return; } }
                    }    //{ if (dic1.Texte[i] == Reponses(a)[i]) { score += 20; MessageBox.Show(score.ToString()); dic1.Dispose(); dic2.Visible = true; } else { dic1.Controls[i].BackColor = Color.Red; } } }
                }
                //else if (a == 2)
                //{
                //    { for (int i = 0; i < Reponses(a).Length; i++) { remarques += i + 1 + ")" + test(dic2.Texte[i], Reponses(a)[i], out float Current) + "\n"; noteLevel += Current; } { string message; if (noteLevel > 0) message = "Ton Note est" + noteLevel.ToString() + ".\n  Courage Champ!"; else message = "Ton Note est" + noteLevel.ToString() + ". \n :( Ressayer"; MessageBox.Show(message + remarques); if (noteLevel > 10) { a++; remarques = null; dic2.Dispose(); dic3.Visible = true; return; } } }//{ if (dic2.Texte[i] == Reponses(a)[i]) { score += 30; MessageBox.Show(score.ToString()); dic2.Dispose(); dic3.Visible = true; } else { dic1.Controls[i].BackColor = Color.Red; } } }
                //}
                //else if (a == 3)
                //{
                //    for (int i = 0; i < Reponses(a).Length; i++) { remarques += i + 1 + ")" + test(dic3.Texte[i], Reponses(a)[i], out float Current); noteLevel = Current * 2; } //  if (dic3.Texte[i] == Reponses(a)[i]) { score += 20; MessageBox.Show(score.ToString()); this.Close(); } 
                //    if (noteLevel > 0) { a++; score = 0; } else MessageBox.Show("Ressayer.");
                //}
                //else if (a == 4) { MessageBox.Show("Ton Note est" + noteLevel.ToString() + "Courage!"); this.Close(); }
            }
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["Dictee"].ToString()) < noteLevel)
            {
                dr[0]["Dictee"] = noteLevel;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            } 
        }
        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

              
        // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);

                }
            }
            // Step 7
            return d[n, m];
        }
        static string  test(string s1, string s2 ,out float  notta)
        {
            notta = 0;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options); ArrayList diff1 = new ArrayList();
            ArrayList diff2 = new ArrayList();
            ArrayList set1 = new ArrayList();
            ArrayList set2 = new ArrayList();
            try
            {
                s1 = regex.Replace(s1, " ").Trim();
                s2 = regex.Replace(s2, " ").Trim();
            }
            catch { MessageBox.Show("Ressayer il a des cases vides");return ""; }

            set1.AddRange(s1.Split(' '));
            set2.AddRange(s2.Split(' '));
            diff1.AddRange(set1);string sa = null;
            diff2.AddRange(set2); if (Compute(s1, s2) == 0) { notta = 10; return "true dictee"; }
            else
            {
                int i, x;
                for (i = 0; i < set1.Count; i++)
                {
                    if (diff2.IndexOf(set1[i]) != -1) diff2.Remove(set1[i]);

                }
                for (i = 0; i < set2.Count; i++)
                {
                    if (diff1.IndexOf(set2[i]) != -1) diff1.Remove(set2[i]);

                }
                string s = String.Join(",", diff1.ToArray());
                // MessageBox.Show("diff1:" + s);
                string ss1 = String.Join(",", diff2.ToArray());
                // MessageBox.Show("dff2:" + ss1);
                float noteTotale, note;
                noteTotale = note = 2;
                i = 0; ArrayList missedWords = new ArrayList();
                if (diff1.Count == diff2.Count)
                {

                    while (i < diff1.Count)
                    {
                        x = Compute(diff1[i].ToString(), diff2[i].ToString());
                        if (x < 2) note -= (noteTotale / 20);
                        else { if (x >= 2) note -= noteTotale / 10; }
                        i++;
                        //MessageBox.Show(x.ToString());
                    }
                    notta = note * 10 / noteTotale;
                    return "Il y a des fautes."
                   /* return "votre note:" + (note * 10 / noteTotale).ToString()*/;
                }
                else
                {
                    if (diff2.Count == 0) missedWords.AddRange(diff1);
                    else
                    {
                        diff1.Reverse(); diff2.Reverse();
                        if ((diff2.Count != 0) && (diff1.Count > diff2.Count))
                        {
                            string mot1, mot2; int j;
                            while (diff2.Count != 0)
                            {
                                i = diff1.Count - 1; j = diff2.Count - 1; int lengthDiff;
                                if (diff1.Count != 0)
                                {
                                    mot1 = diff1[i].ToString(); mot2 = diff2[j].ToString();
                                    x = Compute(mot1, mot2); lengthDiff = (Math.Abs(mot1.Length - mot2.Length));


                                    if ((mot1.Length < 3) && (mot2.Length < 3) && (mot1.ToLower() != mot2.ToLower())) { note -= noteTotale / 10; diff1.Remove(mot1); diff2.Remove(mot2); }
                                    else
                                    {
                                        if ((lengthDiff == 0) && (x > mot1.Length / 2)) { /*MessageBox.Show("first");*/ note -= noteTotale / 10; missedWords.Add(mot1); diff1.Remove(mot1); }

                                        else
                                        {
                                            if (((lengthDiff < 3) && (x > lengthDiff) && (lengthDiff != 0)) || (lengthDiff >= 3))
                                            {
                                                //MessageBox.Show("jdsd");
                                                note -= noteTotale / 10; missedWords.Add(mot1); diff1.Remove(mot1);
                                            }
                                            else
                                            {
                                                if (x < 2) { note -= noteTotale / 20; }
                                                else note -= noteTotale / 10;
                                                diff1.Remove(mot1); diff2.Remove(mot2);
                                            }


                                        }
                                    }
                                }

                            }
                            if (diff1.Count != 0) missedWords.AddRange(diff1);
                        }
                        missedWords.Reverse();
                        sa = String.Join(",", missedWords.ToArray());

                    }
                }
                return "Mots manques:" + sa;
            }
        }


       
        private string [] Reponses()
        {
            do
            {
                t[0] = r.Next(7); t[1] = r.Next(7); t[2] = r.Next(7);
                vrai11 = conjugaison.GetElementsByTagName("Dictee")[1].InnerText.Split('*')[t[0]];
                vrai12 = conjugaison.GetElementsByTagName("Dictee")[1].InnerText.Split('*')[t[1]];
                vrai13 = conjugaison.GetElementsByTagName("Dictee")[1].InnerText.Split('*')[t[2]];

            } while (vrai13 == vrai12 || vrai12 == vrai11 || vrai13 == vrai11);

            do
            {
                t[3] = r.Next(5); t[4] = r.Next(5);
                vrai21 = conjugaison.GetElementsByTagName("Dictee")[2].InnerText.Split('*')[t[3]];
                vrai22 = conjugaison.GetElementsByTagName("Dictee")[2].InnerText.Split('*')[t[4]];
            } while (vrai22 == vrai21);
            string[] ti = new string[5]; ti[0] = vrai11; ti[1] = vrai12; ti[2] = vrai13; ti[3] = vrai21; ti[4] = vrai22; return ti; }
            

    }
}
