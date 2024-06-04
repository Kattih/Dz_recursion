// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int Accerman(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = Accerman(n, m - 1);
        }
        n = n - 1;
    }
        return m + 1;
}

bool CheckPositive(int num)
{
    if (num < 0)
    {
        Console.WriteLine("Введено отрицательное число");
        return true;
    }
    return false;
}

Console.WriteLine("Введите положительное число n: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (CheckPositive(num1)) return;


Console.WriteLine("Введите положительное число m: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (CheckPositive(num2)) return;

Console.WriteLine($"Результат вычисления функции Аккермана: {Accerman(num1, num2)}");