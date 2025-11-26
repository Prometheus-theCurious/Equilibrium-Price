using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prezzo_Di_Equilibrio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d;
            double o;
            double q;

            for (q = 0; q >= 0; q++)
            {
                d = 90 - 4 * q;
                o = 10 + (q * q * q) / 100;

                if (o > d)
                {
                    label1.Text = $"Domanda:{d} , Offerta:{o}, q = {q}";
                    break;
                }
            }

            while (q > 0)
            {
                d = 90 - 4 * q;
                o = 10 + (q * q * q) / 100;
                double epsilon = 0.1d; // tolerance for floating-point comparison

                bool isClose = Math.Abs(d - o) < epsilon;

                if (isClose)
                {
                    label1.Text = $"{d} is close to {o} within tolerance {epsilon}";
                    break;
                }
                else { label1.Text = $"{d} is NOT close to {o} within tolerance {epsilon}"; }

                if (o == d)
                {
                    label1.Text = $"Domanda:{d} , Offerta:{o}, q = {q}";
                    break;
                }

                if (o > d)
                {
                    q = q - epsilon;
                }
                else { epsilon = epsilon / 2; }

            }
        }
    }
}
