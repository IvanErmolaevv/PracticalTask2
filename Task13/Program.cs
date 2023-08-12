//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

using System.Globalization;

int number(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);

    return num;
}

void thirdDigit(int numb)
{
    int index = 1;
    while (numb / index != 0)
    {
        index = index * 10;
    }
    if (index < 1000)
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }
    index = index / 100;
    Console.WriteLine($"Третьей цифрой числа {numb} является {numb % index / (index / 10)}");
}

int num = number("Введите число ");
thirdDigit(num);