using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.GUI;

namespace Hitech
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ManagerForm());
            //Application.Run(new MisForm());
            //Application.Run(new InventoryForm());
            //Application.Run(new ClerkForm());
            Application.Run(new FormLogin());
        }
    }
}