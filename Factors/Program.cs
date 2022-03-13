namespace Factors
{
    class Factors
    {

        static void Main(string[]args)
        {
            int Count = 0; 
            Console.WriteLine("Enter a Number:");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Num/2;  i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine("Factors :" +i);
                    Count++;
                }
                


            }
            Console.WriteLine("Number Of Factors:" +Count);
        }

    }

}
