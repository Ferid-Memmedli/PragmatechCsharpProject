using System;
using System.Collections;


#region Task

#region 1. Bal Ortalamasinin Hesablanmasi

#region Task 1.1
/*
 * 1. Istifadeciden gelen 3 ferqli imtahan neticelerinin
 * ortalamasinin 45-den  boyuk ve ya beraber olmasini
 * yoxlayin.
 *
 * qeyd : if else istifade etmeyin burada
 * 
 * netice asagidaki kimi olmalidir.
 *
 * Netice : 30
 * Netice : 50
 * Netice : 40
 *
 * "Ortalama 45-e beraber ve ya boyukdurmu?" : "40"(Ortalamadir) : Beli ve ya Xeyr
 *
 */

/*
//Helli
decimal netice1, netice2, netice3, ortalama;
print("Ortalamanin Hesaplanmasi");
netice1 = Convert.ToDecimal(input("1-ci Imtahanin neticenisini yazin :"));
netice2 = Convert.ToDecimal(input("2-ci Imtahanin neticenisini yazin :"));
netice3 = Convert.ToDecimal(input("3-cu Imtahanin neticenisini yazin :"));
ortalama = (netice1 + netice2 + netice3) / 3;
print($"Netice : {netice1}");
print($"Netice : {netice2}");
print($"Netice : {netice3}");
string netice = ortalama > 45 ? $"Sizin ortalamaniz : {ortalama} ve 45-den boyukdur" :
    (ortalama == 45 ? "Sizin ortalamaniz 45-e beraberdir" : $"Sizin ortalamaniz : {ortalama} ve 45-den kicikdir");
print("Ortalama 45-e beraber ve ya boyukdurmu?");
print(netice);
*/
#endregion

#region Task 1.2
/*
* 2.Bal Ortalamasinin Hesablanmasi
*
* istifadeciden ad ve soyadini ,
*  4 eded imtahan neticesini daxil etmesini isteyirik.
*
* netice asagidaki kimi olmalidir
*
* Ad ve Soyad : Parviz Aliyev
*
* Netice : 50
* Netice : 40
* Netice : 30
* Netice : 20
*
* Ortalama : 35
*/
/*
//            HElli
decimal netice1, netice2, netice3, netice4, ortalama;
print("Bal Ortalamasinin Hesablanmasi :");
string name = input("Adinizi ve Soyadinizi yazin :");
netice1 = Convert.ToDecimal(input("1-ci Imtahanin neticenisini yazin :"));
netice2 = Convert.ToDecimal(input("2-ci Imtahanin neticenisini yazin :"));
netice3 = Convert.ToDecimal(input("3-cu Imtahanin neticenisini yazin :"));
netice4 = Convert.ToDecimal(input("4-cu Imtahanin neticenisini yazin :"));
ortalama = (netice1 + netice2 + netice3 + netice4) / 4;
print($"Ad ve Soyad : {name}");
print($"Netice : {netice1}");
print($"Netice : {netice2}");
print($"Netice : {netice3}");
print($"Netice : {netice4}");
print($"Ortalama : {ortalama}");
*/
#endregion

#region Task 1.3
/*
*3.Bal Ortalamasinin Hesablanmasi
*
* istifadeciden ad ve soyadini ,
*  4 eded imtahan neticesini daxil etmesini isteyirik.
*
*
* ortalama 45-den kicikdirse : qeyri - kafi Kece bilmediz
* ortalama 45-e beraber ve ya 70-den  kicikdirse :  Meqbul
* ortalama 70-e beraber ve ya 90-dan  kicikdirse :  Yaxsi
* ortalama 90 ile  100 arasinda (100-de daxil) :  Ela
*
* qeyd : ortalama 100 - den boyuk ola bilmez.
*
* netice asagidaki kimi olmalidir.
*
* Ad ve Soyad : Parviz Aliyev
*
* Netice : 50
* Netice : 40
* Netice : 30
* Netice : 20
*
*Ortalama : 35
* Semestr Yekunu: qeyri - kafi Kece bilmediz
*/
/*
//            HElli
decimal netice1, netice2, netice3, netice4, ortalama;

print("Bal Ortalamasinin Hesablanmasi");
string name = input("Adinizi ve Soyadinizi yazin :");
netice1 = Convert.ToDecimal(input("1-ci Imtahanin neticenisini yazin :"));
netice2 = Convert.ToDecimal(input("2-ci Imtahanin neticenisini yazin :"));
netice3 = Convert.ToDecimal(input("3-cu Imtahanin neticenisini yazin :"));
netice4 = Convert.ToDecimal(input("4-cu Imtahanin neticenisini yazin :"));
ortalama = (netice1 + netice2 + netice3 + netice4) / 4;

print($"Ad ve Soyad : {name}");
print($"Netice : {netice1}");
print($"Netice : {netice2}");
print($"Netice : {netice3}");
print($"Netice : {netice4}");
print($"Ortalama : {ortalama}");

if (ortalama > 100)
    print("Ortalama 100 - den boyuk ola bilmez.");
else if (90 <= ortalama && ortalama <= 100)
    print("Semestr Yekunu : Ela ");
else if (70 <= ortalama && ortalama < 90)
    print("Semestr Yekunu : Yaxwi ");
else if (45 <= ortalama && ortalama < 70)
    print("Semestr Yekunu : Meqbul ");
else
    print("Semestr Yekunu : Qeyri-Kafi Kece bilmediz");
*/
#endregion

