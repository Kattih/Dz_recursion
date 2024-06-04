// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

bool CheckNatural(int num)
{
    if (num <= 0)
    {
        Console.WriteLine("Число не является натуральным");
        return true;
    }
    return false;
}

void OutNatureNumbers(int m, int n)
{
    
    {
            if (m < n)
        {
            if (n == m-1)
            return;
            OutNatureNumbers(m, n-1);
        }
        
        if (m > n)
        {
            if (n == m+1)
            return;
            OutNatureNumbers(m, n+1);
        }
        Console.Write($"{n} ");
    }
}

Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (CheckNatural(num1)) return;

Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (CheckNatural(num2)) return;

OutNatureNumbers(num1, num2);