namespace iString
{
    /// <summary>
    /// 区块。
    /// </summary>
    public class Block : BlockHeader
    {
        public Block(string merkleRoot)
        {
            MerkleRoot = merkleRoot;
        }

        public static Block GetGenesisBlock()
        {
            return new Block(null);
        }

        public override string ToString()
        {
            return $"       HeaderHash: {GetBlockHeaderHash()}\r\n          Version: {Version}\r\nPreviousBlockHash: {PreviousBlockHash}\r\n       MerkleRoot: {MerkleRoot}\r\n        Timestamp: {Timestamp}\r\n DifficultyTarget: {DifficultyTarget}\r\n            Nonce: {Nonce}";
        }
    }
}
