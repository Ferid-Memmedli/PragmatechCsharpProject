using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        //  5. Pizza order system

        //- istifadeci terefinden sifaris verenin adi, soyadi , nomresi , adresi ,
        //- pizzanin olcusu(comboBox) ve sayi, terkibi, icecek(comboBox) ve sayi   daxil edilir,
        //- Sifaris Al : kilik olunan zaman asagdaki groupBox Icerisinde listBoxLarda daxil edilen melumatlar ve umumi qiymet gosterilecek.
        //- Temizle: data daxil edilen elementlerdeki datalar silinir.
        //- Sifarisleri sil : Asagdaki lisboxlarda gosterilen butun sifarisler silinir.
        //- Pizza olcu : (Boyuk, Orta, Kicik) ola biler qiymetleri ferqli olacaq,
        //- Terkibi (checkBox vasitesi ile evvelceden sistemde olan mehsullara uygun ozu secir): Example - “Mozarella” pendiri, vetçina, göbələk, italyan otları, zeytun yağı 
        //- Qeyd : bir form dizayn ederken bir biri ile elaqeli elementleri bir groupbox iscerisinde yerlesdirin.
        public Form1()
        {
            InitializeComponent();
        }

    }
}
