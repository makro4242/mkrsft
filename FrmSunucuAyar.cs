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
using System.Data.Sql;
using System.IO;

namespace Makrosoft
{
    public partial class FrmSunucuAyar : DevExpress.XtraEditors.XtraForm
    {
        public String InstanceName;
        public FrmSunucuAyar()
        {
            InitializeComponent();

        }

        private void txtVeriCalismaDizini_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true; // Yeni klasör olustur butonu
            // Kontrolü göster
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtVeriCalismaDizini.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtBaglantiCumle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ADODB._Connection ADOcon;
            MSDASC.DataLinks mydlg = new MSDASC.DataLinks();
            ADOcon = (ADODB._Connection)mydlg.PromptNew();

            if (txtSQLSunucusu.Text == "" || txtSQLSunucusu.Text == null)
            {
                MessageBox.Show("Lütfen SQL Sunucusu seçin!");
                txtSQLSunucusu.Focus();
            }
            else
            {
                ADOcon.Open(txtSQLSunucusu.Text, "Makrosoft", "Makrosoft", 0);
            }


            if (ADOcon.State == 1)
            {
                MessageBox.Show("Bağlantı açıldı");
                ADOcon.Close();
            }
            else
            {
                MessageBox.Show("Bağlantı açılamadı!!");
            }

        }

        private void txtSQLSunucusu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmSQLInstance FTemp = new FrmSQLInstance();
            FTemp.ShowDialog();
            InstanceName = FTemp.InstanceName;
            txtSQLSunucusu.Text = InstanceName;
        }

        public void DoldurDosya()
        {
            try
            {
                //string dosya_yolu = @"C:Makro\v14xx\\DATABASE.ini";
                string dosya_yolu = @"D:\\Users\\dilan\\Documents\\GitHub\\mkrsft\\DATABASE.ini";
                FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("SQL_Server=" + txtSQLSunucusu.Text);
                sw.WriteLine("VeriDizini=" + txtVeriCalismaDizini.Text);
                sw.WriteLine("SunucuKurulumDizini=" + txtKurulumVeriDizini.Text);
                sw.WriteLine("SQLKullanicisiBaglantisi=NO");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                //string dosya_yolu = @"C:Makro\v14xx\\DATABASE.ini";
                string yol = "D:\\Users\\dilan\\Documents\\GitHub\\mkrsft\\DATABASE.ini";
                if (!File.Exists(yol))
                {
                    File.Delete(yol);
                }
                MessageBox.Show("DATABASE.ini oluşturulamadı.");
            }

        }

        private void btnDosyaIndir_Click(object sender, EventArgs e)
        {
            if (txtSQLSunucusu.Text == "" || txtSQLSunucusu.Text == null)
            {
                MessageBox.Show("Lütfen SQL Sunucusu alanını doldurun..");
                txtSQLSunucusu.Focus();
            }
            else if (txtVeriCalismaDizini.Text == "" || txtVeriCalismaDizini.Text == null)
            {
                MessageBox.Show("Lütfen Veri Çalışma dizini alanını doldurun..");
                txtVeriCalismaDizini.Focus();
            }
            else if (txtKurulumVeriDizini.Text == "" || txtKurulumVeriDizini.Text == null)
            {
                MessageBox.Show("Lütfen Kurulum Dizini alanını doldurun..");
                txtKurulumVeriDizini.Focus();
            }
            else
            {
                //StreamWriter Dosya = File.CreateText("C:Makro\v14xx\\DATABASE.ini"); //Dosyaya yazmak için
                StreamWriter Dosya = File.CreateText("D:\\Users\\dilan\\Documents\\GitHub\\mkrsft\\DATABASE.ini");
                Dosya.Close();
                DoldurDosya();
                MessageBox.Show("DATABASE.ini oluşturuldu..");
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            //string databaseyol = "C:Makro\v14xx\\DATABASE.ini";
            string databaseyol = "D:\\Users\\dilan\\Documents\\GitHub\\mkrsft\\DATABASE.ini"; //Database.ini nin oldugu yol
            FileStream fs = new FileStream(databaseyol, FileMode.Open, FileAccess.Read); 
            StreamReader sw = new StreamReader(fs); //Dosyadan okumak için.
            string kaydedilenyol=""; //Database.ini nin kaydedıldıgı yol. 'kurulumyol' u içinden çekmek için
            string kurulumyol=""; //Programın kurulacagı yol

            if (File.Exists(databaseyol))
            {
                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    string[] dizi = yazi.Split('=');
                    if(dizi[0]== "VeriDizini")
                    {
                        kaydedilenyol = dizi[1].ToString();
                    }
                    else if(dizi[0] == "SunucuKurulumDizini")
                    {
                        kurulumyol= dizi[1].ToString();
                    }
                    yazi = sw.ReadLine();
                }
                sw.Close();
                fs.Close();

                if(File.Exists(kurulumyol)) //Programın kurulacagı yolda dosyalar var mı? varsa programı calıstır.
                {
                    FrmKullaniciEkle FTemp = new FrmKullaniciEkle();
                    FTemp.Show();
                    this.Close();
                }
                else //Kurulum yapılacak
                {
                    MessageBox.Show(kurulumyol + " dizinine ulaşılamıyor");
                }
            }
            else
            {
                MessageBox.Show("DATABASE.ini dosyası bulunamıyor. Lütfen tekrar oluşturmayı deneyin..");
            }
            
        }
    }
}