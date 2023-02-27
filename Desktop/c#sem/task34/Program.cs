    // Задача 34: Задайте массив заполненный случайными 
    // положительными трёхзначными числами. Напишите программу, 
    // которая покажет количество чётных чисел в массиве.

    // [345, 897, 568, 234] -> 2


    int[] GetRandomArray(int lenght, int leftRange, int rightRange)
    {
        lenght = 12;
        leftRange = 100;
        rightRange = 999;

        int[] array = new int[lenght];

        for(int i = 0; i<array.Length; i++)

        {
            array[i] = Random.Shared.Next(leftRange, rightRange + 1);
            

        }
    return array;
    }
    int  CountofNumbers(int [] array)
    {
    int count = 0; 
    
        for(int i = 0; i<array.Length; i++)
        {
            if(array[i] % 2 == 0)
            {
                count = count + 1;

            }
            else 
            {
                count = count + 0;
            }
            
            
        
        }
        return (count);
    }

    int[] myArray = GetRandomArray(12,100,999);
    // Console.WriteLine($"{string.Join(',', myArray)};
    // int cnt = CountofNumbers(myArray);
    // // Console.WriteLine(myArray);
    // Console.WriteLine(cnt);
   Console.WriteLine($"[{string.Join(", ", myArray)}] -> {CountofNumbers(myArray)}");