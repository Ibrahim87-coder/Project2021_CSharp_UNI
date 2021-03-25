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
    public partial class cours_de_formes_geo : Form
    {
        public cours_de_formes_geo()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\videos\\CoursFormes.mp4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");


            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void cours_de_formes_geo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
