// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5


Console.Clear();//очистили консоль

int[] array = GetRandomArray(123, 0, 1000); //вызвали создание массива, передав (длинна массива, минимальное значение элемента, максимальное значение элемента)
Console.WriteLine(String.Join(" ", array)); //вывели на экран первый массив, до преобразования


int[] GetRandomArray(int size, int minValue, int maxValue)//метод по созданию рандомного массива. На вход получает (длинна массива, минимальное значение элемента, максимальное значение элемента)
{
    int[] result = new int[size];//создает массив длинной указанной на входе
    for (int i = 0; i < size; i++)//цикл для заполнения элементов массива случаными значениями
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //каждое значение массива заполняется рандомным числом от мин до макс, т.к. макс не входит по умолчанию указано макс+1
    }

    return result;//возвращаем массив как результат работы метода
}

int sum1099 = 0; //объявили переменную для количества элементов от [10 до 99]


foreach (int el in array)//цикл, который пробегает по массиву, не может менять значения элементов в массиве
{
    sum1099 += (el>9 & el<100) ? 1 : 0;//если элемент массива(el) 9<el<100, тогда к sum1099 прибавь 1, иначе - прибавь 0
}

Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] = {sum1099}"); //вывели на экран количество элементов массива в отрезке [10 до 99]