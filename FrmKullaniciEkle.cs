using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Makrosoft
{
    public partial class FrmKullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public String KullaniciKayitNo = "";
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        public static void Temizle(Control Ctrl)
        {
        }

        public void KullaniciKaydet()
        {
            Boolean durum = false;
            CKartlar.CFonksiyon.Baglan();
            CKartlar.CFonksiyon.SorguAyarla();
            CKartlar.CFonksiyon.Sorgu.CommandText = "INSERT INTO KULLANICILAR (Kull_Adi,Kull_Sifre," +
                                                    "Kull_UzunAdi,Kull_EMail,Kull_SifreDegisim,Kull_Pasif,Kull_IlkIP," +
                                                    "Kull_SonIP) VALUES ('@Kull_Adi','@Kull_Sifre','@Kull_UzunAdi'," +
                                                    "'@Kull_EMail','@Kull_SifreDegisim','@Kull_Pasif','@Kull_IlkIP','@Kull_SonIP')";

            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_Adi", txtKullaniciAdi.Text).ToString();
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_Sifre", txtSifre.Text).ToString();
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_UzunAdi", txtUzunAdi.Text).ToString();
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_EMail", txtEMail.Text).ToString();
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_SifreDegisim", cmbSifreDegis.Text).ToString();

            if (cmbPasif.Text == "Evet")
            { durum = true; }
            else
            { durum = false; }

            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_Pasif", durum).ToString();
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_IlkIP", txtIlkIP.Text).ToString();
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@Kull_SonIP", txtSonIP.Text).ToString();
            try
            {
                CKartlar.CFonksiyon.Sorgu.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı kaydedildi..");
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı kaydedilirken bir hata oluştu..");
            }
        }

        public void KullaniciSil()
        {
            CKartlar.CFonksiyon.Baglan();
            CKartlar.CFonksiyon.SorguAyarla();
            CKartlar.CFonksiyon.Sorgu.CommandText = "DELETE FROM KULLANICILAR WHERE Kull_KayNo='@ID'";
            CKartlar.CFonksiyon.Sorgu.Parameters.AddWithValue("@ID", Convert.ToInt32(txtKullKayitNo.Text));
            try
            {
                CKartlar.CFonksiyon.Sorgu.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı silindi..");
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı silinirken bir hata oluştu..");
            }
        }

        public void KullaniciGuncelle()
        {
            CKartlar.CFonksiyon.Baglan();
            CKartlar.CFonksiyon.SorguAyarla();
            CKartlar.CFonksiyon.Sorgu.CommandText = "DELETE FROM KULLANICILAR WHERE Kull_KayNo='@ID'"; //O ıd dekı kaydı sildik.
            CKartlar.CFonksiyon.Sorgu.ExecuteNonQuery();

            CKartlar.CFonksiyon.SorguAyarla();
            KullaniciKaydet();// O ıd deki kaydı yenı halıyle kaydettık.

        }

        public void FormuDoldur(int id)
        {
            CKartlar.CFonksiyon CTemp = new CKartlar.CFonksiyon();
            DataTable dt = CTemp.TabloCek("SELECT Kull_KayNo,Kull_Adi,Kull_Sifre,Kull_UzunAdi,Kull_EMail,Kull_SifreDegisim," +
                                        "Kull_Pasif,Kull_IlkIP,Kull_SonIP FROM KULLANICILAR WHERE Kull_KayNo='" + id + "' ");

            if (dt.Rows.Count > 0)
            {
                txtKullKayitNo.Text = dt.Rows[0]["Kull_KayNo"].ToString();
                txtKullaniciAdi.Text = dt.Rows[0]["Kull_Adi"].ToString();
                txtSifre.Text = dt.Rows[0]["Kull_Sifre"].ToString();
                txtUzunAdi.Text = dt.Rows[0]["Kull_UzunAdi"].ToString();
                txtEMail.Text = dt.Rows[0]["Kull_EMail"].ToString();
                cmbSifreDegis.Text = dt.Rows[0]["Kull_SifreDegisim"].ToString();
                if (dt.Rows[0]["Kull_Pasif"].ToString() == "True")
                {
                    cmbPasif.Text = "Evet";
                }
                else
                {
                    cmbPasif.Text = "Hayır";
                }

                txtIlkIP.Text = dt.Rows[0]["Kull_IlkIP"].ToString();
                txtSonIP.Text = dt.Rows[0]["Kull_SonIP"].ToString();
            }

        }
        
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            KullaniciSil();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            KullaniciKaydet();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            KullaniciGuncelle();
        }

        private void txtKullaniciAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKullanicilar FTemp = new FrmKullanicilar();
            FTemp.ShowDialog();
            KullaniciKayitNo = FTemp.KullaniciKayitNo;
            FormuDoldur(int.Parse(KullaniciKayitNo));
        }

        private void txtKullKayitNo_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKullanicilar FTemp = new FrmKullanicilar();
            FTemp.ShowDialog();
            KullaniciKayitNo = FTemp.KullaniciKayitNo;
            FormuDoldur(int.Parse(KullaniciKayitNo));
        }
    }
}