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
    public partial class jeux_de_Suites_de_nombres : Form
    {
        
        public jeux_de_Suites_de_nombres()
        {
            InitializeComponent();
            
        }
        public bool MoveUp, MoveDown, MoveRight, MoveLeft;
        public int speed = 5;
        int t = 0;

        void  WinOrNot()
        {
            if (redbtn >= 3)
            {
                TimerGame.Stop();
                Timer.Stop();
                lblLost.Visible = true;
                
            }
            if (BeePic.Bounds.IntersectsWith(PicBeehive.Bounds))
            {
                TimerGame.Stop();
                Timer.Stop();
                lblWin.Visible = true;
            }
            
        }
        DataRow[] dr;
        private void SuitesNbGame_Load(object sender, EventArgs e)
        {

            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
            if (int.Parse(dr[0]["Suitenb"].ToString()) != 0)
            {
                label3.Text = "meilleur temps : " + dr[0]["Suitenb"]+" s"; 
            }
        }

        private void SuitesNbGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = true;
            }
            timershow();
        }
        void timershow()
        {
            if ((t == 0) && (BeePic.Location != new Point(50, 40)))
            {
                Timer.Start();
              
            }
        }
        private void SuitesNbGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = false;
            }
        }
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            MoveBee();
            Intersection();
            WinOrNot();
        }

        void Restart()
        {
            if ((int.Parse(dr[0]["Suitenb"].ToString()) > t) && (BeePic.Bounds.IntersectsWith(PicBeehive.Bounds)))
            {
                dr[0]["Suitenb"] = t;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");
                label3.Text = "meilleur temps : " + dr[0]["Suitenb"] + " s";

            }

            redbtn = 0;
            lblLost.Visible = false;
            lblWin.Visible = false;

            BeePic.Location = new Point(50, 40);
            var btnsVrai = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12 };
            var btnsFaux = new List<Button> { button1,button23,button3,button4,button5,button6,button7,
                                              button8,button10,button11,button15,button16,button17,button19,
                                              button20,button21,button26,button27,button28,button32,button33,button34,button36
                                             };
            for (int i = 0; i < 12; i++) btnsVrai[i].BackColor = Color.SpringGreen;
            for (int i = 0; i < 22; i++) { btnsFaux[i].BackColor = Color.SpringGreen; btnsFaux[i].Tag = ""; }
            t = 0;
            TimeShow.Text = "0 s";
            timershow();

            

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Restart();
            TimerGame.Start();
            

        }

        private void TimerShow_Tick(object sender, EventArgs e)
        {

            t++;
            TimeShow.Text = t.ToString() + " s";
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if ((int.Parse(dr[0]["Suitenb"].ToString()) > t) && BeePic.Bounds.IntersectsWith(PicBeehive.Bounds))
            {
                dr[0]["Suitenb"] = t;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((int.Parse(dr[0]["Suitenb"].ToString())> t)&& (BeePic.Bounds.IntersectsWith(PicBeehive.Bounds)))
            {
                dr[0]["Suitenb"] = t;
                Variables.XmlWriter(Application.StartupPath + "\\users.xml");

            }
            Application.Exit();

            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

        }

        int redbtn =0;
        void Intersection()
        {
            var btnsVrai = new List<Button> { btn1 ,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btn10,btn11,btn12};
            var btnsFaux = new List<Button> { button1,button23,button3,button4,button5,button6,button7,
                                              button8,button10,button11,button15,button16,button17,button19,
                                              button20,button21,button26,button27,button28,button32,button33,button34,button36 
                                             };
            for (int i = 0; i < 12; i++)
            {
                if (BeePic.Bounds.IntersectsWith(btnsVrai[i].Bounds))
                {
                    btnsVrai[i].BackColor = Color.Green;
                }
            }
            for (int i = 0; i < 22; i++)
            {
                if (BeePic.Bounds.IntersectsWith(btnsFaux[i].Bounds))
                {
                    btnsFaux[i].BackColor = Color.Red;
                    
                }
                if (((string)btnsFaux[i].Tag != "Hi")&&(btnsFaux[i].BackColor == Color.Red))
                {
                    redbtn ++;
                    btnsFaux[i].Tag = "Hi";
                }
            }
        }
        void MoveBee()
        {
            if (MoveLeft == true && BeePic.Left > 0)
            {
                BeePic.Left -= speed;
            }

            if (MoveRight == true && BeePic.Left < 600)
            {
                BeePic.Left += speed;
            }

            if (MoveUp == true && BeePic.Top > 0)
            {
                BeePic.Top -= speed;
            }

            if (MoveDown == true && BeePic.Top < 380)
            {
                BeePic.Top += speed;
            }
        }
    }
}
