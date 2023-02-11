//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

// Console.Clear();      // ЭТО БЫЛО НЕВЕРНОЕ РЕШЕНИЕ
// int[] arr = new Random().Next(-9, 9);

// void PrintArray(int[] array){
//     int count = array.Length;
//     for(int i = 0; i < count; i++){
//         Console.Write($"{array[i]}");
//     }
// }
// PrintArray(arr);

// ВЕРНОЕ ВАРИАНТ 1
// Console.Clear();

// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
// int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     result[i] = new Random().Next(minValue,maxValue+1);
//     return result;
// }
// int [] A = GetRandomArray(12, -9, 10);
// Console.WriteLine($"[{String.Join(", ", A)}]");
// int neg=0, pos=0;
// for (int i=0; i<12; i++) {
// if (A[i]<0)
// neg+=1;
// else if (A[i]>0)
// pos+=1;
// }
// Console.WriteLine($"+: {pos}");
// Console.WriteLine($"-: {neg}");

//ВАРИАНТ 2 ПРЕПОДААТЕЛЬСКИЙ

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach(int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el > 0 ? el : 0;
}
Console.WriteLine($"Positive sum = {positiveSum} ,negative sum = {negativeSum}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
return result;
}