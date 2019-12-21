using System.Collections.Generic;

namespace iString
{
    public class Chain
    {
        public List<Block> Blocks { get; set; } = new List<Block>();

        public Chain()
        {
            var genesisBlock = Block.GetGenesisBlock();
            Blocks.Add(genesisBlock);
        }

        public void AddBlock(Block block)
        {
            block.PreviousBlockHash = GetLatestBlock().GetBlockHeaderHash();
            Blocks.Add(block);
        }

        public Block GetLatestBlock()
        {
            return Blocks[Blocks.Count - 1];
        }
    }
}
