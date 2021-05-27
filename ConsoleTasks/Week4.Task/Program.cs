using System;

#region Tasks

#region 1. artan sira

/*
* asagida verilen arrayin elementlerini artan sira ile
* ekrana cap edin
*
* qeyd : manual edilecek/ hazir methodlarsiz
*/

//******************************************************************  HELLI  **********************************************************************

int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

SortMinToMax(intArray);

PrintArray(intArray);

#endregion 1. artan sira

#region 2. azalan sira

/*
* asagida verilen arrayin elementlerini azalan sira ile
* ekrana cap edin
*
* qeyd : manual edilecek/ hazir methodlarsiz
*/

//******************************************************************  HELLI  **********************************************************************

/*
int[] intArray1 = { 2, 9, 4, 3, 5, 1, 7 };

SortMaxToMin(intArray1);

PrintArray(intArray1);
*/
#endregion 2. azalan sira

#region 3. geriden

/*
* asagida verilen arrayin elementlerini tersine duzerek
* ekrana cap edin
*
* qeyd : manual edilecek/ hazir methodlarsiz
*/

//******************************************************************  HELLI  **********************************************************************
/*
int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
ReverseIntArray(arr);
PrintArray(arr);
*/
#endregion 3. geriden

#region 4. para pul el cirki

/*
* istifadeci bankomatdan cixarmaq istediyi meblegi daxil edir(sonsuz sayda, emeliyyati dayandirmagida nezere alin).
* daxil edilen meblege uygun console-a eskinaslari sayi ile cap edirik.
*
* eskinaslar : 200, 100, 50, 20, 10, 5, 1
*
* meselen daxil edilen pul miqdari 45 dir:
* 2 eded 20 azn
* 1 eded 5 azn
*
*/

//******************************************************************  HELLI  **********************************************************************
/*
int[] eskinaslar = { 200, 100, 50, 20, 10, 5, 1 };
while (true)
{
    string mebleg = Input("Cixartmaq isdediyiniz meblegi daxil edin ve ya cixis edmeq ucun 'Y' daxil edin: ");
    if (mebleg.ToLower() == "y")
    {
        Print("Emeliyyat dayandirildi.");
        break;
    }
    else if (mebleg.StartsWith("-") == true)
        Print("Menfi eded daxil edile bilmez.");
    else
    {
        try
        {
            int money = int.Parse(mebleg);
            PulCixarisi(money);
        }
        catch (Exception)
        {
            Print("Duzgun melumat daxil olunmadi");
        }
    }
}
*/
#endregion 4. para pul el cirki

#region 5. tek ededlerin kublari cemi

/*
* 1-10 qeder tek ededlerin kublarinin cemini yazin.
*/

//******************************************************************  HELLI  **********************************************************************

/*
double cem = 0;
for (int i = 1; i <= 10; i++)
{
cem += i % 2 != 0 ? i * i * i : 0;
//if (i % 2 != 0)
//    cem += i*i*i;
}
Print(cem);
*/

#endregion 5. tek ededlerin kublari cemi

#region 6. yas hesablanmasi

/*
* dogum tarixini daxil eden istifedecinin
* yasini hesablayib ekrana cap edin
*/

//******************************************************************  HELLI  **********************************************************************

/*
Print("Yash hesablama");
int dogumIli = int.Parse(Input("Dogum ilinizi daxil edin: "));
Print(DateTime.Today.Year - dogumIli);
*/

#endregion 6. yas hesablanmasi

#region 7.

/*
* istifadeci terefinden daxil edilen iki musbet ededin hasilini vurma emeliyyati ile
* deyil toplama emeliyyati ile ekrana cap edin.
*/

//******************************************************************  HELLI  **********************************************************************
/*
double musbetEded1 = double.Parse(Input("Musbet eded daxil edin: "));
double musbetEded2 = double.Parse(Input("Ikinci musbet eded daxil edin: "));
double hasil = 0;
if (PozitivEded(musbetEded1) && PozitivEded(musbetEded2))
{
    for (int i = 1; i <= musbetEded1; i++)
        hasil += musbetEded2;
    Print($"Cavab : {hasil}");
}
else if (musbetEded1 == 0 || musbetEded2 == 0)
    Print("Cavab : 0");
else
    Print("Menfi eded daxil edmisiz");
*/

#endregion 7.

#endregion Tasks

#region Methods

static void Print(object value)
{
    Console.WriteLine(value);
}

static string Input(object value)
{
    Console.Write(value);
    return Console.ReadLine();
}

static void PrintArray(int[] list)
{
    Array.ForEach(list, e => Console.Write(e + " "));
}

static void SortMaxToMin(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        for (int j = i + 1; j < list.Length; j++)
        {
            if (list[i] < list[j])
            {
                int boyukEded = list[j];
                list[j] = list[i];
                list[i] = boyukEded;
            }
        }
    }
}

static void SortMinToMax(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        for (int j = i + 1; j < list.Length; j++)
        {
            if (list[i] > list[j])
            {
                int boyukEded = list[j];
                list[j] = list[i];
                list[i] = boyukEded;
            }
        }
    }
}

static void ReverseIntArray(int[] list)
{
    for (int i = 0; i < list.Length / 2; i++)
    {
        var temp = list[i];
        list[i] = list[list.Length - i - 1];
        list[list.Length - i - 1] = temp;
    }
}

static void PulCixarisi(int cixarisPulu)
{
    int[] eskinaslar = { 200, 100, 50, 20, 10, 5, 1 };
    for (int i = 0; i < eskinaslar.Length; i++)
    {
        if (cixarisPulu >= eskinaslar[i])
        {
            int temp = cixarisPulu / eskinaslar[i];
            cixarisPulu = cixarisPulu - eskinaslar[i] * temp;
            Print($"{temp} eded {eskinaslar[i]}");
        }
    }
}

static bool PozitivEded(double eded)
{
    return eded >= 0;
}

#endregion Methods