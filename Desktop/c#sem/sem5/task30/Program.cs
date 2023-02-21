//Задача 30: Напишите программу, которая выводит массив из 8
//элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// bool [] array = new bool [number];
// Random.Shared.Next(10, 100);
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}
int number = ReadNumber("Введите длинну массива");
int[] array = new int[number];
for (int i=0; i<array.Length - 1; i++)
{
    array[i] = Random.Shared.Next(0, 2);
    Console.WriteLine(array[i]);


}


