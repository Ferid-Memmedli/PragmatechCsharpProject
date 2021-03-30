using System;

#region Task

#region 1. Bal Ortalamasinin Hesablanmasi
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

//decimal netice1, netice2, netice3, ortalama;
//print("Ortalamanin Hesaplanmasi");
//netice1 = Convert.ToDecimal(input("1-ci Imtahanin neticenisini yazin :"));
//netice2 = Convert.ToDecimal(input("2-ci Imtahanin neticenisini yazin :"));
//netice3 = Convert.ToDecimal(input("3-cu Imtahanin neticenisini yazin :"));
//ortalama = (netice1 + netice2 + netice3) / 3;
//print($"Netice : {netice1}");
//print($"Netice : {netice2}");
//print($"Netice : {netice3}");
//string netice = ortalama > 45 ? $"Sizin ortalamaniz : {ortalama} ve 45-den boyukdur" :
//    (ortalama == 45 ? "Sizin ortalamaniz 45-e beraberdir" : $"Sizin ortalamaniz : {ortalama} ve 45-den kicikdir");
//print("Ortalama 45-e beraber ve ya boyukdurmu?");
//print(netice);

//-----------------------------------------------------------------------------------------------------------------

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

//decimal netice1, netice2, netice3, netice4,ortalama;
//print("Bal Ortalamasinin Hesablanmasi :");
//string name = input("Adinizi ve Soyadinizi yazin :");
//netice1 = Convert.ToDecimal(input("1-ci Imtahanin neticenisini yazin :"));
//netice2 = Convert.ToDecimal(input("2-ci Imtahanin neticenisini yazin :"));
//netice3 = Convert.ToDecimal(input("3-cu Imtahanin neticenisini yazin :"));
//netice4 = Convert.ToDecimal(input("4-cu Imtahanin neticenisini yazin :"));
//ortalama = (netice1 + netice2 + netice3 + netice4) / 4;
//print($"Ad ve Soyad : {name}");
//print($"Netice : {netice1}");
//print($"Netice : {netice2}");
//print($"Netice : {netice3}");
//print($"Netice : {netice4}");
//print($"Ortalama : {ortalama}");

#endregion

#region 2. while ile consoledan daxil edilen ededden geriye dogru loop

//int eded = int.Parse(input("Eded daxil edin :"));
//while (eded >= 1)
//{
//    print(eded);
//    eded--;
//}
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
//  1-ci Hell yolu
//decimal faktorial = decimal.Parse(input("Faktorialin hesablanmasi ucun eded daxil edin :"));
//decimal hasil = 1;
//int say = 1;
//while (say<=faktorial)
//{
//    hasil *= say;
//    say++;
//}
//print(hasil);

//  2-ci Hell yolu
//decimal faktorial = decimal.Parse(input("Faktorialin hesablanmasi ucun eded daxil edin :"));
//decimal hasil = 1;
//while (faktorial>1)
//{
//    hasil *= faktorial;
//    faktorial--;
//}
//print(hasil);
#endregion

#region 5. Mini login

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
 *
 */
//  Helli
//string Username = "admin";
//string Password = "123";
//string name = input("Username daxil edin :");
//string code = input("Password daxil edin :");
//if (Username==name && Password == code)
//    print("Login emelliyati ugurla yerine yetirildi");
//else if (Username != name && Password == code)
//    print("Username yanlis girdiniz ");
//else if (Username == name && Password != code)
//    print("Username yanlis girdiniz ");
//else
//    print("Username ve Password yanlis girildi ");

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
static void print(object value)
{
    Console.WriteLine(value);
}

static string input(string value)
{
    Console.Write(value);
    return Console.ReadLine();
}
#endregion
