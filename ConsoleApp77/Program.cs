//21 oyunu
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("21 0YUNUNA HOŞGELDİNİZ");
int sayı1, sayı2, sayı3, sayı4, sayı5,toplam1,toplam2;
Random rastgele = new Random();
sayı1 = rastgele.Next(1, 12);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Rakibinizin çekilen ilk kartı = " + sayı1);
Random rastgele1 = new Random();
sayı2 = rastgele1.Next(1, 12);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Çekilen ilk kartınız = " + sayı2);
Random rastgele2 = new Random();
sayı3 = rastgele2.Next(1, 12);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Rakibinizin çekilen ikinci kartı = " + sayı3);
toplam1 = sayı1 + sayı3;
if (toplam1>=21)
{
    Console.WriteLine("tebrikler oyunu kazandınız");

}
Random rastgele3 = new Random();
sayı4 = rastgele3.Next(1, 12);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Çekilen ikinci kartınız = " + sayı4);
toplam2 = sayı2 + sayı4;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Rakibiniz kartlarının toplamı " + toplam1);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Kartlarınızın toplamı = " + toplam2);
Console.ForegroundColor = ConsoleColor.White;
if (toplam2>=21)
{
    Console.WriteLine("Oyunu kaybettiniz");
}
string seçim = "";
Console.WriteLine("Ek kart almak ister misiniz");
seçim = Console.ReadLine();
switch (seçim)
{
    case "Evet":
        Random rastgele4 = new Random();
        sayı5 = rastgele4.Next(1, 12);
        Console.WriteLine("Çektiğiniz kart = " + sayı5);
        toplam2 = toplam2 + sayı5;
        Console.WriteLine("kartlarınızın toplamı = " + toplam2);
        if (toplam2 > toplam1)
        {
            Console.WriteLine("Oyunu kazandınız");
        }
        if (toplam2 < toplam1)
        {
            Console.WriteLine("Oyunu kaybettiniz");
        }
        if (toplam1 == toplam2)
        {
            Console.WriteLine("Oyun berabere bitti");
        }
        break;
    case "evet":
        Random rastgele5 = new Random();
        sayı5 = rastgele5.Next(1, 12);
        Console.WriteLine("Çektiğiniz kart = " + sayı5);
        toplam2 = toplam2 + sayı5;
        Console.WriteLine("Kartlarınızın toplamı = " + toplam2);
        if (toplam2 > toplam1)
        {
            Console.WriteLine("Oyunu kazandınız");
        }
        if (toplam2 < toplam1)
        {
            Console.WriteLine("Oyunu kaybettiniz");
        }
        if (toplam1 == toplam2)
        {
            Console.WriteLine("Oyun berabere bitti");
        }
        break;
    case "hayır":
        if (toplam1 > toplam2)
        {
            Console.WriteLine("Oyunu kaybettiniz");
        }
        else if (toplam2 > toplam1)
        {
            Console.WriteLine("Oyunu kazandınız");
        }
        else
        {
            Console.WriteLine("Oyun berabere bitti");
        }
        break;
    case "Hayır":
        if (toplam1 > toplam2)
        {
            Console.WriteLine("Oyunu kaybettiniz");
        }
        else if (toplam2 > toplam1)
        {
            Console.WriteLine("Oyunu kazandınız");
        }
        else
        {
            Console.WriteLine("Oyun berabere bitti");
        }
        break;
}
Console.ReadLine();



