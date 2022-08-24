void ThirdNumver()
{
int N = Convert.ToInt32(Console.ReadLine());

    if (N < 100)
    {
        Console.WriteLine("Третьей цифры нет ");
    }
    else
    {    
        while (N >= 1000)
        {
                N = N / 10;
            
        }
        Console.WriteLine(N % 10);
    }
}
Console.WriteLine("Введите число: ");
ThirdNumver();