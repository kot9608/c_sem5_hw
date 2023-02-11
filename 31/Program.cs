﻿// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 

// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


Console.Clear(); //чистим окно консоли
int[] array = GetRandomArray(12, -9, 9); //вызываем метод GetRandomArray, создавая массив array, длинной 12 цифр, минимальное значение =-9, максимальное =9
Console.WriteLine(String.Join(" ", array)); //выводим массив array на экран, перед этим преобразуя его в строку и вставляя между элементами пробел

int positiveSum = 0; //объявили переменную для суммы положительных чисел
int negativeSum = 0; //объявили переменную для суммы отрицательных чисел

foreach (int el in array)//цикл, который пробегает по массиву, не может менять значения элементов в массиве
{
    positiveSum += el > 0 ? el : 0;//если элемент массива(el) > 0, тогда к positivSum прибавь этот el, иначе - прибавь 0
    negativeSum += el < 0 ? el : 0;//если элемент массива(el) < 0, тогда к positivSum прибавь этот el, иначе - прибавь 0
}

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} "); //вывод на экран positiveSum, negativeSum

int[] GetRandomArray(int size, int minValue, int maxValue)//метод для создания массива из рандомных чисел. На вход приниамет 3 значения(размер массива, минимальное значение элемента, максимальное значение элемента)
{
    int[] result = new int[size];//создание массива result длинной size(которую получили на входе)
    for (int i = 0; i < size; i++)//цикл для заполнения элементов массива рандомными значениями
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //элемент массива начиная с нуля присваивается рандомное значение от минимального до максимального. Т.к. максимальное не включено изначально, указано максимальное+1
    }
    return result;//возврат массива result из функции
}

// Console.Write("Введите длинну массива: ");
// int s = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное число для массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное число для массива: ");
// int max = int.Parse(Console.ReadLine());
// int[] array = GetArray(s, min, max);
// Console.Write($"[{String.Join(", ", array)}]");
// int[] GetArray(int size, int MIN, int MAX){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(min, max+1);
//     }
//     return result;
// }
// Console.Write($"[{SumPolOtr(array)}]");
// int[] SumPolOtr(int [] arr){
//     int ResPol = 0;
//     int ResOtr = 0;
//     for (int i = 0; i < Length(arr); i++){
//         if (arr[i]>=0) {ResPol=ResPol+(arr[i]);}
//         else {ResOtr=ResOtr+(arr[i]);}
//     }
//     return ResPol, ResOtr;
// }




// //////
// //  for (int i = 0;i < array.Length; i++){
// //     int el = array[i];
//     // if(el > 0)
//     //     positiveSum += el;
//     // if(el < 0)
//     //     negativeSum += el;
// // } 
// Console.Clear();
// Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

// Double[] GetArray(int size, Double minValue, Double maxValue)
// {
//     Double[] res = new Double[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().NextDouble(minValue, maxValue);
//     }
//     return res;
// }


/////

//  for (int i = 0;i < array.Length; i++){
//     int el = array[i];
    // if(el > 0)
    //     positiveSum += el;
    // if(el < 0)
    //     negativeSum += el;
// } 