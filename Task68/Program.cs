Console.WriteLine("Данная программа вычисляет функцию Аккермана с помощью рекурсии. Числовые значения M и N для вычисления данной функции задаются пользователем.");

int InputNumber(string input)
{
Console.Write(input);

int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
    return n + 1;
    }
    else if (n == 0 && m > 0)
    {
    return Akkerman(m - 1, 1);
    }
    else
    {
    return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int m = InputNumber("Введите числовое значение - M: ");
int n = InputNumber("Введите числовое значение - N: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"Вычисленная функция Аккермана с помощью рекурсии при введённых пользователем числовых значений: M = {m}; N = {n} равняется: {akkermanFunction}.");