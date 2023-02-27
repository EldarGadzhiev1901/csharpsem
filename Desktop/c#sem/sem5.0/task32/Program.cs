// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int [] GetRandomArray(int length, int leftRange,int rightRange)
// {
//     int [] array = new int [length];
//     for(int i=0; i<length;i++)
//     {
//         array[i]=Random.Shared.Next(leftRange,rightRange+1);
    
//     }
//     return array;
// }
// int [] GetReverseArray(int [] array)
// {
//     for(int i=0; i<array.Length;i++)
//     {
//         array[i]=array[i]*-1;
//     }
//     return array;
// }
// string CheckNumber(int[] array, int number)
// {   
//     bool found = false;
//     string n;
//     for(int i=0; i<array.Length;i++)
//     {
//         if(number == array[i])
//         {
//             found = true;
           
//         }
  
//     }
//     return array;
//         if(found == true)
//         {
//             n = "yes";
//         }
//         else n = "no";
//         return n;
// }

// int[] myArray = GetRandomArray(4,-9,9);

// int num = ReadNumber("Введите число");
// string answer = CheckNumber(myArray, num);
// Console.WriteLine(answer);

// Console.WriteLine($"[{string.Join( ", " , myArray)}]");
// int [] arr = GetReverseArray(myArray);
// Console.WriteLine($"[{string.Join( ", " , arr)}]");
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int [] GetRandomArray(int length, int leftRange,int rightRange)
{
    int [] array = new int [length];
    for(int i=0; i<length;i++)
    {
        array[i]=Random.Shared.Next(leftRange,rightRange+1);
    
    }
    return array;
}
int [] GetReverseArray(int [] array)
{
    for(int i=0; i<array.Length;i++)
    {
        array[i]=array[i]*-1;
    }
    return array;
}

string NumberInArray(int [] array, int number)
{
    bool isfound = false;
    string ans;
    for(int i=0; i<array.Length;i++)
    {
        if(number == array[i])
        {
            isfound = true;
        }
    }
     if( isfound == true)
        {
            ans = "да";
        }
        else
        {
            ans = "нет";
        }
    return ans;
}

int[] myArray = GetRandomArray(4,-9,9);

int num = ReadNumber("Введите число");
string answer = NumberInArray(myArray, num);
Console.WriteLine(answer);
Console.WriteLine($"[{string.Join( ", " , myArray)}]");