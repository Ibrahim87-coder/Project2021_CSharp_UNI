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
  
    public partial class jeux_de_Complement : Form
    {
        bool[] bb;
        bool lost;
        Random r1 = new Random();
        int a, NumbTimes, score;
        private Point MouseDownLocation;
        public jeux_de_Complement()
        {
            InitializeComponent();
            NumbTimes = 0;
            begin();
        }void begin()
        {
            //pictureBox1.Location = new Point(315, 359);
            //pictureBox2.Location = new Point(497, 392 - 14);
            //pictureBox4.Location = new Point(497, 378);
            bb = new bool[10];
         
            a = r1.Next(5, 14);

            panel1.Controls["pictureBox" + a.ToString()].Location = new Point(250, 270);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - (a + 9)+14);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + (a - 9));
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - (a + 9));

            for (int i = 0; i < 10; i++)
            {
                bb[i] = false;
            }
            bb[a - 5] = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox PB = (PictureBox)sender;
            if (!lost)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    PB.Left = e.X + PB.Left - MouseDownLocation.X;
                    PB.Top = e.Y + PB.Top - MouseDownLocation.Y;

                }
            }

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        { PictureBox pb = (PictureBox)(sender);
            int b=0;

            if (pb.Bounds.IntersectsWith(pictureBox1.Bounds))
            { if (pb.Name.Length > 11)
                    b = int.Parse(pb.Name[pb.Name.Length - 2].ToString()) * 10 + int.Parse(pb.Name[pb.Name.Length - 1].ToString());
                else b = int.Parse(pb.Name[pb.Name.Length - 1].ToString());
                if (!bb[b - 5])
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - b);
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + b);
                    pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - b);
                    bb[b - 5] = true;
                }
            }
            else
            {
                if (pb.Name.Length > 11)
                {
                    if (bb[int.Parse(pb.Name[pb.Name.Length - 2].ToString()) * 10 + int.Parse(pb.Name[pb.Name.Length - 1].ToString()) - 5] == true)
                    {
                        b = int.Parse(pb.Name[pb.Name.Length - 2].ToString()) * 10 + int.Parse(pb.Name[pb.Name.Length - 1].ToString());
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + b);
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - b);
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + b);
                        bb[b-5] = false;
                    }
                }else
                {
                    if (bb[int.Parse(pb.Name[pb.Name.Length - 1].ToString())-5] == true)
                    {
                        b = int.Parse(pb.Name[pb.Name.Length - 1].ToString());
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + b);
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - b);
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + b);
                        bb[b-5] = false;
                    }
                }
                      
            }
            
          //  MessageBox.Show(b.ToString());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lost)
            {
                if (Math.Abs(pictureBox2.Location.Y - pictureBox1.Location.Y) <= 9f)
                {
                    if (NumbTimes > 3)
                    {
                        MessageBox.Show("Bravo! Maintenant vous etes entree le score");
                        DialogResult res = MessageBox.Show("Continuer?", "Continuer?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.Yes)
                        {
                            begin();
                        }


                    }
                    else
                    {
                        begin();
                        NumbTimes++;
                        score += 10;
                        scoretxt.Text = "Score " + score.ToString();
                    }
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
                        MessageBox.Show("Oops!!!!");
                        lost = true;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
         
            Variables.matiere.ShowInTaskbar = true;

        }
    }
    }

