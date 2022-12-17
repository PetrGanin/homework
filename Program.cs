// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите номер задачи от 1 до 4: ");
int namber = Convert.ToInt32(Console.ReadLine());
switch (namber)
{
    case 1:
        Console.WriteLine("Ввод 2 числа и выдает max i min: ");
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("Это число большее: " + a);
            Console.WriteLine("это число меньшее: " + b);
        }
        else
        {
            Console.WriteLine("Это число большее: " + b);
            Console.WriteLine("это число меньшее: " + a);
        }
        break;

    case 2:
        break;

    case 3:
        break;

    case 4:
        break;

    default:
        break;
}
