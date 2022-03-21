using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datum04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int ZarukaRoky(DateTime datumProdeje, int pocetLet)
        {
            DateTime posledniDenZaruky = datumProdeje.AddYears(pocetLet);

           DateTime dnes = DateTime.Today;

            TimeSpan zbyva = posledniDenZaruky - dnes;
          
           


            return (int)zbyva.TotalDays;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(ZarukaRoky(DateTime.Parse("1.3.2020"), 2).ToString());


        }
    }
}
