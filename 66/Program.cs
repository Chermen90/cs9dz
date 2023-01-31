using static System.Console;
Write("Введите первое число: ");
int firstInput = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int secondInput = int.Parse(ReadLine()!);

WriteLine($"Рекурсия {GetSum(firstInput, secondInput)}");
WriteLine($"Цикл {SumofNum(firstInput, secondInput)}");


//рекурсивный метод
int GetSum(int first, int second)
{
    if(first == second)
    {
        return first;
    }
    else
    {
        return first + GetSum(first+1, second);
    }
}


//метод цикла
int SumofNum(int start, int end)
{
    int sum = 0;
    for(int i = start; i <= end; i++)
    {
        sum+= start;
        start++;
    }
    return sum;
}
