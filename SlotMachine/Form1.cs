using SlotMachine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int meyveBir;
        int meyveIki;
        int meyveUc;
        Random rnd = new Random();
        int puan = 100;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            meyveBir = rnd.Next(0, 3);
            meyveIki = rnd.Next(0, 3);
            meyveUc = rnd.Next(0, 3);

            switch (meyveBir)
            {
                case 0:
                    pbMeyveBir.Image = Resources._1;
                    break;
                case 1:
                    pbMeyveBir.Image = Resources._2;
                    break;
                case 2:
                    pbMeyveBir.Image = Resources._3;
                    break;
            }

            switch (meyveIki)
            {
                case 0:
                    pbMeyveIki.Image = Resources._1;
                    break;
                case 1:
                    pbMeyveIki.Image = Resources._2;
                    break;
                case 2:
                    pbMeyveIki.Image = Resources._3;
                    break;
            }

            switch (meyveUc)
            {
                case 0:
                    pbMeyveUc.Image = Resources._1;
                    break;
                case 1:
                    pbMeyveUc.Image = Resources._2;
                    break;
                case 2:
                    pbMeyveUc.Image = Resources._3;
                    break;
            }



            Text = $"{meyveBir} {meyveIki} {meyveUc}";


            timer1.Interval += 100;
            if (timer1.Interval == 1500)
            {
                timer1.Stop();
                timer1.Interval = 100;

                if (meyveBir == meyveIki && meyveIki == meyveUc)
                    puan += 30;
                else if (meyveBir == meyveIki || meyveBir == meyveUc || meyveIki == meyveUc)
                    puan += 20;
                else
                    puan -= 10;

                btnCek.Text = "CEK " + puan;
            }
        }
    }
}