#endregion

#region 2. while ile consoledan daxil edilen ededden geriye dogru loop
/*
int eded = int.Parse(input("Eded daxil edin :"));
while (eded >= 1)
{
    print(eded);
    eded--;
}
*/
#endregion

#region 3. while ile 0 ile 100 arasindaki tek ededlerin cemi

/*int cem = 0;
int i = 1;
while (i<100)
{
    //if (i % 2 != 0){cem += i;}
    //2- ci variyant
    cem = i % 2 != 0 ? cem += i:cem;
    i++;
}
print(cem);
*/

#endregion

#region 4. while ile faktorialin hesablanmasi

#region Task 4.1
/*
decimal faktorial = decimal.Parse(input("Faktorialin hesablanmasi ucun eded daxil edin :"));
decimal hasil = 1;
int say = 1;
while (say <= faktorial)
{
    hasil *= say;
    say++;
}
print(hasil);
*/
#endregion

#region Task 4.2
/*
2 - ci Hell yolu
decimal faktorial = decimal.Parse(input("Faktorialin hesablanmasi ucun eded daxil edin :"));
decimal hasil = 1;
while (faktorial > 1)
{
    hasil *= faktorial;
    faktorial--;
}
print(hasil);
*/
#endregion

#endregion

#region 5. Mini login

#region Task 5.1
/*
 * Username ve password deye deyisenler teyin edin.
 *
 *  Username : admin
 *  Password : 6gH123
 *
 * Istifadeciden  username ve Password daxil etmesini isteyin.
 *
 * Daxil edilen username ve passwordun teyin edilen
 * deyisenlerin deyerine beraber olub olmamasini yoxlayin,
 *
 * Netice olaraq login emeliyyatinin ugurlu ve ya
 *
 *  daxil edilen username ve ya sifrenin dogru olmadigi mesajini verin.
 *  
 *  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 *  qeyd: eyni taski, if, ternary operator ve switch ile yazin
 *
 */
/*
//  Helli
string Username = "admin";
string Password = "123";
string name = input("Username daxil edin :");
string code = input("Password daxil edin :");

if (Username == name && Password == code)
    print("Login emelliyati ugurla yerine yetirildi");
else if (Username != name && Password == code)
    print("Username yanlis girdiniz ");
else if (Username == name && Password != code)
    print("Username yanlis girdiniz ");
else
    print("Username ve Password yanlis girildi ");
*/
#endregion

#region Task 5.2
/*
 * Istifadeciden role(selahiyyet) isteyerek daxil etdiyi role uygun mesaj verin.
 *
 *  Istifadeci selahiyyeti (I.S) :
 *
 * I.S = AA , BB , CC ise "Admin selahiyyetlerine sahibsiniz."
 * I.S = MM "Moderator selahiyyetlerine sahibsiniz."
 * I.S = MH "Muhasib selahiyyetlerine sahibsiniz."
 * I.S = UU "Standart istifadeci selahiyyetlerine sahibsiniz."
 *
 * qeyd edilenlerden ferqli olarsa : "Daxil edilen selahiyyet dogru deyil"
 *
 * switchden istifade edin.
 */
/*
//               HElli
string role = input("Selahiyyet daxil edin :");
switch (role)
{
    case "AA":
    case "BB":
    case "CC":
        print("Admin selahiyyetlerine sahibsiniz.");
        break;
    case "MM":
        print("Moderator selahiyyetlerine sahibsiniz.");
        break;
    case "MH":
        print("Muhasib selahiyyetlerine sahibsiniz.");
        break;
    case "UU":
        print("Standart istifadeci selahiyyetlerine sahibsiniz.");
        break;
    default:
        print("Daxil edilen selahiyyet dogru deyil");
        break;
}*/
#endregion

#endregion

#region 6. calculator : switch
/*
 * switch istifade ederek calculator yazin
 *
 * qeyd: hem normal switchden istifade edin hem de expressionla olan variantla
 */

