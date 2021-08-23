using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int brrr = int.Parse(Console.ReadLine());
            int stp = int.Parse(Console.ReadLine());
            int rez = Stepenovanje(brrr, stp);
            Console.WriteLine(rez);

        }
               static int Stepenovanje(int broj, int stepen)
        {
            int br = broj;
            for (; stepen > 1; stepen--)
            {
                broj *= br;

            }
            return broj;




           /* int br = broj;
            while(stepen > 1)
            {
                stepen--;
                //broj = broj *br;
                broj *= br;

            }
            return broj;*/

        }
     
      
    }
}
