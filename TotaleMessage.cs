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
    public partial class TotaleMessage : Form
    {
        Queue q1, q2, a1, a2;
        public TotaleMessage()
        {
            InitializeComponent();
        }

        private void tousLesMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close(); Variables .m.groupBox1.Visible = true ; Variables .m.panel1.Visible = false ;
        }

        private void merssagesRecusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();Variables .m.groupBox1.Visible = false;Variables .m.panel1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.m.Show();
            Variables.m.ShowInTaskbar = true;
        }

        public static void ShowTotaleMessage(string s, out Queue q1, out Queue q2, out Queue a1, out Queue a2)//message
        {
            q1 = new Queue(); q2 = new Queue(); a1 = new Queue(); a2 = new Queue(); string z;
            DataSet ds = new DataSet(),ds2= new DataSet(); int i = 0;ds.ReadXml("message.xml");ds2.ReadXml("users.xml");
            DataTable dt = ds.Tables[0],dt2=ds2.Tables[0];
            while (i < dt.Rows.Count)
            {
                if (s == dt.Rows[i][0].ToString())
                {
                    DataRow[] dr = dt2.Select("(([user] = '" +dt.Rows[i][0].ToString()+ "'))");
                    z = dr[0]["Type"].ToString();

                    q1.Enqueue(dt.Rows[i][2].ToString());  a1.Enqueue(z + " " + dt.Rows[i][1].ToString()); }//dt.Rows[i][1].ToString() bdna naarf l type l hal esm so mnbrm aale avec cryptage w decryptage l typpo
                if (s == dt.Rows[i][1].ToString())
                {
                    DataRow[] dr = dt2.Select("(([user] = '" + CryptageEtHachage.HashPasswordsAndScores(dt.Rows[i][0].ToString()) + "'))");
                    z = CryptageEtHachage.Combine(dr[0]["Type"].ToString());
                    q2.Enqueue(dt.Rows[i][2].ToString()); z = "Prof"; a2.Enqueue(z + " " + dt.Rows[i][0].ToString()); }//dt.Rows[i][0].ToString()  //////////same
                i++;
            }
        }
        private void TotaleMessage_Load(object sender, EventArgs e)//load
        {
           ShowTotaleMessage(Variables.UserNom ,out q1,out q2,out a1,out a2);//username
            int w1 = q1.Count,w2=q2.Count;
            for (int i = 0; i < w1; i++)
            {
                listBox1.Items.Insert(0, "Message a " + a1.Dequeue() + ":" + q1.Dequeue());
            }
            for (int i = 0; i < w2; i++)
            {
                listBox2.Items.Insert(0, "Message de " + a2.Dequeue() + ":" + q2.Dequeue());
            }
        }
        private void button1_Click(object sender, EventArgs e)//retourne
        {
        
        }
    }
}
