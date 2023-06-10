// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] RandomArray (int size) {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++) {
//         array[i] = new Random().Next(100, 999+1);
//     }
//     return array;
// }

// void PrintArray (int[] array) {
//     foreach (int i in array) {
//         System.Console.Write(i + " ");
//     }
//     System.Console.WriteLine();
// }

// int EvenNum (int[] array) {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++) {
//     if (array[i] % 2 == 0) {
//         count++;
//     } }
//     return count;
// }

// System.Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = RandomArray(size);
// PrintArray(myArray);
// System.Console.WriteLine($"The array has amount of even numbers -> {EvenNum(myArray)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++) {
//     array[i] = new Random().Next(10, 100+1);
// }

// void PrintArray (int[] array) {
//     foreach (int i in array) {
//         System.Console.Write(i + " ");
//     }
//     System.Console.WriteLine();
// }

// int SumOddNum (int[] array) {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] % 2 != 0) {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// PrintArray(array);
// System.Console.WriteLine($"The sum of the odd numbers -> {SumOddNum(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[5];
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().NextDouble();
}

void PrintArray (double[] array) {
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

double MaxMinDif (double[] array) {
    double dif = 0;
    double max = 0;
    double min = 1;
    for (int i = 0; i < array.Length; i++) {
        if (max < array [i]) {
            max = array[i];
        }
        if (array[i] < min) {
            min = array[i];
        }
    }
    dif = max - min;
    return dif;
}

PrintArray(array);
System.Console.WriteLine($"The difference between max and min numbers in the array -> {MaxMinDif(array)}");
