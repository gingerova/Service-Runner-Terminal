using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Class1

    {
        private SqlConnection con;
        private SqlCommand comm;
        string str = ConfigurationManager.AppSettings["CONNECTIONSTRING"];
        string fp = ConfigurationManager.AppSettings["FILEPATH"];

        public void runSP()
        {
            con = new SqlConnection(str);
           
            con.Open();
            string dosya_yolu = @"" + fp + "";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            DateTime dt = DateTime.Now;
            sw.WriteLine(dt + "The service was ran.");
            sw.Flush();
            sw.Close();
            fs.Close();
            con.Close();
        }
    }
}
