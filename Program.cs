using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Makrosoft
{
    static class Program
    {
        public static void DosyaKontrol()
        {
            //string yol = "C:\\Makro\\v14xx";
            string yol = "D:\\Users\\dilan\\Documents\\GitHub\\mkrsft\\DATABASE.ini";
            if (!File.Exists(yol))
            {
                Application.Run(new FrmSunucuAyar());
            }
            else
            {
                Application.Run(new FrmLogin());
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DosyaKontrol();
        }
    }
}
