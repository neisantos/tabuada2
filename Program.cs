class Program
    {
        static void Main(string[] args)  {
           for(int i = 1; i <= 10; i++)
           {
               Console.WriteLine($"{i} X 3 = {Multiplicar(i,3)}");
                
               
           }
        
        {
           for(int i = 2; i <= 10; i++)
           {   Console.WriteLine("");
               Console.WriteLine("*****************");
               Console.WriteLine($"{i} X 1 = {Multiplicar(i,1)}");  
               Console.WriteLine($"{i} X 2 = {Multiplicar(i,2)}");               
               Console.WriteLine($"{i} X 3 = {Multiplicar(i,3)}");            
               Console.WriteLine($"{i} X 4 = {Multiplicar(i,4)}");
               Console.WriteLine($"{i} X 5 = {Multiplicar(i,5)}");
               Console.WriteLine($"{i} X 6 = {Multiplicar(i,6)}");
               Console.WriteLine($"{i} X 7 = {Multiplicar(i,7)}");
               Console.WriteLine($"{i} X 8 = {Multiplicar(i,8)}");
               Console.WriteLine($"{i} X 9 = {Multiplicar(i,9)}");
               Console.WriteLine($"{i} X 10 = {Multiplicar(i,10)}");   
              
               
               
           }
        }

        static int Multiplicar(int x, int y)
        {
            return x * y;
        }
        {Console.WriteLine("");}
        }
    }
    