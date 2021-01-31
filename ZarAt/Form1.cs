using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sayiBir;
        int sayiIki;
        Random rnd = new Random();
        private void btnZarAr_Click(object sender, EventArgs e)
        {
            sayiBir = rnd.Next(1, 7);
            sayiIki = rnd.Next(1, 7);

            btnZarAr.Text = $"{sayiBir} - {sayiIki}";
            //btnZarAr.Text = sayiBir + " - " + sayiIki;
        }
    }
}
