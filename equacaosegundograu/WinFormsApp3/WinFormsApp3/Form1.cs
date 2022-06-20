using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        double a, b, c, delta, x1, x2;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            a = double.Parse(txta.Text);
            b = double.Parse(txtb.Text);
            c = double.Parse(txtc.Text);

            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                x1 = -b / (2 * a);
                MessageBox.Show($"Ambas as raízes são iguais, x1 = x2 = {x1}", "Resultado", MessageBoxButtons.OK);
            }
            else
            {
                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a); x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    MessageBox.Show($"Há duas raízes para essa equação, {x1} e {x2}.", "Resultado", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Não há raízes reais para essa equação.", "Resultado", MessageBoxButtons.OK);
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txta.Clear(); 
            txtb.Clear(); 
            txtc.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
