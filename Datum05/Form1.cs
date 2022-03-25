using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datum05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool MinTrvanlivostDny(DateTime prodano, int pocetDniZaruky, int cena, out int sleva)
        {

            DateTime posledniDenZaruky = prodano.AddDays(pocetDniZaruky);
            DateTime dt = DateTime.Now;
            TimeSpan zbyva = posledniDenZaruky - dt;
            bool prodejne = true;
            sleva = 0;
            if ((int)zbyva.TotalDays > 3)
            {
                sleva = cena;
                prodejne = true;
            }
            if ((int)zbyva.TotalDays <= 3)
            {
                sleva = (cena * 75) / 100;
                prodejne = true;
            }
            if ((int)zbyva.TotalDays < 0)
            {
                sleva = (cena * 50) / 100;
                prodejne = true;
            }
            if ((int)zbyva.TotalDays < -10)
            {
                prodejne = false;
            }

            return prodejne;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int sleva = 0;
            if (MinTrvanlivostDny(dateTimePicker1.Value, x, y, out sleva))
            {
                MessageBox.Show("Ano, je prodejne" + "cena je " + sleva);
            }
            else
            {
                MessageBox.Show("Zbozi neni prodejne");
            }

        }
    }
}
