// // Задача 31: Задайте массив из 12 элементов, 
// // заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// // сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }
// int[] GetRandomArray(int lenght, int leftRange, int rightRange)
// {
//      lenght = 12;
//      leftRange = -9;
//      rightRange = 9;

//      int array = new int[lenght];

//     for(int i = 0; i<array.Lenght; i++)

//     {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        

//     }
//    return array;
// }

// (int, int) SumPositiveAndNegativeElements(int[] array)
// {
//     int sumPositive = 0; // sumPositive
//     int sumNegative = 0; // sumNegative
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             sumPositive = sumPositive + array[i];

//         }
//         else if (array[i] < 0)
//         {
//             sumNegative = sumNegative + array[i];
//         }
        
       
//     }
//      return (sumPositive, sumNegative);
// }


// int [] myArray = GetRandomArray();
// Console.WriteLine($"[{string.Join("," , myArray)}]");
// (int sumP, int sumN) = SumPositiveAndNegativeElements(myArray);
// Console.WriteLine($"Сумма положительных элементов = {sumP} ");
// Console.WriteLine($"Сумма отрицательных элементов = {sumN} ");