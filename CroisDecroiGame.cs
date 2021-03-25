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
    public partial class jeux_de_decroi_croi : Form
    {
        int hardness = 0;//what stage we are in
        Random r0 = new Random();
        int a;//
        Label[] numbers;
        int[] ind;//the  correct answears
        int[] rep;//the user answears
        Point MouseDownLocation;
        bool lost;
        public jeux_de_decroi_croi()
        {
            InitializeComponent();
      
        }
        int b;//determine how many numbers
        private void Form1_Load(object sender, EventArgs e)
        {
            make();
         

        }

        private void K_MouseUp(object sender, MouseEventArgs e)
        { Label pb = (Label)sender;
            for (int i = 0; i < b; i++)
                 {
                CheckPos((PictureBox)(this.Controls["Pos" + i.ToString()]), numbers, int.Parse(pb.Name[pb.Name.Length-1].ToString()),i);   
                 }
        }
        public void CheckPos(PictureBox target, Label[] obj,int i,int l)
        {
                    if ((Math.Abs(obj[i].Left - target.Left) < 50) && (Math.Abs(obj[i].Top - target.Top) < 50))
                    {
                        obj[i].Location =new Point(target.Location.X, target.Location.Y-20);
                       
                        target.SendToBack();
                        rep[l] =int.Parse(obj[i].Text.ToString());
                    }

        }

        private void K_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void K_MouseMove(object sender, MouseEventArgs e)
        {
            Label PB = (Label)sender;
            if (!lost)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    PB.Left = e.X + PB.Left - MouseDownLocation.X;
                    PB.Top = e.Y + PB.Top - MouseDownLocation.Y;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int j = 0;
            int k = b-1;
            if (!lost)
            {
                if (a == 0)
                {
                    while ((rep[j] == ind[j]) && (j < b - 1))
                    {
                        j++;
                    }
                }
                else
                {
                    while ((rep[j] == ind[k]) && (j < b - 1) && (k != 0))
                    {
                        k--;
                        j++;
                    }
                }
                if (j == b - 1)
                {
                    if (hardness == 2)
                    {
                        MessageBox.Show("over");
                    }
                    else
                    {
                        PictureBox flesh = new PictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(button1.Location.X, button1.Location.Y-100),
                            Image = imageList1.Images[1],
                            BackColor = Color.Transparent,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Name = "Arrow",

                        };
                        this.Controls.Add(flesh);
                        flesh.BringToFront();
                        flesh.Click += Flesh_Click;
                        hardness++;
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
                        MessageBox.Show("you loose");
                        lost = true;
                    }
                }
            }
        }

        private void Flesh_Click(object sender, EventArgs e)
        {
            ind = null;
            rep = null;
            this.Controls.Remove((this.Controls["Arrow"]));
            for(int i = 0; i < b; i++)
            {
                this.Controls.Remove(this.Controls["Lab" + i.ToString()]);
                this.Controls.Remove(this.Controls["Pos" + i.ToString()]);
            }
            make();
        }void make()
        {
            a = r0.Next(0, 2);
            if (a == 0)
            {
                label1.Text = "Range d'ordre croissant";
            }
            else
            {
                label1.Text = "Range d'ordre decroissant";
            }
            if (hardness == 0)//first stage
            {
                b = r0.Next(2, 3);
            }else if((hardness == 1)){
                b = r0.Next(3, 5);
            }
            else
            {
             
                
                    b = r0.Next(5, 7);
                
            }
            numbers = new Label[b];
            ind = new int[b];
            rep = new int[b];
            int c;
            for (int i = 0; i < b; i++)
            {
                if (hardness == 0)
                {
                    c = r0.Next(0, 10);
                }else if (hardness == 1)
                {
                    c = r0.Next(10, 100);
                }
                else
                {
                    c = r0.Next(100, 1000);
                }
                Label k = new Label
                {
                    ForeColor = Color.Aqua,
                    Size = new Size(100, 100),
                    Location = new Point(200 + 60 * 2 * i, 400),
                    Text = c.ToString(),
                    Font = new Font("Bradley Hand ITC", 24, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    Name = "Lab" + i.ToString(),
                }
                ; k.MouseMove += K_MouseMove;
                k.MouseDown += K_MouseDown;
                k.MouseUp += K_MouseUp;
                PictureBox pos = new PictureBox
                {
                    Size = new Size(137 / 3, 11 / 3),
                    Location = new Point(200 + 60 * 2 * i, 300),
                    Image = imageList1.Images[0],
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Name = "Pos" + i.ToString(),

                };
                 this.Controls.Add(k);
                this.Controls.Add(pos);
                numbers[i] = (Label)(this.Controls["Lab" + i.ToString()]);
                ind[i] = int.Parse(this.Controls["Lab" + i.ToString()].Text.ToString());
            }
            Array.Sort(ind);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.ShowInTaskbar = true;
            Variables.matiere.Show();

        }
    }
}
