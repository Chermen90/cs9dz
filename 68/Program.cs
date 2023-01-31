using static System.Console;
Write("Введите первое число: ");
int firstInput = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int secondInput = int.Parse(ReadLine()!);

WriteLine(Ackermann(firstInput, secondInput));



int Ackermann(int firstNum, int secondNum)
{
    int result = 0;
    if(firstNum == 0)
    {
        result = secondNum + 1;
    }
    else if(secondNum == 0)
    {
        result = Ackermann(firstNum - 1, 1);
    }
    else
    {
        result = Ackermann(firstNum - 1, Ackermann(firstNum, secondNum - 1));
    }
    return result;
}