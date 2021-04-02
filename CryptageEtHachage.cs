using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Start
{
    class CryptageEtHachage
    {
        private static DESCryptoServiceProvider GenerateKey()
        {
            DESCryptoServiceProvider desCrypto = new DESCryptoServiceProvider();
            byte[] k = { 0, 1, 2, 3, 4, 5, 6, 7 };
            desCrypto.Key = k;
            byte[] iv = { 1, 1, 1, 1, 1, 1, 1, 1 };
            desCrypto.IV = iv;
            return desCrypto;
        }
        public static string DeChiffrer(string MotChiffre)
        {
            try
            {
                if (String.IsNullOrEmpty(MotChiffre))
                    return "??????????";
                DESCryptoServiceProvider cryptoProvider = GenerateKey();
                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(MotChiffre));
                CryptoStream cryptoStream = new CryptoStream(memoryStream,cryptoProvider.CreateDecryptor(cryptoProvider.Key, cryptoProvider.IV), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cryptoStream);
                return reader.ReadToEnd();
            }
            catch
            {
                return "??????????";
            }
        }
        public  static void DeCrypNode(XmlNode x)
        {
            if (!x.HasChildNodes)
            {
                x.InnerText = DeChiffrer(x.InnerText); 
            }

            else for (int i = 0; i < x.ChildNodes.Count; i++)
            {
                    DeCrypNode(x.ChildNodes[i]);

            }

        }
        static string hash = "hashP@ss&ScorePr0jet2o2oH_I_H";
        public static string HashPasswordsAndScores(string password)
        {
            string pass=password ;
            byte[] data = UTF8Encoding.UTF8.GetBytes(pass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform trans = tripleDES.CreateEncryptor();
                    byte[] results = trans.TransformFinalBlock(data, 0, data.Length);
                    pass = Convert.ToBase64String(results, 0, results.Length);

                }
            }
            return pass;
        }
        public static string Combine(string password)
        {
            string gg=password ;
            byte[] data = Convert.FromBase64String(gg);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform trans = tripleDES.CreateDecryptor ();
                    byte[] results = trans.TransformFinalBlock(data, 0, data.Length);
                    gg =UTF8Encoding.UTF8.GetString(results);

                }
            }
            return gg;
        }
       static DataSet ds; static DataTable dt;static DataRow  [] dr;
        public static void HashXmlUsers(string name,string pass,string path)
        {
            ds = new DataSet();
            ds.ReadXml(path);
            dt = ds.Tables[0];
            dr = dt.Select("(([user] = '" + name  + "') AND ([pass] = '" + pass + "'))");
            for (int i = 0; i < 39; i++) dr[0][i] = HashPasswordsAndScores   (dr[0][i].ToString());
            ds.WriteXml(path);

        }
        public static void CombineUsersElements(string name, string pass, string path)
        {
            ds = new DataSet();
            ds.ReadXml(path);
            dt = ds.Tables[0];
            dr = dt.Select("(([user] = '" + name + "') AND ([pass] = '" + pass + "'))");
         for(int i=0;i<39;i++)   dr[0][i] = Combine (dr[0][i].ToString());
           // dr[0]["Sens"] = Combine(dr[0]["Sens"].ToString()); dr[0]["Conjugaison1"] = Combine(dr[0]["Conjugaison1"].ToString());
            ds.WriteXml(path);
        }
    }
}
