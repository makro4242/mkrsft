using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace Makrosoft.CKartlar
{
    public class CMesajlar
=======
namespace Makrosoft.Classlar
{
    class Mesajlar
>>>>>>> origin/master
    {
        public Boolean Sor(string Mesaj)
        {
            DialogResult Sor = new DialogResult();
            Sor = MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(Sor==DialogResult.Yes)
                {
                return true;
                }
            return false;
        }

    }
}
