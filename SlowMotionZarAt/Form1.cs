using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlowMotionZarAt
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int zarBir = rnd.Next(1, 7);
            int zarIki = rnd.Next(1, 7);

            timer1.Interval += 100;
            if (timer1.Interval == 1500)
            {
                timer1.Stop();
                timer1.Interval = 100;
                timer2.Start();
            }

            btnZarAt.Text = $"{zarBir} - {zarIki}";
        }

        private void btnZarAt_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            btnZarAt.ForeColor = (sayac % 2 == 0 ? Color.Red : Color.Black);

            if (sayac == 10)
            {
                timer2.Stop();
                sayac = 0;
                btnZarAt.ForeColor = Color.Black;
            }
        }
    }
}
