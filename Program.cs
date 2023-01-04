// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dizi işlemleri...");

int[] sayilar= new int [5];

string [] hayvanlar = {"kedi","köpek","kuş"};

sayilar[3]=10;

hayvanlar[0]= "tavuk";

foreach (var hayvan in hayvanlar)
{
    Console.WriteLine(hayvan);
}

//Klavyeden girilen n tane değerin ortalamasını alan kod

Console.Write("Girmek istdeğiniz sayı miktarını giriniz: ");
String s = Console.ReadLine();
int length= int.Parse(s);
int [] numbers = new int[length];
for (int i = 0; i < length; i++)
{
    Console.Write("Lütfen {0}. sayiyi giriniz:", i+1 );
    numbers [i]=Convert.ToInt32(Console.ReadLine());
}

int toplam=0;
foreach (var number in numbers)
{
    toplam+=number;
}

Console.WriteLine("Girmiş olduğunuz {0} adet sayinin ortalaması: {1}",length,toplam/length);