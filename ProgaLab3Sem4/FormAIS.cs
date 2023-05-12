using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;

namespace ProgaLab2Sem4
{
    public partial class FormAIS : Form
    {
        public FormAIS(string filePath)
        {
            InitializeComponent();
            DLL.Menu menu = new DLL.Menu(filePath, menuStrip1);
            menu.CreateMenu();
        }
    }
}
