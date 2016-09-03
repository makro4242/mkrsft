using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using System.Windows.Forms;

namespace Makrosoft
{
    public partial class frmMasterForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        
        public frmMasterForm()
        {
            InitializeComponent();
        }

        private void frmMasterForm_Load(object sender, System.EventArgs e)
        {
            frmMasaustu frm = new frmMasaustu();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnStokKartı_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            itemStokKarti.Visible = true;
        }

        private void itemStokKarti_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                itemStokKarti.Visible = false;
            }
            
        }

        private void btnStokKartı_ItemClick(object sender, ItemClickEventArgs e)
        {
            stokKartiAc();
        }

        #region //Stok kartı açma formu işlemi
        public void stokKartiAc()
        {
            bool sart = false;
            for (int i = 0; i < xtratabana.TabPages.Count; i++)
            {
                if (xtratabana.TabPages[i].Text == "Stok Tanıtım Kartı")
                {
                    xtratabana.SelectedTabPageIndex = i;
                    sart = true;
                }
            }

            if (sart == false)
            {
                XtraTabPage pageadd = new XtraTabPage();
                Panel paneladd = new Panel();
                pageadd.Text = "Stok Kartı";
                pageadd.Name = "stokKarti";
                pageadd.Controls.Add(paneladd);
                paneladd.Dock = DockStyle.Fill;
                xtratabana.TabPages.Add(pageadd);
                xtratabana.SelectedTabPageIndex = xtratabana.TabPages.Count;
                paneladd.Controls.Clear();
                StokModulu.frmStokTanitimKarti newForm = new StokModulu.frmStokTanitimKarti();
                newForm.Height = xtratabana.Size.Height - 30;
                newForm.Width = xtratabana.Size.Width;
                newForm.TopLevel = false;
                paneladd.Controls.Add(newForm);
                newForm.Show();
                newForm.Dock = DockStyle.Fill;
                newForm.BringToFront();
                xtratabana.SelectedTabPage = pageadd;
            }
        }
        #endregion
        #region //textbox temizle
        public void Temizle()
        {
            foreach (XtraTabPage page in xtratabana.TabPages)
            {
                foreach (Control textEdit in page.Controls)
                {
                    if (textEdit is TextBox)
                    {
                        (textEdit as TextBox).ResetText();
                    }
                }
            }
        }
        #endregion

        private void xtratabana_CloseButtonClick(object sender, System.EventArgs e)
        {
            if (xtratabana.SelectedTabPage.Name == "Stok Kartı")
            {
                StokModulu.frmStokTanitimKarti frmStokTanitimKarti = new StokModulu.frmStokTanitimKarti();
                Temizle();
            }
            xtratabana.TabPages.RemoveAt(xtratabana.SelectedTabPageIndex);
        }

      




    }
}