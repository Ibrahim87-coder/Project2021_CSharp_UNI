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
    public partial class cours_de_moitie_double : Form
    {
        public cours_de_moitie_double()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 

            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void MoitieCours_Load(object sender, EventArgs e)
        {
          
            axAcroPDF3.LoadFile(Application.StartupPath+@"\pdf\doubleEtmotiee.pdf");
        }
    }
}
