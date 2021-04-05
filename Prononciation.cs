using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using WMPLib;
namespace Start 
{
    public partial class cours_Prononciation : Form
    {
        int i = 65, j = 1, k = 0, l = 1; public int choix;
      // char[] voyelles = { 'a', 'e', 'i', 'o', 'u' }; int[] combinaison = { 0, 2, 0, 4, 1, 2, 1, 4, 3, 2, 3, 4 }; 
        Bitmap x, theo;
        string[] combinaison = { "a  +   i = ai", "a  +   u = au", "e  +  i = ei" , "e  +   u = eu", "o  +  i = oi", "o  +  u = ou" };
       
        WindowsMediaPlayer p1 = new WindowsMediaPlayer();
        XmlDocument sonsEx; string[] sonssex, sounds = new string[32];
        public cours_Prononciation()
        {
           
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            i = 65;
          panel2.Dock = DockStyle.Fill;panel2.BringToFront(); panel2.Visible = true;
        }

        private void reetendre_Click(object sender, EventArgs e)
        {
            //sounds repeat
            p1.URL = Application.StartupPath + @"\FrancaisVoix\" + (j-1) + "pro.m4a"; p1.controls.play();
        }

     

    private void button3_Click(object sender, EventArgs e)//ex
        {
            sonssex = new string[26];
            sonsEx .Load(Application.StartupPath + @"\francais.xml"); CryptageEtHachage.DeCrypNode(sonsEx .DocumentElement); sonssex = sonsEx.GetElementsByTagName("choicesSons")[0].InnerText.Split(',');timer1.Start();
            x = new Bitmap(Application.StartupPath + @"\Pics\Lettres\cochericon.png"); panel2.Visible = false;
            theo = new Bitmap(Application.StartupPath + @"\Pics\Lettres\th.png"); pictureBox7.Image = theo;
        }

