// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

    int[] GetRandomArray(int lenght, int leftRange, int rightRange)
    {



        int[] array = new int[lenght];

        for(int i = 0; i<array.Length; i++)

        {
            array[i] = Random.Shared.Next(leftRange, rightRange + 1);
            

        }
    return array;
    }
    int  SumofNumbers(int [] array)
    {
    int sum = 0; 
    
        for(int i = 0; i<array.Length; i++)
        {
            if(i % 2 == 0)
            {
                sum = sum + array[i];

            }
            else 
            {
                sum = sum + 0;
            }
            
            
        
        }
        return (sum);
    }
    
    Console.WriteLine("Введите длинну массива");
    int lenght = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите левый конец массива");
    int leftRange = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите правый конец массива");
    int rightRange = Convert.ToInt32(Console.ReadLine());


    int[] myArray = GetRandomArray(lenght, leftRange, rightRange);
Console.WriteLine($"{string.Join(',', myArray)} -> {string.Join(',', SumofNumbers(myArray))}");