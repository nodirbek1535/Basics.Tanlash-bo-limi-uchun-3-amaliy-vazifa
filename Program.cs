using System;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
// Palindrome Tekshiruvi: Palindrom, so'zning boshidan oxiriga qadar o'qilgandagi tartibida ham, 
//oxiridan boshiga qadar o'qilgandagi tartibida ham bir xil bo'lgan so'z yoki satrdir. Misol uchun
//, "kayak", "radar" va "level" so'zlari palindromlarga misol bo'lishi mumkin. Sizdan kiritilgan satrning 
//palindrom bo'lishini tekshiruvchi dastur yozishni so'raymiz. Agar kiritilgan satr palindrom bo'lsa, dastur 
//"Palindrom" degan xabarni chiqaradi, aks holda "Palindrom emas" degan xabarni chiqaradi.
// Input: "kayak"
// Output: "Palindrom"
Console.WriteLine("Siz 1-dasturdasiz iltimos biror sozni kiriting(ingliz  alifbosida)");
string input=Console.ReadLine();
string ab="";
for(int i=0;i<input.Length/2;i++)
{
    if(input[0+i]==input[input.Length-1-i])
    {
        continue;
    }
    else
    {
        Console.WriteLine(ab="Is not Palindrome");
        break;
    }
}
if(ab!="Is not Palindrome")
{
    Console.WriteLine("Palindrome");
}
Console.WriteLine("1-dastur yakunlandi.");
// Temperatura o'girish: Foydalanuvchidan o'zbek tilida graduslar (Selsiyus) bo'yicha 
//temperaturani kiritishni so'rang. Keyin kiritilgan temperaturani Fahrenheit va Kelvin ga o'girib, 
//natijalarni ekranga chiqaring. Switch-operatoridan foydalaning.
// Input: 25
// Output: Selsiyus: 25, Fahrenheit: 77.0, Kelvin: 298.15
Console.WriteLine("siz 2-dasturdasiz iltimos darjani kiriting(selsiy shkalasi boyicha)");
double Selsiyus=double.Parse(Console.ReadLine());
double Fahrenheit=Selsiyus+52.0;
double Kelvin=Selsiyus+273.15;
Console.WriteLine($"Selsiyus: {Selsiyus}, Fahrenheit: {Fahrenheit}, Kelvin: {Kelvin}");
Console.WriteLine("2-dastur yakunlandi.");
// Sonlarni tartiblash: Foydalanuvchidan o'zbek tilida sonlarni kiritishni so'rang. 
// Keyin kiritilgan sonlarni tartiblangan qator (ascending) va teskari tartib (descending) 
// bo'ylab ekranga chiqaring. Switch-operatoridan foydalaning.
// Input: 9, 4, 7, 2, 5
// Output:
// Tartiblangan qator: 2, 4, 5, 7, 9
// Teskari tartib: 9, 7, 5, 4, 2
Console.WriteLine("siz 3-dasturdasi nechta elementli qator kirgizmoqchisiz:");
int a=int.Parse(Console.ReadLine());
int[] array=new int[a];
for(int i=0;i<array.Length;i++)
{
    Console.WriteLine((i+1)+"-sonni kiriting:");
    array[i]=int.Parse(Console.ReadLine());
}
int b=0;
for(int i=0;i<array.Length;i++)
{
    for(int j=0;j<array.Length;j++)
    {
        if(array[j]<=array[i])
        {
            continue;
        }
        else
        {
            b=array[j];
            array[j]=array[i];
            array[i]=b;
        }

    }
}
Console.Write("Tartiblanga qator:");
for(int i=0;i<array.Length;i++)
{
    Console.Write(array[i]+", ");
}
Console.WriteLine();
Console.Write("Teskari tartib:");
for(int i=array.Length-1;i>=0;i--)
{
    Console.Write(array[i]+", ");
}
Console.WriteLine();
Console.WriteLine("3-Dastur yakunlandi.");

