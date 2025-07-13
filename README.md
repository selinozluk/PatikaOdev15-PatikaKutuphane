# PatikaOdev15 - Patika Kütüphane (Kitap Constructor Uygulaması)

# Proje Açıklaması
Bu uygulama, Patika Kütüphane sistemi için bir kitap nesnesi oluşturma örneğidir.
Amaç:
"Adı Aylin" kitabını hem default constructor hem de parametreli constructor kullanarak oluşturmak.

# Kullanılan Yapılar:

Class
Kitap adında bir sınıf tanımlanmıştır. Class'lar nesne üretmek için şablondur.

Property
Kitabın özelliklerini tanımlamak için Title, AuthorName, AuthorSurname, PageCount, Publisher, RegisterDate gibi property'ler kullanılmıştır.

Constructor
Default Constructor: Parametre almayan, boş bir nesne oluşturur.

Parametreli Constructor: Kitap bilgilerini parametre olarak alır ve nesne oluşturulurken doğrudan değer ataması yapar.

Her iki constructor'da RegisterDate otomatik olarak DateTime.Now ile atanır.

New
new kelimesi ile Kitap sınıfından nesne üretilmiştir.

# Uygulama Akışı

Kitap sınıfı tanımlanır.

Adı Aylin kitabı:

Birinci kez default constructor ile oluşturulup özellikleri sonradan atanır.

İkinci kez parametreli constructor ile direkt oluşturulur.

Her iki nesnenin bilgileri PrintInfo() metodu ile konsola yazdırılır.

