// **Задача 33:** Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


// Написание кода с помощью массива
Console.Clear();
int max(int arg1, int arg2, int arg3)
{
  int result=arg1;
  if (arg2>result)result=arg2;
  if(arg3>result)result=arg3;
  return result;
}//          0  1 2  3 4  5  6 7 8 
int[]array={11,12,3,41,5,61,7,18,19};
// array[0]=12;
// Console.WriteLine(array[0]);

int Max = max(
  max(array[0],array[1],array[2]),
  max(array[3],array[4],array[5]),
  max(array[6],array[7],array[8]));
Console.WriteLine(Max);


//////


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

int[] Array = GetRandomArray(5, -9, 9);

Console.WriteLine($"Введи чисор для поиска: ");
int X = int.Parse(Console.ReadLine());

int Poisk (int [] vhodMassiv, int x)
{
 for (int i=0; i<vhodMassiv.Length; i++){
if (x==vhodMassiv[i])
return

}





int[] ObratMassiv(int[] arwertyuiky)
{


  for (int i=0; i<arwertyuiky.Length; i++){
    arwertyuiky[i]=(arwertyuiky[i]*(-1));
  }
  return arwertyuiky;
}


