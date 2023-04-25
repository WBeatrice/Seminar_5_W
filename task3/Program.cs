/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] CreatArray(int length, int max, int min)
{
   double[] array = new double[length];
   Random rand = new Random();

   for (int i = 0; i < array.Length; i++)
   {
       array[i] = rand.Next(min, max + 1);
   }
   return array;
}

void PrintArray(double[] array)
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

void TheDifferenceBetweenMinIMax (double[] array)
{
   double max = array[0];
   double min = array[0];
   double difference = 0;
   for (int i = 1; i < array.Length; i++)
   {
       if (min > array[i])
       {
           min = array[i];
       }
       else if (max < array[i])
       {
           max = array[i];
       }
   }
   difference = max - min;

   Console.WriteLine($"The difference between the maximum and minimum array elements: {difference}"); 
}

int Length = Number("the length of the array: "); 
int min = Number("Enter the minimum number: "); 
int max = Number("Enter the maximum number: ");
double[] numbers = CreatArray(Length, max, min);
PrintArray(numbers);

TheDifferenceBetweenMinIMax(numbers);