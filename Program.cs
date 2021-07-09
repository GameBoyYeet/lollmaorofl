using System;

namespace lollmaorofl
{
    class Program
    {
    static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int num = rnd.Next(1, 4);
                if (num == 1)
                {
                    Console.WriteLine("lmao");
                }
                else if (num == 2)
                {
                    Console.WriteLine("rofl");
                }
                else if (num == 3)
                {
                    Console.WriteLine("lol");
                }
                System.Threading.Thread.Sleep(50);
            }
        }

        
    }
}