#region 6.1
/*
print("Hesablama");
char emeliyyat = Convert.ToChar(input(" ( + , - , * , /) Hansi emeliyyyati aparmaq isdiyirsiz? :"));
decimal number1 = Convert.ToDecimal(input("Ilk ededi daxil edin :"));
decimal number2 = Convert.ToDecimal(input("Ikinci ededi daxil edin :"));
switch (emeliyyat)
{
    case '+':
        print($"{number1} + {number2} = {number1 + number2}");
        break;
    case '-':
        print($"{number1} - {number2} = {number1 - number2}");
        break;
    case '*':
        print($"{number1} * {number2} = {number1 * number2}");
        break;
    case '/':
        if (number2 == 0)
            print("Bolen 0 ola bilmez..!");
        else
            print($"{number1} / {number2} = {number1 / number2}");
        break;
    default:
        print("Duzgun emeliyat daxil edin");
        break;
}*/
#endregion

#region 6.2
/*
print("Hesablama");
char emeliyyat = Convert.ToChar(input(" ( + , - , * , /) Hansi emeliyyyati aparmaq isdiyirsiz? :"));
decimal number1 = Convert.ToDecimal(input("Ilk ededi daxil edin :"));
decimal number2 = Convert.ToDecimal(input("Ikinci ededi daxil edin :"));

string hesablama = emeliyyat switch
{
    '+' => $"{number1} + {number2} = {number1 + number2}",
    '-' => $"{number1} - {number2} = {number1 - number2}",
    '*' => $"{number1} * {number2} = {number1 * number2}",
    '/' => number2 == 0? "Bolen 0 ola bilmez" : $"{number1} / {number2} = {number1 / number2}",
    _ => "Duzgun emeliyat daxil edin"
};
print(hesablama);
*/
#endregion

#endregion

#region 7. menfi musbet
/*
 * Daxil edilen ededin menfi ve ya musbet oldugunu yoxlayin ona uygun geriye deyer qaytarin.
 *
 * qeyd: if ve ternary istifade edin ayri ayri
 */
#region 7.1
/*
//   1-ci HElli
string yoxlama = input("Eded daxil edin :");
if (yoxlama[0] == '-')
    print($"{yoxlama} Ededi Menfidir.");
else
    print($"{yoxlama} Ededi Musbetdir.");
*/
#endregion

#region 7.2
/*
//2 - ci HElli
print(yoxlama[0] == '-' ? $"{ yoxlama} Ededi Menfidir" : $"{yoxlama} Ededi Musbetdir");
*/
#endregion

#region 7.3
/*
 //3 - cu HElli
foreach (var item in yoxlama)
{
    if (item == '-')
        print($"{yoxlama} Ededi Menfidir.");
    else
        print($"{yoxlama} Ededi Musbetdir.");
    break;
}
*/
#endregion

#region 7.4
/*
//4 - cu HElli
foreach (var item in yoxlama)
{
    print(item == '-' ? $"{ yoxlama} Ededi Menfidir" : $"{yoxlama} Ededi Musbetdir");
    break;
}*/
#endregion

#endregion

#region 8. vurma cedveli
/*
 * vurma cedveli hazirlayin. (12 vereqli defeterlerin arxasindaki gorunuse sahib olsun.)
 * 
 * netice asagidaki kimi olsun
 *
 * 1 * 1 = 1   1 * 2 = 2  1 * 3 = 3 // belece davam edir
 * 2 * 1 = 2   2 * 2 = 4  2 * 3 = 6
 * 
 */
/*
for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.Write($" {i} * {j} = {i*j} \t");
    }
}*/
#endregion

#region exam

/*
 * 1. int num1=10;
 *    int num2=20;
 *    bool result = num1 > num2;
 *
 *  asagidakilardan hansi uygun gelir ?
 *
 *  num1 deyeri num2 deyerinden kicikdir ve bool tipinde olan result
 *  deyiseni bu iki deyerin muqayisesinden false deyerini alir.
 *
 * num1 deyeri num2 deyerine beraberdir ve bool tipinde olan result
 *  deyiseni true-dur.
 *
 * CAVAB : num1 deyeri num2 deyerinden kicikdir ve bool tipinde olan result
 *   deyiseni bu iki deyerin muqayisesinden false deyerini alir.
 *   
 ***********************************************************************************************
 * 2. int num1 = 100;
 *
 *    int num2 = 2;
 *    
 *    int result = (num1 + 10 ) / num2;
 *    
 *    Console.WriteLine(result);
 *
 * Result : 33;
 * Result : 55;
 * Result : 66;
 * 
 * CAVAB : Result : 55;
 * 
 * *******************************************************************************************
 * 3. Boyuk beraberdir  ve beraber deyildir operatorlari hansilardir.
 *
 * =! , ==
 * == , <=
 * >= , <=
 * >= , !=
 * 
 * CAVAB : >= , !=
 */

#endregion

#endregion

#region Methods
/*
static void print(object value)
{
    Console.WriteLine(value);
}

static string input(string value)
{
    Console.Write(value);
    return Console.ReadLine();
}*/
#endregion