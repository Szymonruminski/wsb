using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatornauka
{
    public partial class Form1 : Form
    {

        double wynik = 0;
        string operacja = "";
        bool isoperacja = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Poletekstowe.Text == "0" || (isoperacja))
                Poletekstowe.Clear();
            isoperacja = true;
            Button button = (Button)sender;

            if (button.Text == ",")

            {
                if (Poletekstowe.Text.Contains(","))

                    Poletekstowe.Text = Poletekstowe.Text + button.Text;

            }
            else

                Poletekstowe.Text = Poletekstowe.Text + button.Text;

        }

        private void dzialanie_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(wynik != 0)
            {
                button11.PerformClick();
                operacja = button.Text;
                Labelone.Text = wynik + "" + operacja;
                isoperacja = true;
                


            }
            else
            {
                operacja = button.Text;
                wynik = Double.Parse(Poletekstowe.Text);
                Labelone.Text = wynik + "" + operacja;
                isoperacja = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Poletekstowe.Text = "0";
            wynik = 0;
            Labelone.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Poletekstowe.Text = "0";

        }
        private void button11_Click(object sender, EventArgs e)
        {
            switch (operacja)

            {
                case "+":Poletekstowe.Text = (wynik + Double.Parse(Poletekstowe.Text)).ToString();
                    break;

                  


            }
            wynik = Double.Parse(Poletekstowe.Text);
            Labelone.Text = "";

        } 
    }
}
