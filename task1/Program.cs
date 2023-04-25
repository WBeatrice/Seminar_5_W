/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] CreatArray(int length)
{
   int min = 100;
   int max = 1000;
   int[] array = new int[length];
   Random rand = new Random();

   for (int i = 0; i < array.Length; i++)
   {
       array[i] = rand.Next(min, max);
   }
   return array;
}

void PrintArray(int[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length - 1; i++)
   {
       Console.Write(array[i] + ", ");
   }
   Console.WriteLine(array[array.Length - 1] + "]");
}

int Number(string arg)
{
   Console.Write($"Enter {arg}"); // Введите
   return int.Parse(Console.ReadLine());
}

void PositivNumber (int[] array)
{
   int counter = 0;
   for (int i = 0; i < array.Length; i++)
   {
       if (array[i] % 2 == 0)
       {
           int a = 1;
           counter += a;
       }
   }
   Console.WriteLine($"Even numbers in the array: {counter}");
}

int Length = Number("the length of the array: ");
int[] ints2 = CreatArray(Length);
PrintArray(ints2);

PositivNumber(ints2);