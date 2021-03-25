using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Start
{
    public partial class jeux_de_Priorité : Form
    {
        public jeux_de_Priorité()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int rd1, rd2, rd3, rd4, nb1, nb2, nb3, operateurPlusFoix, score, i = 0;
        int cte = 0;DataRow[] dr;

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Priorite"].ToString()) < score)
            {

                dr[0]["Priorite"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (int.Parse(dr[0]["Priorite"].ToString()) < score)
            {

                dr[0]["Priorite"] = score;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }

            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        string resultatVrai;
      

        private void reponse2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
          

            if (b.Tag.ToString() == resultatVrai&&cte==0)
            {
                cte++;
                score = score + 5;
                lblScore.Text = "Score : " + score;
                b.BackColor = Color.MediumSpringGreen;
                lblSuivant.Visible = true;
                Suivant.Visible = true;

            }
            if (b.Tag.ToString() !=resultatVrai &&cte==0)
            {
                b.BackColor = Color.Red;
                score = score - 2;
                lblScore.Text = "Score : " + score;
            }
               
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            lblSuivant.Visible = false;
            Suivant.Visible = false;
            cte = 0;
            Button[] btn = { reponse1, reponse2, reponse3, reponse4 };
            for (int i = 0; i < 4; i++)
            {
                btn[i].BackColor = Color.MediumTurquoise;
            }

            if (score < 5)
                LVL_1();
            else 
            if(score<10) LVL_2();
            else  LVL_3();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        void Nombres()
        {
            do
            {
                rd1 = random.Next(0, 4);
                rd2 = random.Next(0, 4);
                rd3 = random.Next(0, 4);
                rd4 = random.Next(0, 4);
            } while ((rd1==rd2)||(rd1==rd3)||(rd1==rd4)||(rd2==rd3)||(rd2==rd4)||(rd3==rd4));
            nb1 = random.Next(1, 10);
            nb2 = random.Next(1, 10);
            nb3 = random.Next(1, 10);
           
            operateurPlusFoix = random.Next(0, 2);
        }

        void LVL_2()
        {
         
            
            Button[] btn = { reponse1, reponse2, reponse3, reponse4 };
            string[] oper = { "-", "/" };
            operateurPlusFoix = random.Next(0, 2);
            do
            {
                rd1 = random.Next(0, 4);
                rd2 = random.Next(0, 4);
                rd3 = random.Next(0, 4);
                rd4 = random.Next(0, 4);
            } while ((rd1 == rd2) || (rd1 == rd3) || (rd1 == rd4) || (rd2 == rd3) || (rd2 == rd4) || (rd3 == rd4));
           
           
            if ("-" == oper[operateurPlusFoix])
            {
                do
                {
                    nb1 = random.Next(1, 10);
                    nb2 = random.Next(1, 10);
                    nb3 = random.Next(1, 10);

                } while ((nb2 % nb3 != 0) || (nb1 < (nb2/nb3)));

                btn[rd4].Text = (nb1 - nb2 / nb3).ToString(); // La reponse juste
                resultatVrai = (nb1 - nb2 / nb3).ToString();
                btn[rd4].Tag = btn[rd4].Text;

                btn[rd1].Text = ((nb1 - nb2) / nb3).ToString(); // La reponse fausse
                btn[rd1].Tag = btn[rd1].Text;

                btn[rd2].Text = random.Next(1,5).ToString();// La reponse fausse
                btn[rd2].Tag = btn[rd2].Text;

                btn[rd3].Text = random.Next(5, 10).ToString();// La reponse fausse
                btn[rd3].Tag = btn[rd3].Text;

                txtOperation.Text = nb1.ToString() + oper[0] + nb2.ToString() + oper[1] + nb3.ToString();
            }
            else
            {
                do
                {
                    nb1 = random.Next(1, 10);
                    nb2 = random.Next(1, 10);
                    nb3 = random.Next(1, 10);

                } while ((nb1 % nb2 != 0) || ((nb1 / nb2) < nb3)||(nb3-nb2)==0 );

                btn[rd4].Text = (nb1 / nb2 - nb3).ToString(); // La reponse juste
                resultatVrai = (nb1 / nb2 - nb3).ToString();
                btn[rd4].Tag = btn[rd4].Text;

                btn[rd1].Text = (nb1 / (nb2 - nb3)).ToString(); // La reponse fausse
                btn[rd1].Tag = btn[rd1].Text;
                btn[rd2].Text = random.Next(1, 5).ToString();// La reponse fausse
                btn[rd2].Tag = btn[rd2].Text;
                btn[rd3].Text = random.Next(5, 10).ToString();// La reponse fausse
                btn[rd3].Tag = btn[rd3].Text;


                txtOperation.Text = nb1.ToString() + oper[1] + nb2.ToString() + oper[0] + nb3.ToString();
            }
        }

        void LVL_1()
        {
           
            Nombres();
            Button[] btn = { reponse1,reponse2,reponse3,reponse4 };
            string[] oper = { "+", "x" };
           
            if ("+" == oper[operateurPlusFoix])
            {
                btn[rd4].Text = (nb1 + nb2 * nb3).ToString(); // La reponse juste
                resultatVrai = (nb1 + nb2 * nb3).ToString();
                btn[rd4].Tag = btn[rd4].Text;


                btn[rd1].Text = ((nb1 + nb2) * nb3).ToString(); // La reponse fausse
                btn[rd1].Tag = btn[rd1].Text;
                btn[rd2].Text = ((nb1 * nb2) + nb3).ToString();// La reponse fausse
                btn[rd2].Tag = btn[rd2].Text;
                btn[rd3].Text = (nb1 * (nb2 + nb3)).ToString();// La reponse fausse
                btn[rd3].Tag = btn[rd3].Text;

                txtOperation.Text = nb1.ToString() + oper[0] + nb2.ToString() + oper[1] + nb3.ToString();
            }
            else
            {
                btn[rd4].Text = (nb1 * nb2 + nb3).ToString();// La reponse juste
                resultatVrai = (nb1 * nb2 + nb3).ToString();
                btn[rd4].Tag = btn[rd4].Text;

                btn[rd1].Text = (nb1 * (nb2 + nb3)).ToString();// La reponse fausse
                btn[rd1].Tag = btn[rd1].Text;
                btn[rd2].Text = (nb1 + (nb2 * nb3)).ToString();// La reponse fausse
                btn[rd2].Tag = btn[rd2].Text;
                btn[rd3].Text = ((nb1 + nb2) * nb3).ToString();// La reponse fausse
                btn[rd3].Tag = btn[rd3].Text;
                txtOperation.Text = nb1.ToString() + oper[1] + nb2.ToString() + oper[0] + nb3.ToString();
            }
        }
        void LVL_3()
        {

            Button[] btn = { reponse1, reponse2, reponse3, reponse4 };
           
            do
            {
                rd1 = random.Next(0, 4);
                rd2 = random.Next(0, 4);
                rd3 = random.Next(0, 4);
                rd4 = random.Next(0, 4);

            } while ((rd1 == rd2) || (rd1 == rd3) || (rd1 == rd4) || (rd2 == rd3) || (rd2 == rd4) || (rd3 == rd4));

          
            ArrayList array = new ArrayList();
            array.Add("155 - ( 22 + 17 ) ");
            array.Add("66");

            array.Add("62 - ( 23 - 12 ) ");
            array.Add("51");

            array.Add("20 x ( 8 / 4 )");
            array.Add("40");

            array.Add("56 / ( 7 - 5 )");
            array.Add("28");

            array.Add("100 - 26 + 34 ");
            array.Add("108");

            array.Add(" 15 + ( 18 + 2 ) - 21 ");
            array.Add("14");

            array.Add("18 / 9 x 10");
            array.Add("20");

            array.Add("( 14 - ( 8 - 6 ) x 2 )");
            array.Add("24");

            array.Add("11 + ( 5 + 3 ) - 5 x 2");
            array.Add("9");

            array.Add("8 x ( 14 - ( 6 + 3 ) )");
            array.Add("40");

            array.Add("36 x 2 -10 / 2 + 5 x 3 ");
            array.Add("82");

            if (i < 22)
            {
                txtOperation.Text = array[i].ToString();
                btn[rd1].Text = array[i + 1].ToString();
                btn[rd1].Tag = btn[rd1].Text;
                resultatVrai = btn[rd1].Text;

                btn[rd2].Text = random.Next(10, 100).ToString();
                btn[rd2].Tag = btn[rd2].Text;

                btn[rd3].Text = random.Next(10, 100).ToString();
                btn[rd3].Tag = btn[rd3].Text;

                btn[rd4].Text = random.Next(10, 100).ToString();
                btn[rd4].Tag = btn[rd4].Text;
                i = i + 2;
            }
            else txtOperation.Text = "Bravoooo!";
           

            



        }
        private void PrioritéGame_Load(object sender, EventArgs e)
        {
           dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse (dr[0]["Priorite"].ToString()) != 0) 
            {
                HighScore.Text = "meilleur score : " + dr[0]["Priorite"];
                HighScore.Visible = true;
            }
            LVL_1();
        }
    }
}
