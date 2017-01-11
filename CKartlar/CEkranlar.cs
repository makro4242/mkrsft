using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Makrosoft.CKartlar
{
    public class CEkranlar
=======
namespace Makrosoft.Classlar
{
    class Ekranlar
>>>>>>> origin/master
    {
        public void StokAnaGrupTanitimKartiAc(Boolean Sec)
        {
            Makrosoft.StokModulu.frmStokAnaGrupTanitimKarti frm = new StokModulu.frmStokAnaGrupTanitimKarti();
            if(Sec==true)
            {
                //frm.Secimicinacildimi = true;
                frm.ShowDialog();
            }
            else
            {

            }
        }
    }
}
