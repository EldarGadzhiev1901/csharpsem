int[] GetRandomArray(int length, int leftRange, int rightRange)
{
  

     int[] array = new int[length];

    for(int i = 0; i<array.Length; i++)

    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        

    }
   return array;
}
const int length = 12;
const int leftRange = - 10;
const int rightRange = 10;
int[] array1 = GetRandomArray(length, leftRange, rightRange);
Console.WriteLine(string.Join(",",array1));
array1[0] = 100500;
int[] array2 = new int[array1.Length];
// for (int i=0; i<array2.Length; i++)
// {
//     array2=array1;
// }
Array.Copy(array1, array2, array1.Length);
array1[0] = 100500;
Console.WriteLine(string.Join(",",array2));


// int a = 5;