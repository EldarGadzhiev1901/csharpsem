int number = Random.Shared.Next(100, 1000);

Console.WriteLine($"число {number}");

int firstDigit = number / 100; 
int lastDigit = number % 10;
int answer = firstDigit * 10 + lastDigit;

Console.WriteLine($"результат {answer}");