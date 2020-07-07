using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deadline6SecondTry.Forms.Create;

namespace Deadline6SecondTry
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            JsonDatabaseContext jsonDatabaseContext = new JsonDatabaseContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DepartmentCreateForm(jsonDatabaseContext));
        }
    }
}
