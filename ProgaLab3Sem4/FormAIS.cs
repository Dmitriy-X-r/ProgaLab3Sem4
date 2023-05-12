using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgaLab2Sem4
{
    public partial class FormAIS : Form
    {
        public delegate void AISDelegate(string filePath, ToolStrip strip);
        public FormAIS(string filePath)
        {
            InitializeComponent();
            //Assembly asm = Assembly.LoadFrom("C:\\Проги\\DLLProgaLab3Sem4\\DLLProgaLab3Sem4\\bin\\Debug\\DLLProgaLab3Sem4.dll");
            //Type? t = asm.GetType("DLL.Menu");
            //if (t is not null)
            //{
            //    // получаем метод Square
            //    MethodInfo? menu = t.GetMethod("StaticCreateMenu");

            //    AISDelegate aisGelegate = menu.CreateDelegate<AISDelegate>();
            //    aisGelegate(filePath, menuStrip1);
            //}

            DLL.Menu menu = new DLL.Menu(filePath, menuStrip1);
            menu.CreateMenu();
        }
    }
}
