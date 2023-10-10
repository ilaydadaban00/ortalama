using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, not4, sonuc;
            not1 = Convert.ToDouble(txtNot1.Text);
            not2 = Convert.ToDouble(txtNot2.Text);
            not3 = Convert.ToDouble(txtNot3.Text);
            not4 = Convert.ToDouble(txtNot4.Text);
            sonuc = (not1 + not2 + not3 + not4) / 4;



            if (sonuc < 50 )
            {


                lblSonuc.Text = "kaldı";
            }

           else  if (sonuc > 50 & sonuc< 70) 
            {

            
            lblSonuc.Text = "geçtiniz";
             }
            else if (sonuc >= 70 & sonuc < 85)
            {
                lblSonuc.Text = "teşekkür";
            }

            else if (sonuc >= 85 & sonuc < 100)
            {
                lblSonuc.Text = "taktir";
            }

        }
        
    }
}
