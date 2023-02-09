// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = GetRandomArray(6, -9, 9); //вызвали создание массива, создали массив

Console.WriteLine(String.Join(" ", array)); //вывод на экран первый массив

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] ObratMassiv(int[] arwertyuiky)
{


  for (int i=0; i<arwertyuiky.Length; i++){
    arwertyuiky[i]=(arwertyuiky[i]*(-1));
  }
  return arwertyuiky;
}
int[] res = ObratMassiv(array);

Console.WriteLine(String.Join(" ", res));
