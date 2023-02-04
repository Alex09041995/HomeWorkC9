Console.WriteLine("Данная программа находит сумму натуральных элементов в промежутке числовых значений от M до N, которые задаются пользователем.");

int InputNumber(string input)
{
Console.WriteLine(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}

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

int m = InputNumber($"Введите числовое значение - M: "); 
int n = InputNumber($"Введите числовое значение - N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"Cумма натуральных элементов в промежутке от {m} до {n} составляет:");
PrintSum(m, n, temp = 0);