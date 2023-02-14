using System;

namespace vscode
{
class Program
{

public static void Main()
{
    Console.WriteLine("selam");
    string isim = Console.ReadLine();

    string degisken1 = "metinsel";
    string degisken2 = "degerler";
    string degisken3= degisken1 + degisken2;

    double ondalik= 3.14;
    int tamsayi1 = 324;
    bool mantiksal = true;

    DateTime tarih = DateTime.Now;
    string tarih2 = DateTime.Now.ToString("dd.MM.yyyy");
    Console.WriteLine(tarih2 + "tarih");
    

}   

}

}

