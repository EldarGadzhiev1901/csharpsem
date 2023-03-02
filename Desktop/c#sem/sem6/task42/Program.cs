// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;

}

int[] TentoTwo(int n)
{
    int i = 0;
  
   int  n_c = n;
  

    while (n>0)
    {
       n = n/2; 
       i++;
    }
    int[] array = new int[i];
   
    for (int j = 0; j<array.Length; j++)
    {
        array[j] = n_c % 2;
        n_c /= 2;
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
int number = ReadNumber("Введите число");
int[] myArray = TentoTwo(number);
Console.WriteLine(string.Join(" ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(" ", myArray));