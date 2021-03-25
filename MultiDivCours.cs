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
    public partial class cours_de_multip_div : Form
    {
        public cours_de_multip_div()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.matiere.Show();
            Variables.matiere.ShowInTaskbar = true;
        }

        private void MultiDivCours_Load(object sender, EventArgs e)
        {
              
             axAcroPDF5.Visible = true;
                axAcroPDF5.Height = 400;
                axAcroPDF5.Width = 750;
                axAcroPDF5.Location = new Point(160, 120);
               axAcroPDF5.LoadFile(@"D:\Project2021\Project2021\Start\bin\Debug\pdf\MultiDiv.pdf");
            
        }

        //private void MultiDivCours_VisibleChanged(object sender, EventArgs e)
        //{
        //    axAcroPDF5.Visible = true;
        //    axAcroPDF5.Height = 400;
        //    axAcroPDF5.Width = 750;
        //    axAcroPDF5.Location = new Point(160, 120);
        //    //  axAcroPDF5.LoadFile(@"D:\Project2021\Project2021\Start\bin\Debug\pdf\MultiDiv.pdf");

        //}

        ////private void MultiDivCours_VisibleChanged(object sender, EventArgs e)
        ////{
        ////    axAcroPDF5.Visible = true;
        ////    axAcroPDF5.Height = 400;
        ////    axAcroPDF5.Width = 750;
        ////    axAcroPDF5.Location = new Point(160, 120);

        ////}
    }
}
