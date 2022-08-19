//int number1 = 1;
//int number2 = 2;

//var result = Add(ref number1, number2);   * Hangi değişken referans alacaksa başına "out" yazıyoruz.
//Console.WriteLine(result);
//Console.ReadLine();

//static int Add(ref int number1, int number2)  * Burada da aynı şekilde belirtiyoruz.
//{
//    number1 = 3;  * Son olarak referans değerimizi tanımlıyoruz.
//    return number1 + number2;
//}

int number1 ;  // * Değer belirtmiyoruz.
int number2 = 2;

var result = Add(out number1, number2); // * Hangi değişken referans alacaksa başına "out" yazıyoruz.
Console.WriteLine(result);
Console.ReadLine();

static int Add(out int number1, int number2) // * Burada da aynı şekilde belirtiyoruz.
{
    number1 = 3; // * Değişkene referans olacak değeri metot kısmında tanımlıyoruz.
    return number1 + number2;
}