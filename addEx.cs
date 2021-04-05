using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace  Start 
{
    public partial class addEx : Form
    {
        public addEx()
        {
            InitializeComponent();prof.Load(Application.StartupPath + "\\Prof.xml");// nodeLecon = prof.SelectSingleNode("Prof/Francais/Conjugaison2");
        }
        XmlNode nodeQuestions , nodeChoices;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false; 
            groupBox2.Visible = true; 
            groupBox4.Visible = false;
        }
        RadioButton rd;
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
                foreach (RadioButton rb in groupBox3.Controls) 
                {
                    if (rb.Checked)
                    {
                        rd = rb;
                        nodeQuestions = prof.SelectSingleNode("Prof/Francais/" + rb.Name + "/Questions");
                       
                        nodeChoices = prof.SelectSingleNode("Prof/Francais/" + rb.Name + "/Choices"); 
                    } 
                }
            else 
                foreach (RadioButton rbM in groupBox2.Controls)
                    if (rbM.Checked) 
                    {
                        rd = rbM; 
                        nodeQuestions = prof.SelectSingleNode("Prof/Maths/" + rbM.Name + "/Questions"); 
                        nodeChoices = prof.SelectSingleNode("Prof/Maths/" + rbM.Name + "/Choices"); 
                    }
                    else
                        foreach (RadioButton rbS in groupBox4.Controls) 
                            if (rbS.Checked) 
                            {
                                rd = rbS; 
                                nodeQuestions = prof.SelectSingleNode("Prof/Sciences/" + rbS.Name + "/Questions");
                                nodeChoices = prof.SelectSingleNode("Prof/Sciences/" + rbS.Name + "/Choices");
                            }
            if (nodeQuestions == null) { MessageBox.Show("Choisis une lecon"); return; }
            label3.Visible = false ;
            groupBox3.Visible = groupBox2.Visible = groupBox1.Visible=groupBox4.Visible  = false;
            button2.Visible = false;
            button1.Visible = true;
            ds.ReadXml(Application.StartupPath + "\\Prof.xml");
            dataGridView1.Visible = true; 
        }
        DataSet ds=new DataSet ();

        string question="",choices="";
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void Perimetre_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox2.Visible = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        string exercices;DataRow[] dr;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           for(int i=0;i<19;i++)
                exercices+= Variables.exSup[i]+",";exercices=exercices.Remove(exercices.LastIndexOf(','));dr[0]["exSupp"]=exercices;Variables.XmlWriter(Application.StartupPath + "\\users.xml");
            this.Close();
            Variables.intro.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            CryptageEtHachage.HashXmlUsers(Variables.UserNom, Variables.UserPass, Application.StartupPath + "\\users.xml");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string[] ques=new string[20], choix1 = new string[20], choix2 = new string[20], choix3 = new string[20];
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0) ques[e.RowIndex] = e.FormattedValue.ToString();
            else if (e.ColumnIndex == 1) choix1 [e.RowIndex] = e.FormattedValue.ToString();
            else if (e.ColumnIndex == 2) choix2[e.RowIndex] = e.FormattedValue.ToString();
            else if (e.ColumnIndex == 3) choix3[e.RowIndex] = e.FormattedValue.ToString();
        }

        private void addEx_Load(object sender, EventArgs e)
        {
            dr = Variables.XmlReader(Application.StartupPath + "\\users.xml");
        }
        XmlDocument prof = new XmlDocument();
        private void button1_Click(object sender, EventArgs e)
        {
            Variables.exSup[int.Parse(rd.Tag.ToString())]= prof.GetElementsByTagName(rd.Name)[0].InnerText.Split(',').Length.ToString();
            for (int j = 0; j < dataGridView1.Rows.Count-1; j++) if(ques[j]=="" || choix1[j]=="" || choix2[j] == ""|| choix3[j] == "") { MessageBox.Show("Cases manques");return; }
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++) { question += ques[i] + ","; choices += choix1[i] + "," + choix2[i] + "," + choix3[i] + ","; }


          
            if (nodeQuestions.InnerText == "0")
                nodeQuestions.InnerText = ""; 
            else question=question.Insert(0, ",");

            question= question.Remove(question.LastIndexOf(','));
            nodeQuestions.InnerText += question;
            if (nodeChoices.InnerText == "0") 
                nodeChoices.InnerText = "";
            else choices = choices.Insert(0, ",");
            choices= choices.Remove(choices.LastIndexOf(','));
            nodeChoices.InnerText += choices ;
            prof.Save(Application.StartupPath + "\\Prof.xml");
            
           

        }
    }
}
