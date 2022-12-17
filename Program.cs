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
        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        // 2, 3, 7 -> 7
        // 44 5 78 -> 78
        // 22 3 9 -> 22

        Console.WriteLine("Ввод 3 чисел и выдает max: ");
        Console.WriteLine("Введите число: ");
        int namberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int namberB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int namberC = Convert.ToInt32(Console.ReadLine());

        while (namberA > namberB)
            if (namberA > namberC)
            {

                Console.WriteLine("Это число большее: " + namberA);
                break;
            }
            else
            {
                Console.WriteLine("Это число большее: " + namberC);

            }
        while (namberA < namberB)
            if (namberB > namberC)
            {
                Console.WriteLine("Это число большее: " + namberC);
                break;
            }
            else
            {
                Console.WriteLine("Это число большее: " + namberC);
                break;
            }

        break;

    case 3:
        // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

        // 4 -> да
        // -3 -> нет
        // 7 -> нет

        Console.WriteLine("Проверка на четность и остаток. ");
        Console.WriteLine("Введите число: ");
        int meaning = Convert.ToInt32(Console.ReadLine());

        if (meaning % 2 == 0)
        {
            Console.WriteLine("это число четное и делится без остатка");
            Console.WriteLine(meaning / 2);
        }
        else
        {
            Console.WriteLine("это число не четное и не делится без остатка.");
        }

        break;

    case 4:
        break;

    default:
        break;
}
