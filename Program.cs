// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Welcome to the third digit finder!");
Console.WriteLine("Please, insert number:");
var input = Console.ReadLine();
var number = default(int);
if (!int.TryParse(input, out number))
{
    Console.WriteLine("Sorry, inserted value is not an integer... Bye!");
    return;
}

for (int i = 0, j = 0; i < input?.Length; i++)
{
    var symbol = input[i];
    if ( symbol != '-' )
    {
        j++;
    }

    if (j == 3)
    {
        Console.WriteLine(input[i]);
        return;
    }
}

Console.WriteLine("Sorry, inserted number has no third digit... Bye!");