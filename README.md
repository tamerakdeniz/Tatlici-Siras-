## Tatlıcı Sırası
Bu proje, C# programlama dilini kullanarak bir tatlıcı sırası oluşturmak için Stack veri yapısını kullanan bir örnektir.

## Stack Nedir?
Stack, verilerin son giren ilk çıkar (Last-In, First-Out - LIFO) prensibiyle çalışan bir veri yapısıdır. Stack'e yeni bir eleman eklendiğinde, eklenen eleman listenin en üstüne yerleştirilir ve çıkarılacak elemanlar da yine listenin en üstünden alınır. Bu nedenle, en son eklenen eleman en önce çıkarılır.

## Proje Detayları
Bu proje, bir tatlıcıya gelen müşterilerin sıraya girdiği bir senaryoyu simüle eder. Müşterilerin adları, sıraya giriş sıralarına göre Stack veri yapısında tutulur. Her müşteri sıraya girdiğinde Stack'e eklenir ve sıradaki müşteri çağırıldığında Stack'ten çıkarılır.

## Proje, aşağıdaki bileşenleri içerir:

TatliciSırası sınıfı: Stack'i yöneten ve müşteri işlemlerini gerçekleştiren ana sınıftır. Aşağıdaki metotları içerir:
MusteriEkle(string musteriAdi): Yeni bir müşteriyi sıraya ekler.
MusteriCikar(): Sırada bekleyen bir müşteriyi çağırır ve sıradan çıkarır.
SiraDurumunuYazdir(): Sıradaki müşterilerin listesini konsola yazdırır.
Program sınıfı: Uygulamanın başlangıç noktasıdır. Bir TatliciSırası örneği oluşturur ve müşterilerin sıraya girişini ve çıkışını simüle eder.
