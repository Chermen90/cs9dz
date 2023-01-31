using static System.Console;
Write("Введите число: ");
int input = int.Parse(ReadLine()!);
string result = GetNums(input);
WriteLine($"{result} ");

string GetNums(int n)
{
    if(n <= 1)
    {

        return n.ToString();
    }
    else
    {
        return $"{n}, {GetNums(n-1)}";
    }
}
