using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Start
{
    public partial class livingGame : Form
    {
        Random r0 = new Random();
        bool[] AlreadyDrawn,UserAnswears;//alreadtdrawn to check if i already drawed a ligne from a certain point
        PictureBox p;
        bool ifLineDraw,lost;//check if drawing
        Point StartingPoint, EndingPoint;
        Graphics g,h;
        Bitmap b = new Bitmap(1219,928);
        public List<int> randomlist = new List<int>();
        public List<int> randomlist2 = new List<int>();
        int score;
        public livingGame()
        {

            score = 0;
            InitializeComponent();
            AlreadyDrawn = new bool[6];
            UserAnswears = new bool[6];
            g = pictureBox7.CreateGraphics();
            h = Graphics.FromImage(b);//bterbot l h bel bitmap kelshi bersmo byersam 3al bitmap
           pictureBox7.Image = b;
            label1.Text = "Score: " + score.ToString();

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
            doLevel();

        }
        void doLevel()
        {
            for (int i = 0; i < 10; i++)
            {
                generate();

            }//b.Dispose();
           pictureBox7.Image = b;
            for (int i = 1; i < 7; i++)
            {
                AlreadyDrawn[i - 1] = false;
                UserAnswears[i - 1] = false;
                p = (PictureBox)panel1.Controls["pictureBox" + i.ToString()];
                p.Image = imageList1.Images[randomlist[i]];
                if (randomlist[i] <= 9)//wich mean living picture
                {
                    p.Tag = "Living";
                }
                else
                {
                    p.Tag = "Non living";
                }
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                //// MessageBox.Show(p.Tag.ToString());
                //MessageBox.Show(UserAnswears[i-1].ToString());
            }
        }
        void generate()
        {
            
            int num;
            do
            {
                num = r0.Next(0, 19);
            } while (randomlist.Contains(num));
            randomlist.Add(num);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Math.Abs(e.X - (panel1.Controls["a1"].Location.X + panel1.Location.X)) > 225)//check if i pressed on a black point %x
            {
                for (int i = 1; i < 7; i++)
                {
                    if (Math.Abs(e.Y - panel1.Controls["a" + i.ToString()].Location.Y) < 10&&AlreadyDrawn[i-1]==false)//check wich black point pressed % y
                    {
                        StartingPoint = new Point(e.X, e.Y);
                        ifLineDraw = true;
                        AlreadyDrawn[i - 1] = true;
                        return;
                    }
                }
            }
            
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {

            if ((e.Button == MouseButtons.Left) && (ifLineDraw))
            {
                Point p = new Point(e.X, e.Y);
                this.Refresh();
                g.DrawLine(new Pen(Color.Black, 1), StartingPoint, p);

            }
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            if (ifLineDraw)
            {
                EndingPoint = new Point(e.X, e.Y);
                //MessageBox.Show(Math.Abs(EndingPoint.X - panel1.Location.X + panel1.Controls["rep"].Location.X).ToString());
                if (Math.Abs(EndingPoint.X -panel1.Location.X+ panel1.Controls["rep"].Location.X) < 235)
                {
                    if (Math.Abs(e.Y - panel1.Controls["rep"].Location.Y) < 20 || Math.Abs(e.Y - panel1.Controls["repp"].Location.Y) < 20)
                    {
                        h.DrawLine(new Pen(Color.Black, 1), StartingPoint, EndingPoint);
                        ifLineDraw = false;
                        this.Refresh();
                        for (int i = 1; i < 7; i++)
                        {
                            if (Math.Abs(panel1.Controls["pictureBox" + i.ToString()].Location.Y - StartingPoint.Y) < 50 && Math.Abs(e.Y - panel1.Controls["rep"].Location.Y) < 20 && (string)panel1.Controls["pictureBox" + i.ToString()].Tag == "Living")
                            {
                                UserAnswears[i - 1] = true;
                                return;
                            }
                            else if (Math.Abs(panel1.Controls["pictureBox" + i.ToString()].Location.Y - StartingPoint.Y) < 50 && Math.Abs(e.Y - panel1.Controls["repp"].Location.Y) < 20 && (string)panel1.Controls["pictureBox" + i.ToString()].Tag == "Non living")
                            {
                                UserAnswears[i - 1] = true;
                                return;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 7; i++)//checking wich black point i started from and making it false again
                        {
                            if (panel1.Controls["a" + i.ToString()].Location.Y - StartingPoint.Y < 10)
                            {
                                AlreadyDrawn[i - 1] = false;
                                return;
                            }
                        }

                        this.Refresh();
                    }
                }
                else
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (panel1.Controls["a" + i.ToString()].Location.Y - StartingPoint.Y < 10)
                        {
                            AlreadyDrawn[i - 1] = false;
                            return;
                        }
                    }
                    this.Refresh();
                }
            }
            else
            {
              //  MessageBox.Show("no");
            }
        }
        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//for startingOver
        {
            b.Dispose();

            b = new Bitmap(1219, 928);
            h = Graphics.FromImage(b);
            pictureBox7.Image = b;
            for (int j = 0; j < 6; j++)
            {
                AlreadyDrawn[j] = false;
                UserAnswears[j] = false;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");


            Application.Exit();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();

            Variables.science.Show();

        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lost == false)
            {
                int i = 0;
                while (i < 5 && AlreadyDrawn[i] == true)
                    i++;
                if (i == 5)//wich means each black point has an answear
                {
                    i = 0;
                    while (i < 5 && UserAnswears[i] == true)//checking if answears are correct
                    {
                        i++;
                    }
                    if (i == 5)
                    {
                        // MessageBox.Show("you win");
                       // pictureBox7.Image = null;
                        b.Dispose();
                   
                        b = new Bitmap(1219, 928);
                        h = Graphics.FromImage(b);

                        for (int j = 0; j < 6; j++)
                        {
                            AlreadyDrawn[i] = false;
                          //  UserAnswears[i] = false;
                        }for(int k = 0; k < 10; k++)
                        {
                            randomlist.Remove(k);
                        }MessageBox.Show("winner");
                        score =score+ 10;
                        label1.Text = "Score: " + score.ToString();
                        doLevel();

                    }
                    else
                    {
                        b.Dispose();

                        b = new Bitmap(1219, 928);
                        h = Graphics.FromImage(b);
                        pictureBox7.Image = b;
                        for (int j = 0; j < 6; j++)
                        {
                            AlreadyDrawn[j] = false;
                              UserAnswears[j] = false;
                        }
                        if (life3.Visible == true)
                            life3.Visible = false;
                        else if (life3.Visible == false && life2.Visible == true)
                            life2.Visible = false;
                        else
                        {
                            life1.Visible = false;
                            //MessageBox.Show("you loose");
                            lost = true;
                        }
                        //MessageBox.Show("something went wrong");
                    }
                }
                else
                {
                    MessageBox.Show("il ya des question qui vous pouvez repondez!");
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           
          

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
           
        
           
        }
    }
}
