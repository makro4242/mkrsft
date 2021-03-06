﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Makrosoft.CKartlar
{
    public class CFonksiyon
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
        public static SqlConnection conn = new SqlConnection("Data Source=192.168.1.5;initial Catalog=Makrosoft_V10;Persist security info=True;User ID=sa;Password=3201479322");
        public static SqlCommand Sorgu;

        public static SqlConnection Baglan()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public static void SorguAyarla()
        {
            Sorgu = new SqlCommand();
            Sorgu.Connection = conn;
            Sorgu.CommandText = "";
        }


        public DataTable TabloCek(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
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
            SqlCommand islem = new SqlCommand(sql, Baglan());
            islem.ExecuteNonQuery();
        }

    }
}
