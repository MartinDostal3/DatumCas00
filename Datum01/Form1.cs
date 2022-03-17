using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datum01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string s = textBox1.Text;
            char[] separators = { ' ', ';' };
            string[] stringsplit = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            DateTime narozen = DateTime.Parse(textBox1.Text);
            DateTime dnes = DateTime.Today;


        }
    }
}
