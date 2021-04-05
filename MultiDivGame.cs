using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class MultiDivGame : Form
    {
        Random r1 = new Random();
        Random r2 = new Random();
        Random r3 = new Random();
        Random r4 = new Random();
        List<Button> bb;
        int score;
        bool lost;
        public MultiDivGame()
        {
            InitializeComponent();
            lost = false;
            Scoretxt.Text = "Score: ";
            bb = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12 };
            for (int i = 1; i < 7; i++)
            {
                MakeQuestion((Label)panel1.Controls["label" + i.ToString()]);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");

            for (int i = 1; i < 7; i++)
            { if (panel1.Controls["label" + i.ToString()].Location.Y > 232)
                {
                    MakeQuestion((Label)panel1.Controls["label" + i.ToString()]) ;
                    MessageBox.Show("yoy");
                }

            

        }

    }
    void MakeQuestion(Label t)
    {
       
        int a, b, c;
        c = r3.Next(0, 2);

        if (c == 0)
        {

            a = r1.Next(0, 10);
            b = r2.Next(0, 9);
            t.Text = a.ToString();
            t.Text += "x";
            t.Text += b.ToString();
        }
        else
        {
            do
            {

                a = r1.Next(0, 30);
                b = r2.Next(1, 9);
            } while (a % b != 0);
            t.Text = a.ToString();
            t.Text += "/";
            t.Text += b.ToString();

        }

        for (int i = 0; i < 11; i = i + 2)
        {
            if ((Math.Abs( t.Location.Y - bb[i].Location.Y )< 6 )&&Math.Abs (t.Location.Y - bb[i + 1].Location.Y) < 6)
            {
                 MakeAnswears(t, bb[i], bb[i + 1], a, b, c);
                // return;
          
            }

        }

    }
    void MakeAnswears(Label t, Button b, Button b2, int a, int d, int c)
    {//for(int i =0;i<)
        if ((t.Location.Y - b.Location.Y < 6) && (t.Location.Y - b2.Location.Y < 6))
        {
            int g, h;

            int k = r4.Next(0, 2);
          
            if ((a > 9) && (d > 9))
            {
                g = int.Parse((t.Text[0].ToString())) * 10 + int.Parse(t.Text[1].ToString());

                h = int.Parse(t.Text[3].ToString()) * 10 + int.Parse(t.Text[4].ToString());
            }
            else if ((a > 9) && (d <= 9))
            {
                g = int.Parse(t.Text[0].ToString()) * 10 + int.Parse(t.Text[1].ToString());

                h = int.Parse(t.Text[3].ToString());
            }
            else if ((a <= 9) && (d > 9))
            {
                g = int.Parse(t.Text[0].ToString());

                h = int.Parse(t.Text[2].ToString()) * 10 + int.Parse(t.Text[3].ToString());
            }
            else
            {
                g = int.Parse(t.Text[0].ToString());

                h = int.Parse(t.Text[2].ToString());
                }
                int l;
            
                if (k == 0)
            {



                    if (c == 0)
                    {
                        b.Text = (g * h).ToString();
                        do
                        {
                            l = r4.Next(0, 100);
                        } while (l == g * h );

                    }
                    else
                    {
                        b.Text = (g / h).ToString();
                        do
                        {
                            l = r4.Next(0, 100);
                        } while (l == g / h);

                    }
                   
                b2.Text = l.ToString();
                    b.Tag = "true";
                    b2.Tag = "false";
                }//dont forget do while;
            else
            {

                    if (c == 0)
                    {
                        b2.Text = (g * h).ToString();
                        do
                        {
                            l = r4.Next(0, 100);
                        } while (l == g * h);
                    }
                    else
                    {
                        b2.Text = (g / h).ToString();
                        do
                        {
                            l = r4.Next(0, 100);
                        } while ( l == g / h);
                    }

                b.Text = l.ToString();
                    b2.Tag = "true";
                    b.Tag = "false";
                }

        }
    }
    void moveLables(Label t)
    {

    }
    private void timer1_Tick(object sender, EventArgs e)
    { int yStep = 1;

            if (lost == false)
            {if (score >= 40&&score<100)
                    timer1.Interval = 50;
               else if (score >= 100&&score<200)
                    timer1.Interval = 30;

                else if (score >= 200)
                    timer1.Interval = 10;

                for (int i = 1; i < 7; i++)
                {
                    panel1.Controls["label" + i.ToString()].Top += yStep;
                    if (panel1.Controls["label" + i.ToString()].Top > 230)
                    {
                        panel1.Controls["label" + i.ToString()].Top = 0;
                        //  MakeQuestion((Label)this.Controls["label" + i.ToString()]);
                    }
                }

                for (int i = 1; i < 13; i++)
                {
                   
                    panel1.Controls["button" + i.ToString()].Top += yStep;
                    if (panel1.Controls["button" + i.ToString()].Top > 230)
                    {
                        for (int j = 1; j < 6; j++)
                        {
                            bool done = false;


                            if (panel1.Controls["button" + (2*j-1).ToString()].Top > 230)
                                if (panel1.Controls["button" + (2 * j - 1).ToString()].BackColor == Color.Gray && panel1.Controls["button" + (2 * j).ToString()].BackColor == Color.Gray)
                            {
                                if (done == false)
                                {
                                    if (life3.Visible == true)
                                        life3.Visible = false;
                                    else if (life3.Visible == false && life2.Visible == true)
                                        life2.Visible = false;
                                    else
                                    {
                                        life1.Visible = false;

                                        lost = true;
                                    }
                                    done = true;
                                }
                            }

                        }

                        panel1.Controls["button" + i.ToString()].Top = 0;
                    
                            panel1.Controls["button" + i.ToString()].BackColor = Color.Gray;

                    }
                }
          
          
                for (int i = 1; i < 7; i++)
                {
                    if (panel1.Controls["label" + i.ToString()].Location.Y == 0)
                    {
                        MakeQuestion((Label)panel1.Controls["label" + i.ToString()]);

                    }



                }
            }
        }

    public void button2_Click(object sender, EventArgs e)
    {

        Button b = (Button)sender;
            if (lost==false)
            {
                if ((string)b.Tag == "false")
                {
                    b.BackColor = Color.Red;
                    if (life3.Visible == true)
                        life3.Visible = false;
                    else if (life3.Visible == false && life2.Visible == true)
                        life2.Visible = false;
                    else
                    {
                        life1.Visible = false;
                        MessageBox.Show("you loose");
                        lost = true;
                    }
                }
                else if ((string)b.Tag == "true")
                {
                    b.BackColor = Color.Green;
                    score += 10;
                    Scoretxt.Text = "Score: " + score.ToString();
                }
            }
        }
        DataRow[] dr;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["MultiDiv"].ToString()) < score)
            {

                dr[0]["MultiDiv"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["MultiDiv"].ToString()) < score)
            {

                dr[0]["MultiDiv"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }
    }
    }

