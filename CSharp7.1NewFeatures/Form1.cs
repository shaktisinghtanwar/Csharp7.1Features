using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp7._1NewFeatures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnDefaultExpressions_Click(object sender, EventArgs e)
        {
            string str = default(string); //Old way of defining default strings

            var intValue = default(int);

            string stringValue = default(string);

            var nullableIntValue = default(int?);
                       
            str = default; //Not Supported by default in C# 7.0 but supported in C# 7.1

            intValue = default;

            stringValue = default;

            nullableIntValue = default;


        }

        private void btnTupleEnhancement_Click(object sender, EventArgs e)
        {
            //Older version before C# 7.1
            var x = 20;
            var y = 10;

            var point = (x: x, y: y);


            //New Version C# 7.1

            var point2 = (x, y); // Tuple element names are inferred from variables passed

            Console.WriteLine("Tuple element values are ", point2.x, point2.y); 
        }
    }
}
