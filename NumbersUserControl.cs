using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class NumbersUserControl : UserControl
    {
        public NumbersUserControl()
        {
            InitializeComponent();
        }

        private void NumbersUserControl_Load(object sender, EventArgs e)
        {
            mediaplayer.URL = Application.StartupPath + "\\Sounds\\1.m4a";
            mediaplayer.Ctlenabled = true;

        }

        private void nb1_Click(object sender, EventArgs e)
        {
            
           

            string x;
            PictureBox pic = (PictureBox)sender;
            nbimg.Image = pic.Image;
            string picEdited = pic.Name.Remove(0, 2);

            mediaplayer.URL = Application.StartupPath + "\\Sounds\\" + picEdited+ ".m4a";
            mediaplayer.Ctlenabled = true;


            if ((string)pic.Tag == "1"|| (string)pic.Tag=="3")
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\blueBack.png");
                this.BackgroundImage = bitmap;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if ((string)pic.Tag == "2" || (string)pic.Tag == "4" || (string)pic.Tag == "9")
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\redBack.png");
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackgroundImage = bitmap;
                this.BackgroundImageLayout = ImageLayout.Stretch;

            }

            if ((string)pic.Tag == "5" || (string)pic.Tag == "7")
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\greenBack.jpg");
                this.BackgroundImage = bitmap;
            }
            if ((string)pic.Tag == "6" || (string)pic.Tag == "7")
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\yellowBack.jpg");
                this.BackgroundImage = bitmap;
            }
            if ((string)pic.Tag == "8" || (string)pic.Tag == "10")
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Pics\\pinkBack.jpg");
                this.BackgroundImage = bitmap;
            }

            x = pic.Name[pic.Name.Length - 1].ToString();
            if (x == "0")
            {
                x = "10";
               
            }
            

            string[] tabnb = { "Un","Deux", "Trois", "Quatre", "Cinq", "Six", "Sept", "Huit", "Neuf" ,"Dix"};
            
            nbtxt.Text = tabnb[int.Parse(x)-1];
            Bitmap bitmap1 = new Bitmap(Application.StartupPath +"\\Pics\\" + x + ".png");
            if (x == "10")
            {
                this.res.Visible = true;
                this.resPhoto.Visible = true;
            }
            things.Image = bitmap1;
        }

        private void resPhoto_Click(object sender, EventArgs e)
        {
            cours_Resumé_de_nombres res = new cours_Resumé_de_nombres();
            res.Show();
        }
    }
}
