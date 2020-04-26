using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneMoreForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 8, y = 0;
            try 
            { 
                int z = x / y;
            }
            catch(DivideByZeroException )
            {
                Foo("Opps", "Error");
            }
        }
        void Foo(string message, string MBHeader)
        {
            MessageBox.Show(message, MBHeader, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
