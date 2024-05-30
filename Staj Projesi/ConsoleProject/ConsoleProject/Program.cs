using System;

class Program
{
    static void Main(string[] args)
    {

        // Oynayacağı takımlar

        string[] rakipler = { "Galatasaray (Ev Sahibi)", "Galatasaray (Deplasman)",
            "Beşiktaş (Ev Sahibi)", "Beşiktaş (Deplasman)", "Trabzonspor(Ev Sahibi)", "Trabzonspor(Deplasman)",
            "Başakşehir (Ev Sahibi)", "Başakşehir (Deplasman)", "Ankaragücü (Ev Sahibi)", "Ankaragücü (Deplasman)",
            "Antalyaspor (Ev Sahibi)", "Antalyaspor (Deplsaman)", "Göztepe (Ev Sahibi)", "Göztepe (Deplasman)", "Konyaspor (Ev Sahibi)",
            "Konyaspor (Deplasman)", "Sivasspor(Ev Sahibi)", "Sivasspor(Deplasman)", "Alanyaspor(Ev Sahibi)", "Alanyaspor(Deplasman)",
            "Pendikspor (Ev Sahibi)", "Pendikspor (Deplasman)", "Kayserispor (Ev Sahibi)", "Kayserispor (Deplasman)", "Hatayspor (Ev Sahibi)",
            "Hatayspor (Deplasman)", "Kasımpaşa (Ev Sahibi)", "Kasımpaşa (Deplasman)", "Adana Demirspor (Ev Sahibi)", "Adana Demirspor (Deplasman)",
            "İstanbulspor (Ev Sahibi)", "İstanbulspor (Deplasman)", "Rizespor (Ev Sahibi)", "Rizespor (Deplasman)", "Samsunspor (Ev Sahibi)",
            "Samsunspor (Deplasman)","Galatasaray (Ev Sahibi)", };


        int maçSayısı = rakipler.Length;


        // Fikstürü karıştırmak için rastgele bir dizi oluştur

        Random rnd = new Random();
        int[] dizi = new int[37];

        Console.WriteLine("Fenerbahçe'nin Fikstürü:");
        Console.WriteLine(maçSayısı);

        for (int i = 0; i < maçSayısı; i++)
        {
        etiket:
            int sayi = rnd.Next(0, 37);
            for (int j = 0; j <= i; j++) { if (sayi == dizi[j]) goto etiket; }
            dizi[i] = sayi;
            string rakip = rakipler[sayi];

            Console.WriteLine($"Hafta {i}: Fenerbahçe - {rakip}");

        }

        Console.ReadLine();
    }
}
