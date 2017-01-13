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
        String SeciliDeger = "";
        String SeciliAlan = "";
        public FrmKullaniciEkle()
        {
            InitializeComponent();
            IlkEleman();
            cmbSifreDegis.SelectedIndex = 1;
            cmbPasif.SelectedIndex = 1;
        }

        public void Temizle()
        {
            txtKullKayitNo.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtUzunAdi.Text = "";
            txtEMail.Text = "";
            cmbSifreDegis.SelectedIndex = 1;
            cmbPasif.SelectedIndex = 1;
            txtIlkIP.Text = "";
            txtSonIP.Text = "";

        }

        public void KullaniciKaydet()
        {
            Boolean durum = false;
            CKartlar.CFonksiyon.Baglan();
            CKartlar.CFonksiyon.SorguAyarla();
            CKartlar.CFonksiyon.Sorgu.CommandText = "INSERT INTO KULLANICILAR (Kull_Adi,Kull_Sifre," +
                                                    "Kull_UzunAdi,Kull_EMail,Kull_SifreDegisim,Kull_Pasif,Kull_IlkIP," +
                                                    "Kull_SonIP) VALUES (@Kull_Adi,@Kull_Sifre,@Kull_UzunAdi," +
                                                    "@Kull_EMail,@Kull_SifreDegisim,@Kull_Pasif,@Kull_IlkIP,@Kull_SonIP)";

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
            CKartlar.CFonksiyon.Sorgu.CommandText = "DELETE FROM KULLANICILAR WHERE Kull_KayNo='" + txtKullKayitNo.Text + "'";
            try
            {
                CKartlar.CFonksiyon.Sorgu.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı silindi..");
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı silinirken bir hata oluştu..");
            }
            Temizle();
        }

        public void KullaniciGuncelle()
        {
            CKartlar.CFonksiyon.Baglan();
            CKartlar.CFonksiyon.SorguAyarla();
            CKartlar.CFonksiyon.Sorgu.CommandText = "DELETE FROM KULLANICILAR WHERE Kull_KayNo='" + txtKullKayitNo.Text + "'"; //O ıd dekı kaydı sildik.
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

        public void IlkEleman()
        {
            CKartlar.CFonksiyon ctemp = new CKartlar.CFonksiyon();
            int id = 0;
            DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo FROM KULLANICILAR ORDER BY Kull_KayNo ASC; ");
            if (dt.Rows.Count > 0)
            {
                id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
            }
            FormuDoldur(id);
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
            if (KullaniciKayitNo == null || KullaniciKayitNo != "0")
            {
                FormuDoldur(int.Parse(KullaniciKayitNo));
            }

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            KullaniciSil();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            CKartlar.CFonksiyon ctemp = new CKartlar.CFonksiyon();
            DataTable dt = ctemp.TabloCek("SELECT Kull_KayNo FROM KULLANICILAR");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Kull_KayNo"].ToString() == txtKullKayitNo.Text)
                {
                    KullaniciGuncelle();
                    return;
                }
            }
            KullaniciKaydet();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            CKartlar.CFonksiyon ctemp = new CKartlar.CFonksiyon();
            int id = 0;

            if (SeciliAlan == "txtKullaniciAdi.Text")
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo,Kull_Adi FROM KULLANICILAR WHERE Kull_Adi < '" + txtKullaniciAdi.Text + "'  " +
                                              "ORDER BY Kull_Adi DESC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun 'Ad' a göre ilk kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
            else if (SeciliAlan == "txtUzunAdi.Text")
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo,Kull_UzunAdi FROM KULLANICILAR WHERE Kull_UzunAdi < '" + txtUzunAdi.Text + "'  " +
                                            "ORDER BY Kull_UzunAdi DESC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun 'Uzun Ad' a göre ilk kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
            else if (SeciliAlan == "txtEMail.Text")
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo,Kull_EMail FROM KULLANICILAR WHERE Kull_EMail < '" + txtEMail.Text + "'  " +
                                            "ORDER BY Kull_EMail DESC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun 'E-MAil' e göre ilk kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
            else
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo FROM KULLANICILAR WHERE Kull_KayNo < '" + txtKullKayitNo.Text + "'  " +
                                              "ORDER BY Kull_KayNo DESC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun ilk kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            CKartlar.CFonksiyon ctemp = new CKartlar.CFonksiyon();
            int id = 0;

            if (SeciliAlan == "txtKullaniciAdi.Text")
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo,Kull_Adi FROM KULLANICILAR WHERE Kull_Adi > '" + txtKullaniciAdi.Text + "'  " +
                                              "ORDER BY Kull_Adi ASC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun 'Ad' a göre son kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
            else if (SeciliAlan == "txtUzunAdi.Text")
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo,Kull_UzunAdi FROM KULLANICILAR WHERE Kull_UzunAdi > '" + txtUzunAdi.Text + "'  " +
                                            "ORDER BY Kull_UzunAdi ASC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun 'Uzun Ad' a göre son kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
            else if (SeciliAlan == "txtEMail.Text")
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo,Kull_EMail FROM KULLANICILAR WHERE Kull_EMail > '" + txtEMail.Text + "'  " +
                                            "ORDER BY Kull_EMail ASC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun 'E-MAil' e göre son kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
            else
            {
                DataTable dt = ctemp.TabloCek("SELECT TOP 1 Kull_KayNo FROM KULLANICILAR WHERE Kull_KayNo > '" + txtKullKayitNo.Text + "'  " +
                                              "ORDER BY Kull_KayNo ASC");
                if (dt.Rows.Count > 0)
                {
                    id = Convert.ToInt32(dt.Rows[0]["Kull_KayNo"].ToString());
                }
                else
                {
                    MessageBox.Show("Tablonun son kaydı.");
                }
                FormuDoldur(id);
                SeciliAlan = "";
                SeciliDeger = "";
            }
        }

        private void txtKullaniciAdi_MouseUp(object sender, MouseEventArgs e)
        {
            SeciliDeger = txtKullaniciAdi.Text;
            SeciliAlan = "txtKullaniciAdi.Text";
        }

        private void txtUzunAdi_MouseUp(object sender, MouseEventArgs e)
        {
            SeciliDeger = txtUzunAdi.Text;
            SeciliAlan = "txtUzunAdi.Text";
        }

        private void txtEMail_MouseUp(object sender, MouseEventArgs e)
        {
            SeciliDeger = txtEMail.Text;
            SeciliAlan = "txtEMail.Text";
        }
    }
}