using PatikaKutuphane;

internal class Program
{
     static void Main(string[] args)
    {

        // Default constructor ile nesne oluşturduk
        Kitap book1 = new Kitap
        {
            Title = "Adı Aylin",
            AuthorName = "Ayşe",
            AuthorSurname = "Kulin",
            PageCount = 398,
            Publisher = "Remzi Kitabevi"
        };

        // Parametreli constructor ile direkt değer atanmış nesne
        Kitap book2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

        // Kitap bilgilerini ekrana yazdırır
        book1.PrintInfo();
        book2.PrintInfo();
    }
}
