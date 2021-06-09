using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using book_cataloger.Models;
using book_cataloger.Presenters;

namespace book_cataloger
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PresenterMain presenter= new PresenterMain(new MainForm(), new ModelMain());
            presenter.Run();
        }
    }
}
