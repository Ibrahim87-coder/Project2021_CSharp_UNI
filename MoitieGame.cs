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
    public partial class MoitieGame : Form
    {
        int score;
        Graphics g;
        Point p,p2,l;
        bool doneOnce,doneonce2,lost;
        Random r0;
        int a,b,c;
        public MoitieGame()
        {
            InitializeComponent();
            r0 = new Random();
            g = panel1.CreateGraphics();
            a = 0;
            b = 0;
            c = 0;
            label1.Text = "Score: ";
            doneonce2 = false;
            lost = false;
        }
        DataRow[] dr;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["MoitieEtDouble"].ToString()) < score)
            {

                dr[0]["MoitieEtDouble"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["MoitieEtDouble"].ToString()) < score)
            {

                dr[0]["MoitieEtDouble"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lost == false)
            {
                try
                {
                    if ((int.Parse(panel1.Controls["textBox1"].Text.ToString()) + int.Parse(panel1.Controls["textBox2"].Text.ToString()) == int.Parse(panel1.Controls["textBox9"].Text.ToString())) &&
                        (int.Parse(panel1.Controls["textBox3"].Text.ToString()) + int.Parse(panel1.Controls["textBox4"].Text.ToString()) == int.Parse(panel1.Controls["textBox10"].Text.ToString())) &&
                        (int.Parse(panel1.Controls["textBox6"].Text.ToString()) + int.Parse(panel1.Controls["textBox5"].Text.ToString()) == int.Parse(panel1.Controls["textBox11"].Text.ToString())) &&
                        (int.Parse(panel1.Controls["textBox8"].Text.ToString()) + int.Parse(panel1.Controls["textBox7"].Text.ToString()) == int.Parse(panel1.Controls["textBox12"].Text.ToString())))
                    {
                        score += 40;
                        label1.Text = "Score: " + score.ToString();
                        for (int i = 1; i < 13; i++)
                        {
                            panel1.Controls["textBox" + i.ToString()].Text = null;
                            t = (TextBox)panel1.Controls["textBox" + (i).ToString()];
                            t.ReadOnly = false;
                        }

                        doneonce2 = false;
                        makeQuestions();
                    }
                    else
                    {
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
                }
                catch
                {
                    MessageBox.Show("remplissez tous les espaces vides avec des nombres, s'il vous plaît");

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doneOnce == false)
            {
                DrawLines(ref doneOnce);
            }makeQuestions();
          
        }
        TextBox t;
        void DrawLines(ref bool b)
        {
            p.X = textBox9.Location.X;
            p.Y = textBox9.Location.Y + textBox9.Size.Height;
            p2.X = textBox2.Location.X + textBox2.Size.Width;
            p2.Y = textBox2.Location.Y;
            l.X = textBox9.Location.X + textBox9.Size.Width;
            l.Y = textBox9.Location.Y + textBox9.Size.Height;
            for (int j = 1; j < 9; j++)
                {
                    if (j % 2 == 0)
                    {
                        p2.X = panel1.Controls["textBox" + j.ToString()].Location.X + panel1.Controls["textBox" + j.ToString()].Size.Width;
                        p2.Y = panel1.Controls["textBox" + j.ToString()].Location.Y;
                        if (j == 2)
                            g.DrawLine(new Pen(Color.Black, 2), p2, p);
                        else if (j == 4)
                        {
                            p.X = textBox10.Location.X;
                            p.Y = textBox10.Location.Y + textBox10.Size.Height;
                            g.DrawLine(new Pen(Color.Black, 2), p2, p);
                        }
                        else if (j == 6)
                        {
                            p.X = textBox11.Location.X;
                            p.Y = textBox11.Location.Y + textBox11.Size.Height;
                            g.DrawLine(new Pen(Color.Black, 2), p2, p);
                        }
                        else if (j == 8)
                        {
                            p.X = textBox12.Location.X;
                            p.Y = textBox12.Location.Y + textBox12.Size.Height;
                            g.DrawLine(new Pen(Color.Black, 2), p2, p);
                        }
                    }
                    else
                    {
                        if(j==1)
                            g.DrawLine(new Pen(Color.Black, 2), textBox1.Location, l);
                        else if (j == 3)
                        {
                            l.X = textBox10.Location.X + textBox10.Size.Width;
                            l.Y = textBox10.Location.Y + textBox10.Size.Height;
                            g.DrawLine(new Pen(Color.Black, 2), textBox3.Location, l);
                        }
                        else if (j == 5)
                        {
                            l.X = textBox11.Location.X + textBox11.Size.Width;
                            l.Y = textBox11.Location.Y + textBox11.Size.Height;
                            g.DrawLine(new Pen(Color.Black, 2), textBox5.Location, l);
                        }
                        else if (j == 7)
                        {
                            l.X = textBox12.Location.X + textBox12.Size.Width;
                            l.Y = textBox12.Location.Y + textBox12.Size.Height;
                            g.DrawLine(new Pen(Color.Black, 2), textBox7.Location, l);
                        }
                    }
                }b = true;
            
        }//to draw the black lines;
        void makeQuestions()
        {if (doneonce2 == false)
            {
                for (int i = 0; i < 4; i++)
                {
                    a = r0.Next(0, 2);
                    if (a == 0)
                    {
                        do
                        {
                            b = r0.Next(0, 200);
                        } while (b % 2 != 0);
                        panel1.Controls["textBox" + (i + 9).ToString()].Text = b.ToString();
                        t = (TextBox)panel1.Controls["textBox" + (i + 9).ToString()];
                        t.ReadOnly = true;
                    }
                    else
                    {
                        
                        c = r0.Next(0, 100);
                        b = r0.Next(0, 100);
                        if (i == 0)
                        {
                            if (c == 0)
                            {
                                panel1.Controls["textBox" + (2).ToString()].Text = b.ToString();
                                textBox2.ReadOnly = true;
                 
                            }
                            else
                            {
                                panel1.Controls["textBox" + (1).ToString()].Text = b.ToString();
                                textBox1.ReadOnly = true;
                   
                            }
                        }
                        else if (i == 1)
                        {
                            if (c == 0)
                            {
                                panel1.Controls["textBox" + (4).ToString()].Text = b.ToString();
                                textBox4.ReadOnly = true;
                            }
                            else
                            {
                                panel1.Controls["textBox" + (3).ToString()].Text = b.ToString();
                                textBox3.ReadOnly = true;
                            }

                        }
                        else if (i == 2)
                        {
                            if (c == 0)
                            {
                                panel1.Controls["textBox" + (6).ToString()].Text = b.ToString();
                                textBox6.ReadOnly = true;
                            }
                            else
                            {
                                panel1.Controls["textBox" + (5).ToString()].Text = b.ToString();
                                textBox5.ReadOnly = true;
                            }
                        }
                        else
                        {
                            if (c == 0)
                            {
                                panel1.Controls["textBox" + (8).ToString()].Text = b.ToString();
                                textBox8.ReadOnly = true;
                            }
                            else
                            {
                                panel1.Controls["textBox" + (7).ToString()].Text = b.ToString();
                                textBox7.ReadOnly = true;
                            }
                        }

                    }button1.Hide();
                }doneonce2 = true;
            }
        }
    }
}
