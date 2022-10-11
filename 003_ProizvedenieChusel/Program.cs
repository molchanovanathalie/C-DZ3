// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int M = N;
int comp = 1;
while(N > 0)
{
    comp = comp * N;
    N = N - 1;
}
Console.WriteLine($"Произведение чисел от 1 до {M}: " +comp);