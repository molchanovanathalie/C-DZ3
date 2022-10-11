// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int a = 1;
while(a<=N)
{
    if (a % 2 == 0)
    {
    int b = a*a*a;
    Console.WriteLine($"a = {a}, куб числа a = {b}");
    }
    a++;
}