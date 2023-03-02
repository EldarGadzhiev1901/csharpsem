int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int[] GetRandomArray(int length, int leftRange, int rightRange)
{
  

     int[] array = new int[length];

    for(int i = 0; i<array.Length; i++)

    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        

    }
   return array;
}

void ReverseArray(int[] array)

{
    for (int i=0; i< array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
// const double PI = 3.14;
const int lenght = 12;
const int leftRange = - 10;
const int rightRange = 10;
int [] myArray = GetRandomArray(lenght, leftRange, rightRange);
Console.WriteLine(string.Join(",", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(",", myArray));

