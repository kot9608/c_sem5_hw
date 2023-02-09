// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 

// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


// Console.Clear();
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

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)//[1, 2, 3, 4, -5, 1, -3] el = -5
{
    positiveSum += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0;
    negativeSum += el < 0 ? el : 0;
}
//  for (int i = 0;i < array.Length; i++){
//     int el = array[i];
    // if(el > 0)
    //     positiveSum += el;
    // if(el < 0)
    //     negativeSum += el;
// } 
Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}