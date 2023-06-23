
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// System.Console.WriteLine("Введите первое число - >");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число - >");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     System.Console.WriteLine($"Наибольшим числом является {num1}");
// }

// else
// {
//     System.Console.WriteLine($"Наибольшим числом является {num2}");
// }

//---------------------------

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// System.Console.WriteLine("Введите первое число - >");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число - >");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число - >");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (max < num2)
// {
//     max = num2;
// }
// if (max < num3)
// {
//     max = num3;
// }

// System.Console.WriteLine($"Наибольшим числом является {max}");

//------------------------

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// System.Console.WriteLine("Введите свое число - >");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num %2 == 1)
// {
//     System.Console.WriteLine($"Ваше число {num} вот вообще ничерта НЕЧЕТНОЕ");
// }
// else
// {
//     System.Console.WriteLine($"{num} является козырным ЧЕТНЫМ числом");
// }

//------------------------

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// System.Console.WriteLine("Введите число N ->");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = 2;

// while (current <= n)
// {
//     System.Console.Write(current + " ");
//     current +=2;
// }