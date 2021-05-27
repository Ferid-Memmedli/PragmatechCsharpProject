using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        //  5. Pizza order system
        //- Qeyd : bir form dizayn ederken bir biri ile elaqeli elementleri bir groupbox iscerisinde yerlesdirin.
        //- istifadeci terefinden sifaris verenin adi, soyadi , nomresi , adresi ,
        //- pizzanin olcusu(comboBox) ve sayi, terkibi, icecek(comboBox) ve sayi   daxil edilir,
        //- Terkibi (checkBox vasitesi ile evvelceden sistemde olan mehsullara uygun ozu secir): Example - “Mozarella” pendiri, vetçina, göbələk, italyan otları, zeytun yağı 
        //- Pizza olcu : (Boyuk, Orta, Kicik) ola biler qiymetleri ferqli olacaq,
        //- Temizle: data daxil edilen elementlerdeki datalar silinir.
        //- Sifaris Al : kilik olunan zaman asagdaki groupBox Icerisinde listBoxLarda daxil edilen melumatlar ve umumi qiymet gosterilecek
        //- Sifarisleri sil : Asagdaki lisboxlarda gosterilen butun sifarisler silinir.
        public Form1()
        {
            InitializeComponent();
        }

        public void Sifirlama()
        {
            foreach (CheckBox item in gbPizzaTerkibi.Controls)
                item.Checked = false;

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();

            icecekSay.Value = 1;
            pizzaSay.Value = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PizzaOlcu balaca = new PizzaOlcu { Olcu = "Balaca", Qiymet = 10 };
            PizzaOlcu orta = new PizzaOlcu { Olcu = "Orta", Qiymet = 15 };
            PizzaOlcu boyuk = new PizzaOlcu { Olcu = "Balaca", Qiymet = 20 };
            cmbPizzaOlcu.Items.Add(balaca);
            cmbPizzaOlcu.Items.Add(orta);
            cmbPizzaOlcu.Items.Add(boyuk);

            Icecek cocaCola = new Icecek { Ad = "CocaCola", Qiymet = 0.9 };
            Icecek fanta = new Icecek { Ad = "Fanta", Qiymet = 0.9 };
            Icecek jale = new Icecek { Ad = "Jale", Qiymet = 2 };
            Icecek ayran = new Icecek { Ad = "Ayran", Qiymet = 0.4 };
            cmbIcecek.Items.Add(cocaCola);
            cmbIcecek.Items.Add(fanta);
            cmbIcecek.Items.Add(jale);
            cmbIcecek.Items.Add(ayran);

            cmbIcecek.SelectedItem = cocaCola;
            cmbPizzaOlcu.SelectedItem = balaca;
        }

        private void btnSifarisAl_Click(object sender, EventArgs e)
        {
            PizzaOlcu pizzaOlcu = (PizzaOlcu)cmbPizzaOlcu.SelectedItem;
            pizzaOlcu.Say = (double)pizzaSay.Value;

            Icecek icecek = (Icecek)cmbIcecek.SelectedItem;
            icecek.Say = (double)icecekSay.Value;

            Pizza pizza = new Pizza
            {
                PizzaOlcusu = pizzaOlcu,
                Icecekler = icecek
            };
            foreach (CheckBox item in gbPizzaTerkibi.Controls)
            {
                if (item.Checked)
                    pizza.Terkib.Add(item.Text);
            }
            Musteri musteri = new Musteri();
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtAdres.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Melumatlari Tam Doldurun", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Sifirlama();
            }
            else
            {
                musteri.Ad = txtAd.Text;
                musteri.Soyad = txtSoyad.Text;
                musteri.Adres = txtAdres.Text;
                musteri.Telefon = txtTelefon.Text;
                musteri.Pizza = pizza;
                lstSifarisler.Items.Add(musteri);
                Sifirlama();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Sifirlama();
        }

        private void btnSifarisSil_Click(object sender, EventArgs e)
        {
            Musteri silinecekSifaris = (Musteri)lstSifarisler.SelectedItem;
            lstSifarisler.Items.Remove(silinecekSifaris);
        }
    }
}
