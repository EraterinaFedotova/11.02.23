// Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5


Console.Clear();
int[] startArray = GetArray(123, -200 , 1230);
Console.WriteLine($"Количество элементов в отрезке [10;99] = {GetCountElements(startArray, 10, 99)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item >= leftRange && item <= rigthRange) count++;
    }
    return count;
}
// Вариант 2  ОБА ОТ ПРЕПОДАВАТЕЛЯ
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int length = number.Length;

// if (length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - Не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }