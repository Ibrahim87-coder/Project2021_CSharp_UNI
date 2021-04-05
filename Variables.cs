using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Start
{
    class Variables
    {
        public static Introduction intro;
        public static MatiereStart matiere;
      
        public static ScienceStart science;
        
        public static Page_entrée formLogin;
        public static Message m;

        public static Jeux Jeux;

        public static  cours_de_grammaire g = new cours_de_grammaire();

        
        //static string  [] exSuppNb=new string[19];
        
        public static string [] exSup { get; set; }
        //{
        //    set { exSuppNb  = value; }
        //    get
        //    {
        //        return  exSuppNb ;
        //    }
        //}
        // For save image of user (boy or girl)
        //static Bitmap b;
        //static int lvlmt, lvlfr;
       public static int levelmt { get; set; }
        //{
        //    get { return lvlmt; }
        //    set { lvlmt = value; }
        //}

       public static int levelfr { get; set; }
        //{
        //    get { return lvlfr; }
        //    set { lvlfr = value; }
        //}
        public static Bitmap B { get; set; }
        //{
        //    set { b = value; }
        //    get { return b; }
            
        //}
       
        //static int count;
        
        public static int counter { get; set; }
        //{
        //    get { return count; }
        //    set { count = value; }
        //}
        
        //static string MatiereNom;
        
        public static string MatiereNomPublic { get; set; }
        //{
        //    get { return MatiereNom; }
        //    set { MatiereNom = value; }
        //}

        // Nom de l'utilisateur
      //  static string usernom;
        public static string UserNom { get; set; }
        //{
        //    get { return usernom; }
        //    set { usernom = value; }
        //}
        public static bool ExisteMessage(string s)
        {
            DataSet ds = new DataSet(); int i = 0; bool o = false;
           ds.ReadXml("message.xml");
            DataTable dt = ds.Tables[0];
            while (i < dt.Rows.Count)
            {
                if ((s == dt.Rows[i][1].ToString()) && (dt.Rows[i][3].ToString() == "false")) o = true;
                i++;
            }
            return o;
        }
        static DataTable dt;
        static DataRow[] dr;
        static DataSet ds;
        public static DataRow[] XmlReader(string path)
        {
            ds = new DataSet();
            ds.ReadXml(path);
            dt = ds.Tables[0];
            dr = dt.Select("(([user] = '" + Variables.UserNom + "') AND ([pass] = '" +    Variables.UserPass  + "'))");
            return dr;
        }

        public static void XmlWriter(string path)
        {
            ds.WriteXml(path);

        }
        // bool eleve ou prof
        //static bool type;
        public static bool Type { get; set; }
        //{
        //    // if prof true else eleve
        //    get { return type ; }
        //    set { type = value; }
        //}
        
        //static string pass;
        public static string UserPass { get; set; } 
        //{ get { return pass; } set { pass = value; } }

        // form de francais
        public static bool Exit = true;

    }
}
