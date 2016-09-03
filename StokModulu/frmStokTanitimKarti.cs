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

namespace Makrosoft.StokModulu
{
    public partial class frmStokTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmStokTanitimKarti()
        {
            InitializeComponent();
        }

        private void btnAnaGrupKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokAnaGrupTanitimKarti frm = new frmStokAnaGrupTanitimKarti();
            frm.ShowDialog();
        }

        private void btnAltGrupKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokAltGrupTanitimKarti frm = new frmStokAltGrupTanitimKarti();
            frm.ShowDialog();
        }

        private void btnAnaSaglayiciKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokAnaSaglayiciTanitimKarti frm = new frmStokAnaSaglayiciTanitimKarti();
            frm.ShowDialog();
        }

        private void btnUreticiKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokUreticiTanitimKarti frm = new frmStokUreticiTanitimKarti();
            frm.ShowDialog();
        }

        private void btnMarkaKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokMarkaTanitimKarti frm = new frmStokMarkaTanitimKarti();
            frm.ShowDialog();
        }

        private void btnSektorKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokSektorTanitimKarti frm = new frmStokSektorTanitimKarti();
            frm.ShowDialog();
        }

        private void btnModelKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokModelTanitimKarti frm = new frmStokModelTanitimKarti();
            frm.ShowDialog();
        }

        private void btnKategori1KoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokKategori1TanitimKarti frm = new frmStokKategori1TanitimKarti();
            frm.ShowDialog();
        }

        private void btnKategori2KoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokKategori2TanitimKarti frm = new frmStokKategori2TanitimKarti();
            frm.ShowDialog();
        }

        private void btnKategori3KoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokKategori3TanitimKarti frm = new frmStokKategori3TanitimKarti();
            frm.ShowDialog();
        }

        private void btnKategori4KoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokKategori4TanitimKarti frm = new frmStokKategori4TanitimKarti();
            frm.ShowDialog();
        }

        private void btnPaketKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokKategori4TanitimKarti frm = new frmStokKategori4TanitimKarti();
            frm.ShowDialog();
        }

        private void btnOzelKod1Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokOzelKod1TanitimKarti frm = new frmStokOzelKod1TanitimKarti();
            frm.ShowDialog();
        }

        private void btnOzelKod2Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokOzelKod2TanitimKarti frm = new frmStokOzelKod2TanitimKarti();
            frm.ShowDialog();
        }

        private void btnOzelKod3Sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokOzelKod3TanitimKarti frm = new frmStokOzelKod3TanitimKarti();
            frm.ShowDialog();
        }

        private void btnMuhasebeGrupKoduSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmStokMuhasebeGrupTanitimKarti frm = new frmStokMuhasebeGrupTanitimKarti();
            frm.ShowDialog();
        }



        }
    }