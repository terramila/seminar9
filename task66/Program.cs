/*: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 элементов в промежутке от M до N. Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());


void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}

int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"{m}, {n} ->");
PrintSum(m, n, temp = 0);