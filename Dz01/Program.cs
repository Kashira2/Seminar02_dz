void SecondNumber()
{
int N = Convert.ToInt32(Console.ReadLine());
int result = N / 10;
Console.WriteLine(result % 10);
}
Console.WriteLine("Введите трехзначное число: ");
SecondNumber();