using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStock
{
    // 2. Book Stock
    //- evvelceden db-da olan kitablarin Combobox-da adlarinin gosterilmesi , comboBox-da hansi kitab secilerse
    //- kitabin property-lerine uygun detail hissesindeki textBoxlarin deyeri deyisdirilmelidir.
    //- real datalardan istifade edin !
    //
    //Book
    //Id
    //Name
    //Author
    //Category
    //StockCount
    //Description
    //Image : string (proyekte kitab sekillerini yukleyin yeni sadece copy edin localdan sekilleri proyektin oldugu foldere,
    //sonra copy full path)

    // QEYD : FormLar ekranin tam merkezinde acilmalidir, sizeable olmamalidir.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Books DataBase
        List<Books> books = new List<Books>()
        {
             new Books() {Name = "Evakuasiya",Author = "Qaraqan",Category = "Roman",StockCount = 168, Description = "Qaraqanın “Evakuasiya” romanı oxucular arasında fikir ayrı seçkiliyi və mübahisələrə səbəb oldu. Roman Masonluğun gizli tarixi və kütləvi insan soyqırımından bəhs edir. Kitabın əsas qəhrəmanları ilə 33-cü dərəcəli mason “ Ned”in söhbətləri sizi Qızıl xaç yürüşündən , Tamplier savaşçıları, Qızıl Milyard və Kabbala, Yahudilərin böyük köçü və qədim Misir kahinlərinin sirrlərinə, Satanizm və Assasinlər haqda əfsanələrə aparacaq.",Img = @"C:\Users\shaha\Desktop\Pragmatech\PragmatechCsharpProject\FormTasks\BookStock\Img\evakuasiya.jpg"},
             new Books() {Name = "Dusun ve Varlan",Author = "Napoleon Hill",Category = "Psixologiya",StockCount = 55,Description = "Yəqin ki, dünyada ən əhəmiyyətli və nüfuzlu kitab uğura, zənginliyə, maneələri aşa bilən həyat enerjisinə və məqsədyönlülüyə yönləndirən dərslik sayılır. “Düşün və varlan” kitabı 70 il ərzində zənginliyin yaradılması üzrə klassik dərslik sayılır. Napoleon Hill hər fəsildə pulun əldə edilməsinin sirlərini açır və bu sirlərdən istifadə edən minlərlə insan nəinki zənginlik əldə edir, üstəlik dayanmadan onu artırır və eyni zamanda öz şəxsi potensiallarını inkişaf etdirir, zənginləşdirir.Qarşınızdakı Napoleon Hillin möhtəşəm işinin əlavələr edilmiş, müasir həyata uyğun yenidən işlənib-hazırlanmış təzə klassik nəşridi.",Img =@"C:\Users\shaha\Desktop\Pragmatech\PragmatechCsharpProject\FormTasks\BookStock\Img\dusunvevarlan.jpg" },
             new Books() {Name = "Rich Dad Poor Dad", Author = "Robert T. Kiyosaki",Category = "Biznes",StockCount = 77,Description = "Kitabdan çıxan başlıca nəticə odur ki, müasir dövrdə çox pul qazanmaq üçün çox işləməyə ehtiyac yoxdur, sadəcə, ağıllı olmaq, enerjini, biliyini, əlində olan vəsaiti düzgün paylaşdırmaq, səmərəli istifadə etməkdir. Bunun yolu maliyyə savadına malik olmaq, bazar konyukturasını öyrənib bilmək və təcrübədə tətbiq etməkdir.",Img = @"C:\Users\shaha\Desktop\Pragmatech\PragmatechCsharpProject\FormTasks\BookStock\Img\richdadpoordad.jpg"},
             new Books() {Name = "Mustafa Kamal ATATÜRK",Author = "Ataturk",Category = "Bioqrafiya",StockCount = 66,Description = "Atatürk, Qazi Mustafa Kamal (1881-1938) Türkiyə Cümhuriyyətinin qurucusu, dövlət, hərbi və siyasi xadim olmuşdur. 1923-1938-ci illərdə Türkiyənin ilk prezidenti olmaqla ölkəyə rəhbərlik etmişdir.",Img =@"C:\Users\shaha\Desktop\Pragmatech\PragmatechCsharpProject\FormTasks\BookStock\Img\ATATURK.jpg" }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in books)
            {
                cmbBooks.Items.Add(item.Name);
            }
        }
        #endregion

        private void btnGorset_Click(object sender, EventArgs e)
        {
            var book = books.Find(i => i.Name == cmbBooks.SelectedItem.ToString());
            imgBook.ImageLocation = book.Img;
            txtAuthor.Text = book.Author;
            txtCategory.Text = book.Category;
            txtStock.Text = book.StockCount.ToString();
            txtDesc.Text = book.Description;
        }
    }
}
