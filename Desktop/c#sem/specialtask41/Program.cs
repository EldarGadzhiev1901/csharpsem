int count = 0;
int n;
string stop = "stop";
Console.WriteLine("введите число"); 

    while (true) 
    { 
  
    var data = Console.ReadLine();
    if (String.Equals(data, stop)) 
    {
      break;
    }
     

    
  
    
    if (int.TryParse(data, out n))
    {
      count++;
    }
    else Console.WriteLine("Неправильное стоп-слово");
    } 
  Console.WriteLine($"Количество чисел, больше нуля = {count}");