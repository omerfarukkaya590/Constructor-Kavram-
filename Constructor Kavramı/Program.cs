using System;
internal class Program
{
    private static void Main(string[] args)
    {
     
     System.Console.WriteLine("ÇALIŞAN 1");
        Calisan calisan1 = new Calisan("Ayşe", "Kara",1232332132,"İnsan Kaynakları" );
       

        calisan1.CalisanBilgileri();
        System.Console.WriteLine("*********************");
     System.Console.WriteLine("ÇALIŞAN 2");

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";
        calisan2.No = 1232332232;
        calisan2.Departman = "Satın Alma";
        
        calisan2.CalisanBilgileri();
     System.Console.WriteLine("ÇALIŞAN 3");

        Calisan calisan3= new Calisan("ÖmerFaruk","Kaya");
        calisan3.CalisanBilgileri();

    }
}
// [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
//  [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
 class Calisan{

    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad,string soyad,int no,string departman)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
    }

    public Calisan(string ad,string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;
     
    }

    public Calisan(){}


    public void CalisanBilgileri(){
        Console.WriteLine("Çalışan Adı:{0}",Ad);
        Console.WriteLine("Çalışan Soydı:{0}",Soyad);
        Console.WriteLine("Çalışan No:{0}",No);
        Console.WriteLine("Çalışan Departman:{0}",Departman);
    }

 }
 

