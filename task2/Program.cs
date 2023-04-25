/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] CreatArray(int length, int max, int min)
{
   int[] array = new int[length];
   Random rand = new Random();

   for (int i = 0; i < array.Length; i++)
   {
       array[i] = rand.Next(min, max + 1);
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
   Console.Write($"Enter {arg}");
   return int.Parse(Console.ReadLine());
}

void PositivNumberSum(int[] array)
{
   int sum = 0; 
   for (int i = 0; i < array.Length; i++)
   {
       if (i % 2 != 0)
       {
           sum += array[i];
       }
   }
   Console.WriteLine($"The sum of the elements in odd positions: {sum}");
}

int Length = Number("the length of the array: "); 
int max = Number("Enter the minimum number: "); 
int min = Number("Enter the maximum number: "); 
int[] numbers = CreatArray(Length, min, max);
PrintArray(numbers);

PositivNumberSum(numbers);