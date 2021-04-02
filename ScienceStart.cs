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
    public partial class ScienceStart : Form
    {
        public ScienceStart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");

            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.intro.Show();
            Variables.intro.ShowInTaskbar = true;
        }

        private void ScienceStart_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(science1, "Sensation");
            toolTip1.SetToolTip(science2, "Etre vivants et non vivants");
            toolTip1.SetToolTip(science3, "Les planetes");
        }

        private void science1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anatomy anatomy = new Anatomy();
            anatomy.Show();
        }

        private void science3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Planetes planetes = new Planetes();
            planetes.Show();
        }

        private void science2_Click(object sender, EventArgs e)
        {
            this.Hide();
            livingGame living = new livingGame();
            living.Show();
        }
    }
}
