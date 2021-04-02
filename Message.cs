using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Start 
{
    public partial class Message : Form
    {
        bool o;Queue q,a;
        public Message()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//retourne
        {
            this.Close();
            Variables.intro.Show();
        }
        public static Queue ShowNewMessage(string s, out Queue a)
        {
            Queue q = new Queue();
            a = new Queue(); 
            string z;
            DataSet ds = new DataSet(),ds2=new DataSet();
            int i = 0;
            ds2.ReadXml ("users.xml");
            ds.ReadXml(@"Message.xml");
            DataTable dt = ds.Tables[0],dt2=ds2.Tables[0];
            while (i < dt.Rows.Count)
            {
                if ((s == dt.Rows[i][1].ToString()) && (dt.Rows[i][3].ToString() == "false"))
                {
                    q.Enqueue(dt.Rows[i][2].ToString());
                    DataRow[] dr = dt2.Select("(([user] = '" +dt.Rows[i][1].ToString() + "'))");
                    z =dr[0]["Type"].ToString();
                   //done 
                   // dt.Rows[i][0].ToString() shu hwe l maalm yaane on va chercher dans users a la type dr[0]["type"] de hyda select user  avec cryptage et decryptage ll type
                    a.Enqueue(z + " " + dt.Rows[i][0].ToString());
                    dt.Rows[i][3] = "true";
                }
                i++;
            }
            ds.WriteXml(@"Message.xml");

            return q;
        }
        private void Message_Load(object sender, EventArgs e)//load
        {
            textBox1.Focus();

            q = ShowNewMessage(Variables.UserNom ,out a); 
            int w = q.Count;//variables.username//done
            for (int i = 0; i < w; i++)
            {
                listBox1.Items.Insert(0,"Message de "+a.Dequeue()+":"+ q.Dequeue());
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)//focus
        {
            if (e.KeyCode == Keys.Enter) textBox2.Focus();
        }
        private void button4_Click(object sender, EventArgs e)//totale message
        {
           TotaleMessage t = new TotaleMessage();
            t.Show();
        }
        public static void WriteMessage(string u1, string u2, string tm, string dateTime)//message
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"Message.xml");
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.NewRow(); 
            dr[0] = u1;
            dr[1] = u2;
            dr[2] = tm + "   " + dateTime; dr[3] = "false";
            dt.Rows.Add(dr);
            ds.WriteXml(@"Message.xml");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void merssagesRecusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (merssagesRecusToolStripMenuItem.Text == "Messages recus")
            {
                pictureBox1.Show();
                button1.Hide();
                groupBox1.Visible = false;
                panel1.Visible = true; 
                merssagesRecusToolStripMenuItem.Text = "Ecrire un message";
               
            }
             else
            {
                button1.Show();
                groupBox1.Visible =true ;
                panel1.Visible = false ;
                merssagesRecusToolStripMenuItem.Text = "Messages recus";
                pictureBox1.Hide();
            }
        }
        TotaleMessage t = new TotaleMessage();
        private void tousLesMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            t.Show();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static bool RechercheDeUserName(string s)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\users.xml");
            DataTable dt = ds.Tables[0];
            DataRow[] d = dt.Select("[user]='" +CryptageEtHachage.HashPasswordsAndScores( s )+ "'");//cryptage de s//ok
            if (d.Length == 0) return false;
            else return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void Message_FormClosed(object sender, FormClosedEventArgs e)
        {

            Variables.intro.Show();
            Variables.intro.pictureBox2.Image = Properties.Resources.Msg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            button1.Visible = true;
            panel1.Visible = false;
            groupBox1.Visible = true;
            t.Hide();
          
        }

        private void button2_Click(object sender, EventArgs e)//envoyer
        {
            if((textBox1.Text.Length!=0)&&(textBox2.Text.Length != 0))
            {
                string u = textBox1.Text;
                if (Variables.UserNom .ToUpper() != u.ToUpper())//esmo hwe variables.username//
                {
                    o = true;
                   o=RechercheDeUserName(u);
                    if (o)
                    {
                        WriteMessage(Variables.UserNom , u, textBox2.Text,dateTimePicker1.Value.ToLocalTime().ToString());//from username to l u zabta
                        textBox1.ResetText();
                        textBox2.ResetText();
                    }
                    else { MessageBox.Show("User Name N'existe pas"); }
                }
                else { MessageBox.Show("Interdit de envoyer une message a tu"); }
            }
            else { MessageBox.Show("L'information manque"); }
        }
    }
}
