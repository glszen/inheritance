using inheritance;
using System.ComponentModel;

ogrenci ogrenci = new ogrenci() { Ad = "Emily ", Soyad = "Cooper", ogrenciNo = " 2154851420" };
Console.WriteLine(ogrenci.Ad + ogrenci.Soyad + ogrenci.ogrenciNo);

ogretmen ogretmen = new ogretmen() { Ad = "Mindy ", Soyad = "Chen", Maas = " 60.000 TL" };
Console.WriteLine(ogretmen.Ad + ogretmen.Soyad + ogretmen.Maas);