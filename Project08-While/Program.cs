#region 1.AŞAMA
// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırıyoruz.
int i = 1;
while (i <= 10) //koşul       //değişken 10'a eşit olana kadar döngüyü devam ettir.
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++; //i her seferinde bir artarak
}
Console.WriteLine();
#endregion

#region 2.AŞAMA
//1 ile 20 arasındaki sayıları konsol ekranına yazdırıyoruz.
int sayi = 1;//değişken
while (sayi <= 20)//koşul
{
    Console.WriteLine(sayi);
    sayi++;
}
Console.WriteLine();
#endregion

#region 3.AŞAMA-1
//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırıyoruz.
int ciftsayi = 2;//değişken
while (ciftsayi <= 20)//koşul
{
    Console.WriteLine(ciftsayi);
    ciftsayi += 2;//sadece çift sayıları seçmek için
}
Console.WriteLine();
#endregion

#region 3.AŞAMA-2
//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırıyoruz.
int sayilar = 1;//değişken
while (sayilar <= 20)//koşul
{
    if (sayilar % 2 == 0)
    {
        Console.WriteLine(sayilar);
    }
    sayilar++;
}
Console.WriteLine();
#endregion

#region 4.AŞAMA
//50 ile 150 arasındaki sayıların toplamını ekrana yazdırıyoruz.
int toplam = 0;
int baslangıcsayi = 50;

while (baslangıcsayi <= 150)
{
    toplam += baslangıcsayi; //toplam = toplam + baslangıcsayi
    baslangıcsayi++;
}
Console.WriteLine("Toplam: " + toplam);
Console.WriteLine();
#endregion

#region 5.AŞAMA
//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırıyoruz.
int bassayi = 1;
int CiftToplam = 0;
int TekToplam = 0;

while (bassayi <= 120)
{
    if (bassayi % 2 == 0)
    {
        CiftToplam += bassayi;
    }
    else
    {
        TekToplam += bassayi;
    }
    bassayi++;
}
Console.WriteLine("Çift Sayıların Toplamı: " + CiftToplam);
Console.WriteLine("Tek Sayıların Toplamı: " + TekToplam);
Console.WriteLine();
#endregion

Console.ReadKey();


