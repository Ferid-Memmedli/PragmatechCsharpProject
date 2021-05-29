using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        //  5. Pizza order system
        //- istifadeci terefinden sifaris verenin adi, soyadi , nomresi , adresi ,
        //- pizzanin olcusu(comboBox) ve sayi, terkibi, icecek(comboBox) ve sayi   daxil edilir,
        //- Terkibi (checkBox vasitesi ile evvelceden sistemde olan mehsullara uygun ozu secir): Example - “Mozarella” pendiri, vetçina, göbələk, italyan otları, zeytun yağı 
        //- Pizza olcu : (Boyuk, Orta, Kicik) ola biler qiymetleri ferqli olacaq,
        //- Temizle: data daxil edilen elementlerdeki datalar silinir.
        //- Sifaris Al : kilik olunan zaman asagdaki groupBox Icerisinde listBoxLarda daxil edilen melumatlar ve umumi qiymet gosterilecek
        //- Sifarisleri sil : Asagdaki lisboxlarda gosterilen butun sifarisler silinir.
        //- Qeyd : bir form dizayn ederken bir biri ile elaqeli elementleri bir groupbox iscerisinde yerlesdirin.
        public Form1()
        {
            InitializeComponent();
        }

        public void Sifirlama()
        {
            foreach (CheckBox item in gbPizzaTerkibi.Controls)
                item.Checked = false;
            foreach (var item in groupBox2.Controls)
            {
                if (item is TextBox textBox)
                    textBox.Clear();
            }
            icecekSay.Value = 1;
            pizzaSay.Value = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in DataPizzaOlcu.data)
                cmbPizzaOlcu.Items.Add(item);
            foreach (var item in DataIcecek.dataIcecek)
                cmbIcecek.Items.Add(item);
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
