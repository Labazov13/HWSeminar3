Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= num; i++)
{
int result =i*i*i;
System.Console.Write("\t"+result);
}
