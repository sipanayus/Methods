// See https://aka.ms/new-console-template for more information
using Methods;

Console.WriteLine("Hello, World!");


// do not repeat yourself DRY

string UrunAdi = "elma";
double fiyati = 12;
string acıklama = "amasya elması";


string[] meyveler = new string[] { };

Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyati = 12;
urun1.Aciklama = "amasya elması";


Urun urun2 = new Urun();
urun2.Adi = "çilek";
urun2.Fiyati = 25;
urun2.Aciklama = "silikfe çileği";


Urun urun3 = new Urun();
urun3.Adi = "karpuz";
urun3.Fiyati = 45;
urun3.Aciklama = "diyarbakır karpuzu";


Urun[] urunler = new Urun[] {urun1, urun2,urun3 }; 

//type-safe-- tipgüvenli 
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(".................");
}


Console.WriteLine(  "---------methotlar----------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle(urun3);



sepetManager.Ekle2("armut", "ayva",12,5 );
sepetManager.Ekle2("kivi" , "ekşi", 16,5);



