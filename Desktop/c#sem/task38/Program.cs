// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

    double[] GetRandomArray(int lenght, int leftRange, int rightRange)
    {



        double[] array = new double[lenght];

        for(int i = 0; i<array.Length; i++)

        {
            array[i] = Random.Shared.Next(leftRange, rightRange + 1);
            

        }
    return array;
    }
    double  MinandMax(double [] array)
    {
    double min = array[0]; 
    double max = array[0];
    double sum = 0;
    
        for(int i = 0; i<array.Length; i++)
        {
            if(array[i]<min)
            {
                min = array[i];

            }
            
           if(array[i]>max)
           {
            max = array[i];
           }
            
            
        
        }
       
        sum = max - min;
        return (sum);

    }
    
    Console.WriteLine("Введите длинну массива");
    int lenght = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите левый конец массива");
    int leftRange = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите правый конец массива");
    int rightRange = Convert.ToInt32(Console.ReadLine());


    double[] myArray = GetRandomArray(lenght, leftRange, rightRange);
Console.WriteLine($"{string.Join(',', myArray)} -> {string.Join(',', MinandMax(myArray))}");