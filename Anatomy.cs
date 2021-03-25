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
    public partial class Anatomy : Form
    {
     
        Random r0 = new Random();
        int a,k;
        int[] done;
        bool d, dd, lost,UsingHelp;
        public Anatomy()
        {
            done = new int[10];
            k = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            make();
        }void make()
        { int i = 0;
            do//for generating a random number
            {
                a = r0.Next(0, 11);
                i++;
            }
            while (a == done[i] && i < 10) ;
            pictureBox7.Image = imageList1.Images[a];
            d = false;
            dd = false;
            pictureBox6.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            if (a != 8)//that means the question dosent contains more than 1 sensation
            {
                label2.Text = "Nommer la";
            }
            else label2.Text = "Nommer les";
            label1.Text = "Quel sens on utilise?";
            textBox1.Clear();
            textBox1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (!UsingHelp)
            {
                if (!lost)
                    check(pb, a, ref d, ref dd);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Size = new Size(pb.Size.Width - 10, pb.Size.Height - 10);
            pb.Location = new Point(pb.Location.X + 10, pb.Location.Y + 10);
            //to make the image pop when they are clicked
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X - 10, pb.Location.Y - 10);
            pb.Size = new Size(pb.Size.Width + 10, pb.Size.Height + 10);
            //to return them to they normal size and location
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            {if(!UsingHelp)
                if (!lost)
                {
                    if (a < 2)
                    {//wich means a=0or1 wich mean the image in this case must be about tasting sensations
                        if (textBox1.Text == "le gout" || textBox1.Text == "gout")
                        {
                            label2.Text = "C'est Vrai";

                            pictureBox6.Visible = true;
                        }
                        else label2.Text = "C'est faux";
                    }
                    else if (a == 2 || a == 3)
                    {

                        if (textBox1.Text == "l'oui")
                        {
                            label2.Text = "C'est Vrai";
                            pictureBox6.Visible = true;
                        }
                        else label2.Text = "C'est faux";
                    }
                    else if (a == 4 || a == 5)
                    {
                        if (textBox1.Text == "l'odorat")
                        {
                            label2.Text = "C'est Vrai";
                            pictureBox6.Visible = true;
                        }
                        else label2.Text = "C'est faux";
                    }
                    else if (a == 6 || a == 7)
                    {
                        if (textBox1.Text == "le toucher")
                        {
                            label2.Text = "C'est Vrai";
                            pictureBox6.Visible = true;
                        }
                        else label2.Text = "C'est faux";
                    }
                    else if (a == 9 || a == 10)
                    {
                        if (textBox1.Text == "la vue" || textBox1.Text == "la vision")
                        {
                            label2.Text = "C'est Vrai";
                            pictureBox6.Visible = true;
                        }
                        else label2.Text = "C'est faux";
                    }
                    else
                    {
                        if (textBox1.Text == "la vue et le toucher" || textBox1.Text == "la vision et le toucher")
                        {
                            label2.Text = "C'est Vrai";
                            pictureBox6.Visible = true;
                        }
                        else label2.Text = "C'est faux";
                    }
                }
                if (label2.Text == "C'est Vrai")
                {
                    k++;
                }
                else if (label2.Text == "C'est faux")
                {//removing lifes
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            UsingHelp = true;
            HelpPic.Visible = true;
            CancelButton.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            UsingHelp = false;
            CancelButton.Visible = false;
            HelpPic.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.science.Show();
            Variables.science.ShowInTaskbar = true;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            k++;//increment the score each time by one
            if (k >= 3)
                MessageBox.Show("winner");
            else
            {if(!lost)
                make();
            }
        }

        void check(PictureBox b, int c, ref bool done1, ref bool done2)
        {
            if (!done1||!done2)
                if (c != 8)
                {
                    if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 1 && ((c == 2) || (c == 3)))// we are using the last character of the picture box to check wich sensation were using
                    {                                                                                  // c indicates wich image is being used from the imagelist wich indicate the sensation in use in the picture
                      //if the last character is 1 wich means hearing and if c=2or3 means the images is about hearing
                        done1 = true;
                        done2 = true;
                    }
                    else if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 2 && ((c == 9) || (c == 10)))
                    {
                      //  same concept as the open above
                        done1 = true;
                        done2 = true;
                    }
                    else if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 3 && ((c == 6) || (c == 7)))
                    {
                        done2 = true;
                        done1 = true;
                   
                    }
                    else if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 4 && ((c == 0) || (c == 1)))
                    {
                        done2 = true;
                        done1 = true;
                
                    }
                    else if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 5 && ((c == 4) || (c == 5)))
                    {
                        done2 = true;
                        done1 = true;
              
                    }
                    else
                    {
                        done2 = false;
                        done1 = false;
             
                    }
                }
                else
                {//this is a special case where the image illustrad 2 sensations
                    if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 2)//wich mean i selected the vision icon wich is correct
                    {
                        done1 = true;
                        label1.Text = "Vision et ...";
                    }
                    else if (int.Parse(b.Name[b.Name.Length - 1].ToString()) == 4)//wich mean i used the tasting sensation icon first wich is also correct
                    {
                        done2 = true;
                        label1.Text = "Gout et ...";
                    }
              

                }
            //done1 and done2 are used to determine if we chose correct answears we used 2 bool because there is an images wich has 2 sensation so we needed 2 bools
       
            if (done1 && done2)
            {
                button1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                label1.Text = "Bravo";
            }
            else
            {if (c != 8)
                    label1.Text = "Non";
                else
                {if ((int.Parse(b.Name[b.Name.Length - 1].ToString()) == 2 || int.Parse(b.Name[b.Name.Length - 1].ToString()) == 4))
                    {
                        label1.Text = "Encore";//if i chose 1 correct answear
                    }
                    else
                    {
                        label1.Text = "Non";
             

                    }
               
                }
            }
            if (label1.Text == "Non")
            {//removing the lifes
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

