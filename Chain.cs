using System.Collections.Generic;

namespace iString
{
    public class Chain
    {
        public List<Block> Blocks { get; set; } = new List<Block>();
        public int BlockHeigh { get; set; }

        public Chain()
        {
            var genesisBlock = Block.GetGenesisBlock();
            Blocks.Add(genesisBlock);

            BlockHeigh = Blocks.Count;
        }

        public void AddBlock(Block block)
        {
            Blocks.Add(block);
        }

        public Block GetLatestBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

        public int GetBlockHeight()
        {
            return Blocks.Count;
        }
    }
}
