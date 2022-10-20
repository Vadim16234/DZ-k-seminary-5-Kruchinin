// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// РЕШЕНИЕ


// Console.WriteLine("Введите колличество трехзначных чисел: ");
// int num = int.Parse(Console.ReadLine()!);

// int[] array = GetArray(num, 100, 999);
// Console.WriteLine($"[{String.Join(", ", array)}]");



// int[] GetArray(int size, int minValue, int maxValue){
// int[] res = new int [size];
// for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return res;
// }
//  int count = 0;
//  for (int i = 0; i < array.Length; i++){
//     if (array[i] % 2 == 0){
//         count++;
//     }
//  }
//  Console.WriteLine($"Колличество четных чисел = {count}");



// Задача 36
//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//РЕШЕНИЕ


Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!);


int[] array = new int[num];
GetArray(array.Length);
Console.WriteLine($"[{String.Join(", ", array)}] ");


void GetArray (int size){
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(-100,100);
    }
}

int sum = 0;
for (int i = 0; i < array.Length; i++){
    if (i % 2 != 0){
        sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum} ");




// Задача 38
// Задайте массив вещественных чисел (просто от минус бесконечности, 
// до плюс бесконечности, с дробными не работаем). 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



// Console.WriteLine("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine()!);
// int[] array = new int[num];
// GetArray(array.Length);
// Console.WriteLine($"[{String.Join(", ", array)}] ");


// void GetArray (int size){
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(-100,100);
//     }
// }

// int numberMax = array[0];
// int numberMin = array[0];
// int result = 0;
// for (int i = 0; i < array.Length; i++){
//     if (numberMax < array[i]){
//         numberMax = array[i];
        
//         }
//     if (numberMin > array[i]){
//         numberMin = array[i];
//     }    
//     result = numberMax - numberMin;
// }
// Console.WriteLine($"Разница между {numberMax} и {numberMin} = {result}");


