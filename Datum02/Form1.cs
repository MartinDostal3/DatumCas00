using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datum02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static TimeSpan PocetDnu(DateTime narozen)
        {
            TimeSpan Uplynulo;
            narozen = narozen.AddYears(65);
            Uplynulo = DateTime.Today - narozen;
            return Uplynulo;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime narozen = dateTimePicker1.Value;
            MessageBox.Show(PocetDnu(narozen).ToString());
            

            //MessageBox.Show();

        }
    }
}
