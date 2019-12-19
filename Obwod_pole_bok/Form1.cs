using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kwadrat : Form
    {
        public Kwadrat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Kwadrat_Load(object sender, EventArgs e)
        {

        }

        private void textBok_TextChanged(object sender, EventArgs e)
        {
            double Bok;
            if (double.TryParse(textBok.Text, out Bok) && Bok > 0)
            {
                textPole.Text = Math.Pow(Bok, 2).ToString();
                textObwod.Text = (4 * Bok).ToString();
                lblKomunikat.Text = String.Empty;
            }
            else
            {
                lblKomunikat.Text = "Wpisz liczbę dodatnią";
                textPole.Text = String.Empty;
                textObwod.Text = String.Empty;
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bynWyczysc_Click(object sender, EventArgs e)
        {
            textPole.Text = String.Empty;
            textObwod.Text = String.Empty;
            textBok.Text = String.Empty;
            lblKomunikat.Text = "Wpisz wymiar boku";
        }
    }
}
