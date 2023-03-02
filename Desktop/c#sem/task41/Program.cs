  Console.WriteLine("Введите длинну массива");
  int m = Convert.ToInt32(Console.ReadLine());
 
  int count = 0;
  int i = 0;
 int[] array = new int[m];
  

    while (i<array.Length)
    {
       Console.WriteLine("введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
    i++;
    if (n>0)
    {
      count++;
    }
    }
  Console.WriteLine(string.Join(" ", array));
  
  Console.WriteLine($"Количество чисел, больше нуля = {count}");
   


// int answer = CountOfNumbers();
// Console.WriteLine(answer);
// int number = ReadNumber("Введите число");
// int[] myArray = CountOfNumbers(number);
// Console.WriteLine(string.Join(" ", myArray));
// ReverseArray(myArray);
// Console.WriteLine(string.Join(" ", myArray));