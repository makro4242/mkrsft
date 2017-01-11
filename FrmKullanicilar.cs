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
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        public String KullaniciKayitNo = "";
        public String KullaniciAdi = "";
        public String KullanıcıDB = "";

        CKartlar.CFonksiyon ctemp = new CKartlar.CFonksiyon();

        public FrmKullanicilar()
        {
            InitializeComponent();
            GetirKullanicilar();
        }

        public void GetirKullanicilar()
        {
            DataTable dt = ctemp.TabloCek("SELECT Kull_KayNo,Kull_Adi,Kull_DBase FROM KULLANICILAR");
            gridControl1.DataSource = dt;
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                KullaniciKayitNo = gridView1.GetFocusedRowCellValue("Kull_KayNo").ToString();
                KullaniciAdi = gridView1.GetFocusedRowCellValue("Kull_Adi").ToString();
                KullanıcıDB = gridView1.GetFocusedRowCellValue("Kull_DBase").ToString();
            }
            Close();
        }
    }
}