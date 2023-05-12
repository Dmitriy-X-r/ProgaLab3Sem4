using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection.Emit;
using System.Reflection;
using DLL;


namespace ProgaLab2Sem4
{
    public delegate void Initialization(bool result, string menuPath);
    public delegate bool AutorizationDelegate(string userName, string Password, out string menuPath, string filePath );
    public partial class FormAutorization : Form
    {
        string fileUsersPath;
        public event Initialization wasInitialization;
        public FormAutorization(string fileUsersPath)
        {
            InitializeComponent();
            this.fileUsersPath = fileUsersPath;
        }
        
        private void btnEntry_Click(object sender, EventArgs e)
        {
            //Assembly asm = Assembly.LoadFrom("C:\\Проги\\DLLProgaLab3Sem4\\DLLProgaLab3Sem4\\bin\\Debug\\DLLProgaLab3Sem4.dll");
            //Type? t = asm.GetType("DLL.FileAutorization");
            //if (t is not null)
            //{
            //    // получаем метод Square
            //    MethodInfo? Autorization = t.GetMethod("StaticAutorization");

            //    string menuPath = "";
            //    AutorizationDelegate autorizationGelegate = Autorization.CreateDelegate<AutorizationDelegate>();
            //    bool result = autorizationGelegate(txtBoxUserName.Text, txtBoxPassword.Text, out menuPath, "C:\\Users\\user\\Desktop\\Users.txt");
            //    wasInitialization.Invoke(result, menuPath);
            //}

            FileAutorization fileAutharization = new FileAutorization(fileUsersPath);
            string menuPath;
            bool result = fileAutharization.Autorization(txtBoxUserName.Text, txtBoxPassword.Text, out menuPath);
            wasInitialization.Invoke(result, menuPath);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
