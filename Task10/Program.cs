//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int number(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

int secondDigit(int num3)
{
    int secDig = -1;
    if (num3 % 1000 == num3 && num3 % 100 != num3 && num3 % 10 != num3)
    {
        secDig = num3 % 100 / 10;
        
    }
    else
    {
        Console.WriteLine("ERROR! Вы ввели не трёхзначное число!");
    }
    return secDig;
}

int num = number("Введите трёхзначное число ");
int digit = secondDigit(num);
Console.WriteLine($"Вторая цифра числа {num} является {digit}");