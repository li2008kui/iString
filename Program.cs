using System;

namespace iString
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Chain();
            var b1 = new Block(null);
            var b2 = new Block(null);
            c.AddBlock(b1);
            c.AddBlock(b2);

            foreach (var b in c.Blocks)
            {
                Console.WriteLine(b + "\r\n");
            }

            Console.ReadKey();
        }
    }
}
