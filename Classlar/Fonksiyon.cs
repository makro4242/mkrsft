using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Makrosoft.Classlar
{
    class Fonksiyon
    {
       
        public int Lokasyon = 0;
        public int iptal = 0;
        public int fileid = 0;
        public int hidden = 0;
        public int kilitli = 0;
        public int degisti = 0;
        public int cr_user = 0;
        public int ls_user = 0;
        public string ozelalan1 = "";
        public string ozelalan2 = "";
        public string ozelalan3 = "";
        
        public SqlConnection Baglan()
        {
            string provider = "Data Source=THINKPAD;initial Catalog=SehasoftV10;Persist security info=True;User ID=sa;Password=sapass";
            SqlConnection conn = new SqlConnection(provider);
            conn.Open();
            return conn;
        }
        public DataTable TabloCek(string sql)
        {
           
            DataTable tb = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, this.Baglan());
            adap.Fill(tb);
            return tb;
        }
        public DataRow SatirCek(string sql)
        {
            DataRow satir = TabloCek(sql).Rows[0];
            return satir;
        }
        public void isle(string sql)
        {
            SqlCommand islem = new SqlCommand(sql, this.Baglan());
            islem.ExecuteNonQuery();
        }
    }
}
