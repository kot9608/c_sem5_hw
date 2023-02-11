﻿// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();//очистили консоль

int[] array = GetRandomArray(4, 100, 999); //вызвали создание массива, передав (длинна массива, минимальное значение элемента, максимальное значение элемента)
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

int sumChet = 0; //объявили переменную для суммы положительных чисел


foreach (int el in array)//цикл, который пробегает по массиву, не может менять значения элементов в массиве
{
    sumChet += (el%2==0) ? 1 : 0;//если элемент массива(el) > 0, тогда к positivSum прибавь этот el, иначе - прибавь 0
}

Console.WriteLine(sumChet); //вывели на экран первый массив, до преобразования