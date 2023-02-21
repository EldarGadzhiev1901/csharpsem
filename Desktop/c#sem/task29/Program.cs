// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int number = 8;
int[] array = new int [number];
for (int i=0; i<array.Length; i++)
{
    array[i] = Random.Shared.Next(0, 999);
    Console.WriteLine(array[i]);


}

