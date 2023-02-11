// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21


Console.Clear();//очистили консоль
Console.Write("Введите длинну массива: ");//приглашение для польз вввести длинну массива
int size_array = int.Parse(Console.ReadLine());//Записали длинну массива в переменную size_array
int[] array = GetRandomArray(size_array, 0, 10); //вызвали создание массива, передав (длинна массива, минимальное значение элемента, максимальное значение элемента)
Console.WriteLine(String.Join(" ", array));//вывели на экран первый массив, до преобразования

int[] GetRandomArray(int size, int minValue, int maxValue)//метод по созданию рандомного массива. На вход получает (длинна массива, минимальное значение элемента, максимальное значение элемента)
{
    int[] result = new int[size];//создает массив длинной указанной на входе
    for (int i = 0; i < size; i++)//цикл для заполнения элементов массива случаными значениями
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //каждое значение массива заполняется рандомным числом от мин до макс, т.к. макс не входит по умолчанию указано макс+1
    }

    return result;//возвращаем массив как результат работы метода
}

int[] GetArrayMulty (int[] arr)
{
  int[] ArrayMulty  = new int[((arr.Length/2)+1)];//создает массив в половину длинны исходного масссива
  for (int i = 0; i < ArrayMulty.Length; i++)
  {
    //int j=0;
    //ArrayMulty[i]=1;
    ArrayMulty[i]=array[i]*array[arr.Length-1-i];
    if (array[i]==array[arr.Length-1-i])
    {
      ArrayMulty[i]=array[i];
    }
    //j=j+1;
  }
  return ArrayMulty;
}
int[] res = (GetArrayMulty(array));

//Console.WriteLine(res);

Console.WriteLine(String.Join(" ", res));