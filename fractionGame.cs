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
    public partial class jeux_de_fraction : Form
    { 
        public List<int> randomlist = new List<int>();
        bool rep1busy, rep2busy, rep3busy,lost;
        PictureBox[] pic; 
        Random r0 = new Random();
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        public jeux_de_fraction()
        {
  
            InitializeComponent();
            score = 0;
      
        }
        private Point MouseDownLocation;
        Random n = new Random();
        int a, b, c, d, f,score;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            for (int i = 0; i < 3; i++)
            {
                generate();
            }

            for (int i = 0; i < 8; i++)
            {
                imageList1.Images[i].Tag = i.ToString();
            }
            doo();
        }void doo()
        {pic=new PictureBox[3];



            
            c = r0.Next(0, 3);
           
            b = r0.Next(7);
            c = r0.Next(5);
            d = r0.Next(3);
            f = r0.Next(3);
           PictureBox piz1 = new PictureBox
            {
                Name = "piz1",
                Size = new Size(100, 100),

                Location = pictureBox1.Location,

                Visible = true,
                Image = imageList1.Images[randomlist[0]],
                Tag = imageList1.Images[randomlist[0]].Tag,
                SizeMode = PictureBoxSizeMode.StretchImage,



            };
            piz1.BackColor = Color.Transparent;
            piz1.MouseClick += Piz1_MouseClick;
            piz1.MouseMove += Piz1_MouseMove;
            piz1.MouseUp += Piz1_MouseUp;
            piz1.MouseDown += Piz1_MouseDown;





            PictureBox piz2 = new PictureBox
            {
                Name = "piz2",
                Size = new Size(100, 100),
                Location = pictureBox2.Location,
                Visible = true,
                Image = imageList1.Images[randomlist[1]],
                Tag = imageList1.Images[randomlist[1]].Tag,
                SizeMode = PictureBoxSizeMode.StretchImage,


            };
            piz2.BackColor = Color.Transparent;
            piz2.MouseMove += Piz1_MouseMove;
            piz2.MouseUp += Piz1_MouseUp;
            piz2.MouseDown += Piz1_MouseDown;
            ;
            PictureBox piz3 = new PictureBox
            {
                Name = "piz3",
                Size = new Size(100, 100),
                Location = pictureBox3.Location,
                Visible = true,
                Image = imageList1.Images[randomlist[2]],
                Tag = imageList1.Images[randomlist[2]].Tag,
                SizeMode = PictureBoxSizeMode.StretchImage,

            };
            piz3.BackColor = Color.Transparent;
            piz3.MouseMove += Piz1_MouseMove;
            piz3.MouseUp += Piz1_MouseUp;
            piz3.MouseDown += Piz1_MouseDown;
            //  start_picture.BringToFront();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            piz1.BringToFront();
            piz2.BringToFront();
            piz3.BringToFront();
            panel1.Controls.Add(piz1);
            panel1.Controls.Add(piz2);
            panel1.Controls.Add(piz3);
            pic[0] = piz1;
            pic[1] = piz2;
            pic[2] = piz3;
            piz1.Image.Tag = randomlist[0];
            piz2.Image.Tag = randomlist[1];
            piz3.Image.Tag = randomlist[2];
            CallTheNumbers(piz1, piz2, piz3, ref textBox1, ref textBox2, ref textBox3);

        }

        private void Piz1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
       
        }

        private void Piz1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox PB = (PictureBox)sender;
            if (!lost)
            {
                if (a == 0)
                {
                    Disstances(pictureBox4, PB, ref rep1busy);
                    Disstances(pictureBox5, PB, ref rep2busy);
                    Disstances(pictureBox6, PB, ref rep3busy);
                }
                else if (a == 1)
                {
                    Disstances(pictureBox4, PB, ref rep1busy);
                    Disstances(pictureBox5, PB, ref rep2busy);
                    Disstances(pictureBox6, PB, ref rep3busy);
                }
                else if (a == 2)
                {
                    Disstances(pictureBox4, PB, ref rep1busy);
                    Disstances(pictureBox5, PB, ref rep2busy);
                    Disstances(pictureBox6, PB, ref rep3busy);
                }
            }

        }

        private void Piz1_MouseMove(object sender, MouseEventArgs e)
        { 
            PictureBox PB = (PictureBox)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PB.Left = e.X + PB.Left - MouseDownLocation.X;
                PB.Top = e.Y + PB.Top - MouseDownLocation.Y;
            }
          
        }

        private void Piz1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void Disstances(PictureBox target, PictureBox obj,ref bool B)
        {if (B == false)
            
                {
                if ((Math.Abs(obj.Left - target.Left) < 50)&& (Math.Abs(obj.Top - target.Top) < 50))
                {
                    B = true;
                    obj.Location = target.Location;
                    target.Visible = false;
                }
            }checkPosIfEmty(obj, target, ref B );
           
        }
        public void checkPosIfEmty(PictureBox target,PictureBox obj,ref bool B)
        {
            if (!target.Bounds.IntersectsWith(obj.Bounds))
            {
                B = false;
            }
        }
        public void CheckWichPizza(PictureBox b,ref TextBox obj)
        {
            if(b.Image.Tag.ToString()==0.ToString())
            {
      
                obj.Text = "4/8";
            }

            else if (b.Image.Tag.ToString() == 1.ToString())
                obj.Text = "1/3";
            else if (b.Image.Tag.ToString() == 2.ToString())
                obj.Text = "2/3";
            else if (b.Image.Tag.ToString() == 3.ToString())
                obj.Text = "3/8";
            else if (b.Image.Tag.ToString() == 4.ToString())
                obj.Text = "2/6";
            else if (b.Image.Tag.ToString() == 5.ToString())
                obj.Text = "1/2";
            else if (b.Image.Tag.ToString() == 6.ToString())
                obj.Text = "3/3";
            else if (b.Image.Tag.ToString() == 7.ToString())
                obj.Text = "8/9";
            else obj.Text = "nothing";
            
        }
        DataRow[] dr;
        private void btnExit_Click(object sender, EventArgs e)
        {

            if (int.Parse(dr[0]["Fractions"].ToString()) < score)
            {

                dr[0]["Fractions"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");


            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (int.Parse(dr[0]["Fractions"].ToString()) < score)
            {

                dr[0]["Fractions"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }

            this.Close();
            Variables.matiere.Show();

            Variables.matiere.ShowInTaskbar = true;
        }

        private void CallTheNumbers(PictureBox b,PictureBox c,PictureBox d,ref TextBox t,ref TextBox y, ref TextBox u)
        {
            a = n.Next(0,3);
            if (a == 0)
            {
                CheckWichPizza(b,ref t);
                CheckWichPizza(c,ref y);
                CheckWichPizza(d, ref u);
               
            }
            else if (a == 1)
            {
                CheckWichPizza(b, ref u);
                CheckWichPizza(c, ref t);
                CheckWichPizza(d, ref y);
            }
            else if (a == 2)
            {
                CheckWichPizza(b, ref y);
                CheckWichPizza(c, ref u);
                CheckWichPizza(d, ref t);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lost)
            {
                if (a == 0)
                {
                    if (panel1.Controls["piz1"].Location == pictureBox4.Location && panel1.Controls["piz2"].Location == pictureBox5.Location && panel1.Controls["piz3"].Location == pictureBox6.Location)
                    {
                        score += 10;
                        label1.Text = "Score:" + score.ToString();
                        panel1.Controls.Remove(pic[0]);
                        panel1.Controls.Remove(pic[1]);
                        panel1.Controls.Remove(pic[2]);
                        doo();
                    

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

                else if (a == 1)
                {
                    if (panel1.Controls["piz1"].Location == pictureBox6.Location && panel1.Controls["piz2"].Location == pictureBox4.Location && panel1.Controls["piz3"].Location == pictureBox5.Location)
                    {
                        score += 10;
                        label1.Text = "Score:" + score.ToString();
                        panel1.Controls.Remove(pic[0]);
                        panel1.Controls.Remove(pic[1]);
                        panel1.Controls.Remove(pic[2]);
                        doo();

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
                else if (a == 2)
                {
                    if (panel1.Controls["piz1"].Location == pictureBox5.Location && panel1.Controls["piz2"].Location == pictureBox6.Location && panel1.Controls["piz3"].Location == pictureBox4.Location)
                    {
                        panel1.Controls.Remove(pic[0]);
                        panel1.Controls.Remove(pic[1]);
                        panel1.Controls.Remove(pic[2]);
                        score += 10;
                        label1.Text = "Score:" + score.ToString();
                        doo();
                     
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
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            CancelButton.Visible = false;
            HelpPic.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
            HelpPic.Visible = true;
            CancelButton.Visible = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        public void generate()
        {
            int nam;
            do
            {
                nam = r0.Next(7);
            } while (randomlist.Contains(nam));
            randomlist.Add(nam);
        }
    }
}
