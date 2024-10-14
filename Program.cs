
namespace Gazi_HelloWord
{
    internal class Program
    {
        static int sayi4 = 5;//static program açık kaldıkça hafızada saklanır
        static void Main(string[] args)
        {
            byte a = 56, b;//değişkenler aynı satırda değer atanıp aynı türdense yazılabilir.
            const byte number1 = 104;
            b = 40;
            int sayi, sayi1, yaş;
            yaş = 45;

            byte sayi3 = 8;//sayi3 değişkenine değer ataması veri tipi: byte,ismi sayi3
            sayi = 4;
            sayi1 = 5;
            float number3 = 3.15f;
            double number4 = 3.16;
            decimal number5 = 3.17m;//explicit tanımlama (veri tipinin açıkça belirtildiği durum)
            var number6 = 5.25;//implicit değişkeb (veri tipinin açık belirtilmediği durum)
            bool sonuc = false;//8 bitlik doğru veya yanlış (true or false) değerleri saklamak için kullanılır.
            char c = 'a'; //tek karakterli verileri saklamak için kullanılır syntaxı diğerlerinden farklıdır
            string isim = "BERAT";//metinsel değişken
            Console.WriteLine(sayi1 * sayi * sayi3);
            Console.WriteLine("Hello, World!");
            Console.WriteLine(a);
            Console.ReadKey();
            //byte 0-255 arası tam sayıları içerir
            //sbyte -128 +127 arası tam sayıları alır
            //short 16 bitlik işaretli tam sayıları içerir
            //ushort 16 bitlik işaretsiz tam sayıları içerir
            //long 64 bitlik işaretli tam sayıları içerir
            //ulong 64 bitlik işaretsiz tam sayıları içerir
            //byte number2 = 256;overflow hatası verir
            //değişken ismi sayı ile başlayamaz boşluk olmaz _ kullanılabilir
            //byte yas;
            //Console.WriteLine(yas); değeri olmayan değişkenler hiçbir işlemde kullanılamaz
            //int 32 bitlik işaretli tam sayıları içerir

            //namespace;İçinde classları bulunduran yapılarır
            //{}scope(blok):
            //Class:İçinde metodları bulunduran yapıldardır(bu tanım ilerleyen konularda detaylandırılıcaktır)
            //metod:iş yapan kod bloklarına metod denir
            //main metodu:console uygulamalarının giriş noktasıdır. Her console uygulaması main metodu ile baslar
            //ctrl+f5:hata ayıklama modu olmadan programı çalıştırır
            //syntax:programlama dilleri yazım kuralları
            //c#:.syntax;
            //1. Açılan parantezler mutlaka kapatılmalıdır.
            //2. Scope tanımlamalarının sonunda noktalı virgül bulunmaz 
            //3. satırların sonunda noktalı virgül bulunur
            //syntax hatası olursa program değerlnmez dolayısıyla çalışma vs hata olan yerin altını kırmzı çizgi ile işaretler.Bununla birlikte scroolbar da kırmızı bir işaret ile hatanın yerini bildirir
            //vs penceresinin alt kısmındada kırmızı bir çarpı işareti yanında da kaç hata mesajı olduğu yazılır
            //intelliSense:Kod yazarken yardımcı olan açılan pencere
            //IntelliCode: yapay zeka destekli kod yazım yardımcısı
            //ctrl+k+d: bozulan hiyerarşiyi düzeltir
            //C#------>DERLEME----->MS-IL----->DERLEME(.NET Runtime)---->0-1(Binary)
            //MS-IL:Microsoft intermidate language
            //Stack bölgesinde değer tipleri (value types) saklanır stack 
            //1 bit = 0 veya 1
            //8bit = 1 byte
            //1 kilo byte = 1024 byte
            //1 mega byte = 1024kb
            //1 giga byte = 1024mb
            //1 tera byte= 1024gb




        }
    }
}
