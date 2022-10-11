// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int a = 1;
while(a >= 1)
{
    a = N % 10;
    N = N/10;
    sum = sum + a;
}
Console.WriteLine("Сумма цифр в числе:" +sum);