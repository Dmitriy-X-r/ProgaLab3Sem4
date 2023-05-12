using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgaLab2Sem4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string fileUsersPath = "C:\\Users\\user\\Desktop\\Users.txt";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormAutorization authorizationForm = new FormAutorization(fileUsersPath);
            authorizationForm.wasInitialization += delegate (bool result, string menuPath)
            {
                if (result)
                {
                    FormAIS formAIS = new FormAIS(menuPath);
                    formAIS.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации.");
                }
            };

            Application.Run(authorizationForm);
        }
    }
}
