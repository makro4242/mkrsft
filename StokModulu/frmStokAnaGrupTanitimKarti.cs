using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makrosoft.StokModulu
{

    public partial class frmStokAnaGrupTanitimKarti : Form
    {
        Classlar.clsStokAnaGrupTanitimKarti StokAnaGrupTanitimKarti = new Classlar.clsStokAnaGrupTanitimKarti();
        Makrosoft.CKartlar.CFonksiyon dgs = new Makrosoft.CKartlar.CFonksiyon();
        Makrosoft.CKartlar.CMesajlar Mesajlar = new Makrosoft.CKartlar.CMesajlar();
        Boolean Secimicinacildimi = false;
        Boolean Edit = false;

        int secilenid = -1;
        public frmStokAnaGrupTanitimKarti()
        {
            InitializeComponent();
        }
        private void frmStokAnaGrupTanitimKarti_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            GridviewStokAnaGrup.DataSource = StokAnaGrupTanitimKarti.Listele();
        }
        void Temizle()
        {
            txtbtnStokAnaGrupKodu.Text = "";
            txtStokAnaGrupAdi.Text = "";
        }
        private void btnSakla_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                StokAnaGrupTanitimKarti.Guncelle(secilenid, dgs.Lokasyon, dgs.iptal, dgs.fileid, dgs.hidden, dgs.kilitli, dgs.degisti, dgs.cr_user, dgs.ls_user, dgs.ozelalan1, dgs.ozelalan2, dgs.ozelalan3, txtbtnStokAnaGrupKodu.Text, txtStokAnaGrupAdi.Text);
            }
            else
            {
                StokAnaGrupTanitimKarti.Ekle(dgs.Lokasyon, dgs.iptal, dgs.fileid, dgs.hidden, dgs.kilitli, dgs.degisti, dgs.cr_user, dgs.ls_user, dgs.ozelalan1, dgs.ozelalan2, dgs.ozelalan3, txtbtnStokAnaGrupKodu.Text, txtStokAnaGrupAdi.Text);
            }

            Listele();
            Temizle();
        }
        void sec()
        {
            try
            {
                secilenid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "sag_KAYno"));
            }
            catch (Exception)
            {

                secilenid = -1;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Seçilen Kaydı Silmek İstediğinizden eminmisiniz ?") == true)
            {
                sec();
                StokAnaGrupTanitimKarti.Sil(secilenid);
                Listele();
                Temizle();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if(Secimicinacildimi==true)
            {
                sec();
            }
            else
            {
                sec();
                DataRow satir = StokAnaGrupTanitimKarti.Ac(secilenid);
                txtbtnStokAnaGrupKodu.Text = satir["sag_kod"].ToString();
                txtStokAnaGrupAdi.Text = satir["sag_isim"].ToString();
                Edit = true;
            }
         
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            txtbtnStokAnaGrupKodu.Focus();
            Edit = false;
        }

        private void frmStokAnaGrupTanitimKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSakla_Click(null, null);
            }
        }

   



    }
}
