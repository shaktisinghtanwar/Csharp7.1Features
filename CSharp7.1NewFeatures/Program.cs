using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp7._1NewFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    if ( CheckLicense().Result)
        //    {
        //        Application.EnableVisualStyles();
        //        Application.SetCompatibleTextRenderingDefault(false);
        //        Application.Run(new Form1());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid License");
        //        Application.Exit();
        //    }
        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        async static Task Main()
        {
            if (await CheckLicense())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Invalid License");
                Application.Exit();
            }
        }

        async static Task<bool> CheckLicense()
        {
            //Just random wait simultating a call to server which call server and check license
            await Task.Delay(4000);
            return true;
        }
    }
}
