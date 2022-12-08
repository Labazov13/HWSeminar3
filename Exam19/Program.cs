System.Console.WriteLine("Введите 5-тизначное число");  //12321
int number = int.Parse(Console.ReadLine()!);

if (number < 10000)
{
    System.Console.WriteLine(number + " Не является 5-тизначным числом");
}
else
{
    if (number / 10000 == number % 10)
    {
        if (number / 1000 % 10 == number % 100 / 10)
        {
            System.Console.WriteLine("Это палиндром!");
        }
    }
    else
    {
        System.Console.WriteLine("Это не палиндром.");
    }
}
