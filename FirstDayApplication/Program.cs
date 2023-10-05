using OOP;

Console.WriteLine("İlk dersimizin uygulaması123");
Console.WriteLine(1+2);
Console.WriteLine("1+2");

string ad = "Furkan";
//Console.WriteLine(ad);

int sayi1 = 10;
int sayi2 = 20;

//Console.WriteLine(sayi1);
//Console.WriteLine(sayi2);
//// 1. Yöntem
//Console.WriteLine("1. sayı"+sayi1);
//Console.WriteLine("2. sayı " + sayi2);
// 2. Yöntem String İnterpolation
Console.WriteLine($" 1. Sayı : {sayi1}");
Console.WriteLine($"2. Sayı : {sayi2}");

// Double veri tipi
double sayi3 = 30.5;
Console.WriteLine(sayi3);


// Boolean veri tipi
//bool dogruluk = false;
//Console.WriteLine(dogruluk);

//double number1 = 30;
//double number2 = 20;
//double sum = number1 + number2;
//Console.WriteLine($"{number1} ve {number2} nin toplamı = {sum}");

//double difference = number1 - number2;
//Console.WriteLine($"{number1} ve {number2} nin farkı = {difference}");

//double divide = number1 / number2;
//Console.WriteLine($"{number1} ve {number2} nin bölümü = {divide}");
//double multiply = number1 * number2;
//Console.WriteLine($"{number1} ve {number2} nin çarpımı = {multiply}");

//double num1 = 20.6;
//double num2 = 13.4;

//double mod = num1 % num2;
//Console.WriteLine($"{num1} ile {num2} nin bölümünden kalan : {mod}");

//int num3 = 10;
//int num4 = 20;
//int num5 = 20;
//Console.WriteLine($"{num3}, {num4} ten büyük müdür = {num3>num4}");
//Console.WriteLine($"{num3}, {num4} ten küçük müdür = {num3 < num4}");
//Console.WriteLine($"{num3}, {num4} e eşit midir ?  = {num3 == num4}");
//Console.WriteLine($"{num3}, {num4} e eşit değil midir ?  = {num3 != num4}");
//Console.WriteLine($"{num3}, {num4} ten büyük eşit midir? = {num3 >= num4}");
//Console.WriteLine($"{num3}, {num4} ten küçük eşit midir? = {num3 <= num4}");

//Console.WriteLine("Lütfen adınızı girin :");
//string name = Console.ReadLine();
//Console.WriteLine("Lütfen Soyadınızı girin :");
//string surname = Console.ReadLine();
//Console.WriteLine($"Adınız : {name}, Soyadınız : {surname}");

//Console.WriteLine("1. Sayıyı giriniz. :");
//int topla1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. Sayıyı giriniz.");
//int topla2 = Convert.ToInt32(Console.ReadLine());
//int toplam = topla1 + topla2;
//Console.WriteLine("2 sayının toplamı= "+toplam);



string deger1 = "Örnek yazı";
string deger2 = "Örnek değer açıklaması";

string sonuc = deger1 +" "+deger2;
Console.WriteLine(sonuc);

int deger4 =4;
int deger5 = 5;
int degerlerSonucu = deger4+deger5;
Console.WriteLine("İki sayının toplamı :"+degerlerSonucu);

MatematikselIslemler islemler = new MatematikselIslemler();
islemler.Topla(4,5);









