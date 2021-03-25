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
    public partial class cours_de_complement : Form
    {
        public cours_de_complement()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.matiere.Show();
            this.ShowInTaskbar = false;
            Variables.matiere.ShowInTaskbar = true;

        }

        private void ComplemCours_Load(object sender, EventArgs e)
        {
            axAcroPDF5.LoadFile( Application.StartupPath+ @"\pdf\Complement-de-10.pdf");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