        private void Prononciation_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {   
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Prononciation_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            choix = 3;
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            label6.Visible = label7.Visible =false ;button3.Visible = false;i = 65;j = 1;
           suivant.Visible = reetendre.Visible = true;if (choix == 1)
            {
                p1.URL = Application.StartupPath + @"\FrancaisVoix\" + 0 + "pro.m4a"; p1.controls.play(); label1.Text = "A"; label2.Text = "a"; photos.Image = new Bitmap(Application.StartupPath + @"\Pics\Lettres\1pronon.jpg");
                label1.Visible = true; label2.Visible = true; label2.Visible = label1.Visible = photos.Visible = true;
               startpic.Visible = false; pictureBox7.Visible = true;
                photos.Visible = true; suivant.Visible = true; suivant.BringToFront(); reetendre.Visible = true; reetendre.BringToFront();
            }
            else
            {
               pictureBox4 .Image = new Bitmap(Application.StartupPath + @"\Pics\Lettres\1comb.jpg");
                p1.URL = Application.StartupPath + @"\FrancaisVoix\" + 0 + "Com.m4a"; p1.controls.play();k = 0;l = 1; label3.Text = combinaison[0];pictureBox4.Visible = label3.Visible = true;
                // label1.Text = "a"; label2.Text = "i"; pictureBox4 .Image = new Bitmap(Application.StartupPath + @"\Pics\Lettres\1comb.jpg"); label1.Visible = true; label2.Visible = true;
                label3.Visible = true;// label5.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
            }

        }

     

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void sTART_Click_1(object sender, EventArgs e)
        {


            if (choix == 2) //combinaison

            {
                p1.URL = Application.StartupPath + @"\FrancaisVoix\" + 0 + "Com.m4a"; p1.controls.play(); label1.Visible = label2.Visible = false;
                label3.Text = combinaison[0]; //"a"; label9.Text = "i";
                pictureBox4 .Image = new Bitmap(Application.StartupPath + @"\Pics\Lettres\1comb.jpg");
               // label8.Visible = true; label9.Visible = true;
                label3.Visible = true; //label4.Visible = true;// label5.Visible = true;
            }

            Start2.Visible = false; pictureBox7.Visible = true;pictureBox4.Visible = true;
            photos.Visible =false ; suivant.Visible = true; suivant.BringToFront(); reetendre.Visible = true; reetendre.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 65;j = 1;startpic.Visible = photos.Visible = true;Start2.Visible = pictureBox4.Visible = false;choix = 1; //{if (i == 65) { startpic.Visible = true;    Start2.Visible = false; }
          //  label1.Visible = label2.Visible = true; label3.Visible = false;
            label3.Visible = false;label1.Visible = false; label2.Visible = false;// label9.Visible = false;
            choix = 1; photos.Visible = false ; pictureBox4.Visible = false;
            label6.Visible = label7.Visible = false; button3.Visible = false;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = button2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
               }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close ();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 65;k = 0;l = 1; startpic.Visible = photos.Visible = false ; Start2.Visible = pictureBox4.Visible = true ;choix = 2;
            label3.Visible = false ;
          //  label3.Visible = true; //label4.Visible = true; label5.Visible = true; label9.Visible = true;
            label1.Visible = label2.Visible = false;// label8.Visible = label9.Visible = true;
            choix = 2; photos.Visible = false; pictureBox4.Visible = true;
            label6.Visible = label7.Visible = false; button3.Visible = false;
            panel2.Visible = false;pictureBox3.BringToFront();
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            if (choix == 1)
            {
                p1.URL = Application.StartupPath + @"\FrancaisVoix\" + j + "pro.m4a"; p1.controls.play();
                i++; j++;
                if (i == 91 || j==27)
                {
                    label2.Hide(); label1.Hide(); photos.Hide(); suivant.Hide(); reetendre.Hide(); label6.Visible = label7.Visible = button3.Visible = true;
                    //   MessageBox.Show("Yupi!Vous avez vu tous l Alphabet.\n Voulez vous la repeter?","Prononciation",MessageBoxButtons.YesNo,MessageBoxIcon.Question );

                }

                else
                {
                    Bitmap bp = new Bitmap(Application.StartupPath + @"\Pics\Lettres\" + j + "pronon.jpg");
                    photos.Image = bp;
                    label1.Text = ((char)(i)).ToString();
                    label2.Text = ((char)(i + 32)).ToString();
                }
            }
            else
            {
                if (k == 5 || l==6)
                {pictureBox4 .Hide(); suivant.Hide(); reetendre.Hide(); label6.Visible = label7.Visible = button3.Visible = true;
                    label3 .Hide(); pictureBox4 .Hide(); suivant.Hide(); reetendre.Hide(); label3.Hide();
                }
                else
                {

                    k++; l++;
                    p1.URL = Application.StartupPath + @"\FrancaisVoix\" + k + "com.m4a"; p1.controls.play(); label3 .Text =combinaison[k];
                    //label9.Text = voyelles[combinaison[k + 1]].ToString();
                    //label5.Text = label8.Text + label9.Text;
                    Bitmap bp = new Bitmap(Application.StartupPath + @"\Pics\Lettres\" + l + "comb.jpg");
                   pictureBox4 .Image = bp;
                }

            }
        }
        

        private void startpic_Click(object sender, EventArgs e)
        {  if (choix==1)//alphabet
            {
                p1.URL = Application.StartupPath + @"\FrancaisVoix\" + 0 + "pro.m4a"; p1.controls.play(); label1.Text = "A"; label2.Text = "a"; photos.Image = new Bitmap(Application.StartupPath + @"\Pics\Lettres\1pronon.jpg");
                label1.Visible = true; label2.Visible = true;
                startpic.Visible = false; pictureBox7.Visible = true;pictureBox4.Visible = false;
                photos.Visible = true; suivant.Visible = true; suivant.BringToFront(); reetendre.Visible = true; reetendre.BringToFront();
            }
           //else if(choix==2) //combinaison
           // {
           //     p1.URL = Application.StartupPath + @"\FrancaisVoix\" + 0 + "Comb.m4a"; p1.controls.play();label1.Visible = label2.Visible = false;
           //     label8.Text = "a"; label9.Text = "i";photos.Image =new Bitmap( Application.StartupPath + @"\Pics\Lettres\1comb.jpg");
           //     label8.Visible = true; label9.Visible = true;label3.Visible = true;label4.Visible = true;label5.Visible = true;
           // }
         
            startpic.Visible = false; pictureBox7.Visible = true;
            photos.Visible = true; suivant.Visible = true; suivant.BringToFront(); reetendre.Visible = true; reetendre.BringToFront();
        }


       
      
    }
}
