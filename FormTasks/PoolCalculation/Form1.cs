using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolCalculation
{
    public partial class Form1 : Form
    {
        // 4. Calculation of poolL volume an filling time
        //- istifadeci terefinden hovuzun derinliyi, uzunlugu, eni daxil edilir(numericUpDown),
        //- buna uygun hovuzun hecmini hesablayib gostermelisiz,
        //- ikinci groupBox icerisinde ise iki eded su kraninin deqiqede nece kub/metr doldurdugu daxil edilir(numericUpDown),
        //- ilk once hovuzun hecmi hesablanan groupBox active olmalidir, yeni su kranlari ancaq hovuzun hecmi hesablandiqdan sonra aktiv olacaq
        //- ikinci group box icerisinde hesabla-ya klik olunan zaman 2 su kranin hovuzu neqeder vaxta doldurdugunu gostermeliyik.
        decimal hecm = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHovuz_Click(object sender, EventArgs e)
        {
            vaxt.Enabled = true;
            hovuz.Enabled = false;
            decimal derinlik = nudDerinlik.Value;
            decimal en = nudEn.Value;
            decimal uzunluk = nudUzunluk.Value;
            hecm = derinlik * en * uzunluk;
            txtHecm.Text = hecm.ToString();
        }

        private void btnVaxt_Click(object sender, EventArgs e)
        {
            vaxt.Enabled = false;
            hovuz.Enabled = true;
            decimal kran1 = nud1Kiran.Value;
            decimal kran2 = nud2Kiran.Value;
            decimal mutted = hecm /(kran1 + kran2);
            txtVaxt.Text = mutted.ToString();
        }
    }
}
