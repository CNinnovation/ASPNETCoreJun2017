using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldFrameworkLib
{
    public class OldDemo
    {
        public string Foo(string s)
        {
            Console.WriteLine($"NET Framework {s}");

            // MessageBox.Show("Bah!");
            return s.ToLower();
        }
    }
}
