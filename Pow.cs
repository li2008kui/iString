using System;

namespace iString
{
    public class Pow
    {
        public static Block Mining(string previousBlockHash)
        {
            var b = new Block(null)
            {
                PreviousBlockHash = previousBlockHash
            };

            var r = new Random();
            var s = string.Empty;

            for (int i = 0; i < b.DifficultyTarget; i++)
            {
                s += '0';
            }

            while (true)
            {
                b.Nonce = (uint)r.Next(0, int.MaxValue);

                if (b.GetBlockHeaderHash().StartsWith(s, StringComparison.Ordinal))
                {
                    return b;
                }
            }
        }
    }
}
