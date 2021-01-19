using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileToetsenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string letters = "abc2ABC";
            knopKlik( ((Button)sender).Name, letters);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string letters = "def3DEF";
            knopKlik(((Button)sender).Name, letters);
        }

        string vorigeKnopNaam="";
        int aantalKliks = 0;
        DateTime vorigeKlikTijdstip = DateTime.Now;
        private string knopKlik(string knopNaam, string letters) {
            string HuidigeText = txtDisplay.Text;
            if (vorigeKnopNaam.Equals(knopNaam))
            {
                aantalKliks++;
                if (aantalKliks > letters.Length - 1) {
                    aantalKliks = 0;
                }
                TimeSpan verschil = DateTime.Now - vorigeKlikTijdstip;
                if (verschil.TotalSeconds < 1)
                {
                    HuidigeText = HuidigeText.Substring(0, HuidigeText.Length - 1);
                    HuidigeText += letters[aantalKliks].ToString();
                }
                else {
                    HuidigeText += letters[0].ToString();
                    aantalKliks = 0;
          
                }
            }
            else 
            {
                HuidigeText += letters[0].ToString();
                vorigeKnopNaam = knopNaam;
                aantalKliks = 0;
            }
            vorigeKlikTijdstip = DateTime.Now;
            txtDisplay.Text = HuidigeText;
            return "abc";
        }
    }
}
