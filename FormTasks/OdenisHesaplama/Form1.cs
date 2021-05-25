using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdenisHesaplama
{
    //  3. calculation of amount payable
    //- istifadeci terefinden productin adi ve qiymet daxil edilir, daxil edilen bu productlar
    //- listBoxda adi ve qiymeti olaraq gosterilmelidir, butun mehsullarda 18 % edv var ve bundan elave

    //- Telebe ve ya pensiyaner endirimi istifadeci terefinden "secilerse" umumi meblege samil edilecek.
    //- Hesabla button-a klik olunan zaman asagdaki textbox-da total cixmalidir

    //- Temizle button-a klik olunan zaman ise elementlerdeki datalar temizlenecek.
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        double totalQiymet = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtAd.Text,
                Price = txtQiymet.Text
            };
            products.Add(product);
            lstProduct.Items.Add(product.NamePrice());
            txtAd.Clear();
            txtQiymet.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstProduct.Items.Clear();
            products.Clear();
            txtAd.Clear();
            txtQiymet.Clear();
            txtTotalQiymet.Text = "0";
            totalQiymet = 0;
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            foreach (var item in products)
                totalQiymet += double.Parse(item.Price);

            if (rbtnTelebeEndirimi.Checked)
                txtTotalQiymet.Text = $"Telebe Endirimi Olundu : {totalQiymet - (totalQiymet * 0.1)}azn";
            else if (rbtnPensiyanerEndirimi.Checked)
                txtTotalQiymet.Text = $"Pensiyaner Endirimi Olundu : {totalQiymet - (totalQiymet * 0.2)}azn";
            else
                txtTotalQiymet.Text = $"Endirimsiz : {totalQiymet}azn";
        }
    }
}
