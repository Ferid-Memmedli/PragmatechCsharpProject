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
/*
int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

for (int i = 0; i < intArray.Length; i++)
{
    for (int j = 0; j < intArray.Length; j++)
    {
        if (intArray[i] < intArray[j])
        {
            int boyukEded = intArray[j];
            intArray[j] = intArray[i];
            intArray[i] = boyukEded;
        }
    }
}

foreach (var item in intArray)
{
    Print(item);
}
*/

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
int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

for (int i = 0; i < intArray.Length; i++)
{
    for (int j = 0; j < intArray.Length; j++)
    {
        if (intArray[i] > intArray[j])
        {
            int kicikEded = intArray[j];
            intArray[j] = intArray[i];
            intArray[i] = kicikEded;
        }
    }
}

foreach (var item in intArray)
{
    Print(item);
}
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
int[] reverseArr = new int[arr.Length];
int index = 0;
for (int i = arr.Length - 1; i >= 0; i--)
{
    reverseArr[index] = arr[i];
    index++;
}
Array.ForEach(reverseArr, e => Print(e));
*/
//******************************************************************  2-ci HELLI  **********************************************************************
/*
int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = temp;
}
Array.ForEach(arr, e => Print(e));
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
            for (int i = 0; i < eskinaslar.Length; i++)
            {
                if (money >= eskinaslar[i])
                {
                    int temp = money / eskinaslar[i];
                    money = money - eskinaslar[i] * temp;
                    Print($"{temp} eded {eskinaslar[i]}");
                }
            }
        }
        catch (Exception)
        {
            Print("Duzgun melumat daxil olunmadi");
        }
    }
}*/

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
if (musbetEded1 > 0 && musbetEded2 > 0)
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

#endregion Methods