//36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[3, 7, -2, 1] -> 8
//[-4, -6, 89, 6] -> 0
using System;
void array(int a){
    int total = 0;
    int[] arr  = new int[a];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(0, 10);
        if (i %2 != 0){
            total = total + arr[i];
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
    Console.WriteLine($"Сумма элементов, стоящий на нечетных позициях: {total}");
}
array(5);