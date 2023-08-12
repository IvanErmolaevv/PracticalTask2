//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int number(string message)
{
    Console.Write(message);
    int numb = int.Parse(Console.ReadLine()!);

    return numb;
}

void weekend(int numb1)
{
    if (numb1 < 1 || numb1 > 7)
    {
        Console.WriteLine("Цифра не обозначает день недели");
        return;
    }
    if (numb1 > 5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int num = number("Введите цифру обозначающию день недели ");
weekend(num);