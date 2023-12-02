// Задача 1: Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. Программа завершается при вводе
// символа ‘q’ или при вводе числа, сумма цифр которого четная.

// while (true)
// {

//     Console.Write("Введите цифру: ");

//     int number = Convert.ToInt32(Console.ReadLine());
//     string Number = Convert.ToString(number);
//     Console.WriteLine(Number);
//     int[] Array = new int[Number.Length];

//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = Convert.ToInt32(Number[i].ToString());
//     }
//     if (Array.Sum() % 2 == 0)
//     {
//         Console.WriteLine($"Сумма цифр четная");
//         break;
//     }
//     else
//     {    
//     ConsoleKeyInfo cons = Console.ReadKey();
//     while (cons.Key != ConsoleKey.Q)
//     {
//         cons = Console.ReadKey();
//         break;
//     }
//     }
// }



// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int size = 4;
// int[] array = new int[size]; // Массив на 4 элемента
// int number = 0;
// for (int i = 0; i < size; i++) // array.Length = size
// {
//     array[i] = new Random().Next(100, 1000); // 100-999
// }


// if (array[0] % 2 == 0)
// {
//     number++;
// }
// if (array[1] % 2 == 0)
// {
//     number++;
// }
// if (array[2] % 2 == 0)
// {
//     number++;
// }
// if (array[3] % 2 == 0)
// {
//     number++;
// }

// if (number == 0)
// {
//     Console.WriteLine($"Массив: [{string.Join("; ", array)}] не имеет чётных чисел");
// }
// else
// {
//     Console.WriteLine($"Массив: [{string.Join("; ", array)}] => {number}");
// }

// Задача 3: Напишите программу, которая перевернёт одномерный массив
//  (первый элемент станет последним, второй – предпоследним и т.д.)

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < size; i++) // array.Length = size
// {
//     array[i] = new Random().Next(10); // 0-9
// }
//     Console.WriteLine($"Было: [{string.Join("; ",array)}]");

// int n = array.Length; // длина массива
// int k = n / 2;          // середина массива
// int temp;               // вспомогательный элемент для обмена значениями
// for (int i = 0; i < k; i++)
// {
//     temp = array[i];
//     array[i] = array[n - i - 1];
//     array[n - i - 1] = temp;
// }
// foreach (int result in array)
// {
//     Console.Write($"Cтало: [{string.Join("; ",array)}]");
//     break;
// }