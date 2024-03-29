﻿
string[] seasons = {"Yaz","Kış","İlkbahar","Sonbahar"};

int[] array = new int[3];
array[1] = 123;
array[2] = 456;

Console.WriteLine(array[0]); // atanmazsa 0 değerini alır
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(seasons[2]);
Console.WriteLine(seasons[3]);

Console.Write("Eleman sayısını giriniz:");
int diziUzunluğu = int.Parse(Console.ReadLine());
int[] dizi = new int[diziUzunluğu];

for (int i=0; i<diziUzunluğu; i++)
{
    Console.Write("{0}. dizi:",i+1);
    dizi[i] = int.Parse(Console.ReadLine());   
}

int toplam = 0;
foreach (var i in dizi)
{
    toplam += i;
}

Console.WriteLine("Dizinin ortalaması:"+toplam/diziUzunluğu);

Console.WriteLine("********************************************");
int[] sayiDizisi = {54,765,24,85,752,88,45,96,8,1,75,2};

foreach (var sayi in sayiDizisi) {
    Console.WriteLine(sayi);
}

Console.WriteLine("Sort");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi) {
    Console.WriteLine(sayi);
}

Console.WriteLine("Clear");
Array.Clear(sayiDizisi,3,1);
foreach (var sayi in sayiDizisi) {
    Console.WriteLine(sayi);
}

