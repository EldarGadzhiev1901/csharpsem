int number = 9999;


void Binary(int n)
{
   if (n==0) return;
   Binary(n/2);
   Console.Write(n%2); 

}
Binary(number);