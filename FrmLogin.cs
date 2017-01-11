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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            dtGununTarihi.EditValue = DateTime.Now;
        }
<<<<<<< HEAD

        private void btnGiris_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle f = new FrmKullaniciEkle();
            f.Show();
            this.Hide();
        }
=======
>>>>>>> origin/master
    }
}