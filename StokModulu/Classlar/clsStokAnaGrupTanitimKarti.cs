using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Makrosoft.StokModulu.Classlar
{
    class clsStokAnaGrupTanitimKarti
    {
        Makrosoft.Classlar.Fonksiyon Dbase = new Makrosoft.Classlar.Fonksiyon();
    
        public DataTable Listele()
        {
            string sql = "SELECT * FROM STOK_ANA_GRUPLARI ORDER BY sag_kod";
            DataTable tablo = Dbase.TabloCek(sql);
            return tablo;
        }
        public void Ekle(int sag_Lokasyon, int sag_iptal, int sag_fileid, int sag_hidden, int sag_kilitli, int sag_degisti, int sag_create_user, int sag_lastup_user, string sag_ozelalan1, string sag_ozelalan2, string sag_ozelalan3, string sag_kod, string sag_isim)
        {
            string sql = "EXECUTE SP_STOK_ANA_GRUPLARI_EKLE " + sag_Lokasyon + "," + sag_iptal + "," + sag_fileid + "," + sag_hidden + "," + sag_kilitli + ","+sag_degisti+"," + sag_create_user + ","+sag_lastup_user+",'"+sag_ozelalan1+"','"+sag_ozelalan2+"','"+sag_ozelalan3+"','"+sag_kod+"','"+sag_isim+"'";
            Dbase.isle(sql);
        }
        public void Sil(int sag_KAYno)
        {
            string sql="EXECUTE SP_STOK_ANA_GRUPLARI_SIL " + sag_KAYno ;
            Dbase.isle(sql);
        }
        public void Guncelle(int sag_KAYno,int sag_Lokasyon, int sag_iptal, int sag_fileid, int sag_hidden, int sag_kilitli, int sag_degisti, int sag_create_user, int sag_lastup_user, string sag_ozelalan1, string sag_ozelalan2, string sag_ozelalan3, string sag_kod, string sag_isim)
        {
            string sql = "EXECUTE SP_STOK_ANA_GRUPLARI_GUNCELLE " + sag_KAYno +","+sag_Lokasyon + "," + sag_iptal + "," + sag_fileid + "," + sag_hidden + "," + sag_kilitli + "," + sag_degisti + "," + sag_create_user + "," + sag_lastup_user + ",'" + sag_ozelalan1 + "','" + sag_ozelalan2 + "','" + sag_ozelalan3 + "','" + sag_kod + "','" + sag_isim + "'";
            Dbase.isle(sql);
        }
        public DataRow Ac(int sag_KAYno)
        {
            return Dbase.SatirCek("SELECT * FROM STOK_ANA_GRUPLARI WHERE sag_KAYNO=" + sag_KAYno);
        }
    }
}
