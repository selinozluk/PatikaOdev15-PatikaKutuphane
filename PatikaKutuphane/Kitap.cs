using System;

namespace PatikaKutuphane
{
    // Classlar nesne oluşturma şablonudur
    internal class Kitap
    {
        // Propertyler: Nesnenin sahip olacağı verileri tutar.
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public DateTime RegisterDate { get; set; }

        // Default constructor – parametre almadan nesne oluşturur
        public Kitap()
        {
            RegisterDate = DateTime.Now; // Nesne oluşturulduğu an kayıt tarihi atanır
        }

        // Alternatif constructor – parametre alır, değerleri direkt atar
        public Kitap(string title, string authorName, string authorSurname, int pageCount, string publisher)
        {
            Title = title;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PageCount = pageCount;
            Publisher = publisher;
            RegisterDate = DateTime.Now;
        }

        // Kitap bilgilerini yazdıran metot
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {AuthorName} {AuthorSurname}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Register Date: {RegisterDate.ToShortDateString()}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
