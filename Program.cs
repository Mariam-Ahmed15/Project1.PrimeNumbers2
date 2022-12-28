 // See https://aka.ms/new-console-template for more information
 Console.WriteLine("This prgrame finds prime numbers withen a given range. ");
 Console.WriteLine(("Please,Give me a range from num1 to num2."));
 Console.WriteLine("num1 = ");
 uint num1 = uint.Parse(Console.ReadLine());
 Console.WriteLine("num2 = ");
 uint num2 = uint.Parse(Console.ReadLine());
Console.WriteLine("Prime numbers between "+ num1 + " and" + num2 + " are:");
uint startPoint = Math.Min(num1, num2);
uint endPoint = Math.Max(num1, num2);
uint y = endPoint / 6;
uint l = startPoint / 6;
bool isPrime = true;
uint[] previous_primes = new uint[100];
uint pointer = 1;
  if (startPoint <= 2 && endPoint >= 2)
      {
             Console.WriteLine(2);

      }
  if (startPoint <= 3 && endPoint >= 3)
      {
          Console.WriteLine(3);
      }
  if (startPoint <= 5 && endPoint >= 5)
      {
           Console.WriteLine(5);
      }


    previous_primes[0] = 5;
  for (uint i = l; l <= i && i <= y; i++)
     {

      uint x = i * 6;
      uint k = x - 1;



  if ((k % 5 != 0 || k == 5) && (k <= endPoint && k >= startPoint))
     {


  for (int p = 0; p <= pointer - 1; p++)
     {
  if (k % previous_primes[p] == 0)
     {
       isPrime = false;
       break;
     }

      }
  if (isPrime == true)
                    {
    Console.WriteLine( k);
    previous_primes[pointer] = k;

     pointer++;
     }

     }

     isPrime = true;
     k = x + 1;
     double sqrt = Math.Sqrt(k);

  if (k % 5 != 0 && (k <= endPoint && k >= startPoint) && k != 1 && (sqrt != (int)sqrt))
     {

  for (int p = 0; p <= pointer - 1; p++)
                    {
  if (k % previous_primes[p] == 0)
      {
      isPrime = false;
      break;
      }

      }
  if (isPrime == true)
      {
         Console.WriteLine( k);
         previous_primes[pointer] = k;
         pointer++;
      }



       }
    isPrime = true;

      }







        

    
