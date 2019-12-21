using System;

namespace iString
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Chain();
            Console.WriteLine(c.Blocks[0] + "\r\n");

            while (true)
            {
                var p = c.GetLatestBlock().GetBlockHeaderHash();
                var b = Pow.Mining(p);

                c.AddBlock(b);
                Console.WriteLine(b + "\r\n");
            }
        }
    }
}
