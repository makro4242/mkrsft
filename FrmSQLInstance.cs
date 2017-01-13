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

namespace Makrosoft
{
    public partial class FrmSQLInstance : DevExpress.XtraEditors.XtraForm
    {
        public String InstanceName;
        public FrmSQLInstance()
        {
            InitializeComponent();
            GetirSQLInstance();
        }

        public void GetirSQLInstance()
        {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();

            DataTable tablo = new DataTable();  
            tablo.Columns.Add("InstanceName");
            
            foreach (DataRow serverRow in dt.Rows)
            {
                DataRow satirlar = tablo.NewRow();
                if (serverRow[dt.Columns["InstanceName"]].ToString() == "")
                {
                    satirlar["InstanceName"] = (serverRow[dt.Columns["ServerName"]].ToString());
                }
                else
                {
                    satirlar["InstanceName"] = (serverRow[dt.Columns["ServerName"]].ToString() + "\\" +
                                        (serverRow[dt.Columns["InstanceName"]].ToString()));
                }
                tablo.Rows.Add(satirlar);
            }
            gridControl1.DataSource = tablo;
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                InstanceName = gridView1.GetFocusedRowCellValue("InstanceName").ToString();
            }
            Close();
        }
    }
}