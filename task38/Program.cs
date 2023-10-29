//38. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 
//[3 7 22 2 78] -> 76
//[2 0,4 9 7,2 78] -> 77,6
using System;
void array(int a){
    double diff = 0;
    double max = 0;
    double min = double.MaxValue;

    int[] arr  = new int[a];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(0, 10);
        if (arr[i] > max){
            max = arr[i];
        }
        else if (arr[i] < min){
            min = arr[i];
        }
    }
    diff = max - min;
    Console.WriteLine("[{0}]", string.Join(", ", arr));
    Console.WriteLine($"Разница между максимальным и минимальным числом массива: {diff}");
}
array(5);