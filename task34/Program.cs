//34. Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//[845, 222, 367, 123] -> 1

using System;
void array(int a){
    int total = 0;
    int[] arr  = new int[a];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(0, 1000);
        if (arr[i] % 2 == 0){
            total++;
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
    Console.WriteLine($"Количество четных элементов в массиве: {total}");
}
array(5);