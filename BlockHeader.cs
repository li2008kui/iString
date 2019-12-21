using System;
using System.Collections.Generic;
using System.Text;

namespace iString
{
    /// <summary>
    /// 区块头。
    /// </summary>
    public class BlockHeader
    {
        /// <summary>
        /// 区块版本号。
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// 前置区块的区块头哈希。
        /// </summary>
        public string PreviousBlockHash { get; set; }

        /// <summary>
        /// 区块中交易的默克尔树根哈希。
        /// </summary>
        public string MerkleRoot { get; set; }

        /// <summary>
        /// 区块创建 UNIX 时间戳。
        /// </summary>
        public uint Timestamp { get; set; } = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        /// <summary>
        /// 工作量证明算法难度。
        /// </summary>
        public uint DifficultyTarget { get; set; } = 5;

        /// <summary>
        /// 随机数，通过变动该计数器来达成工作量证明要求的结果。
        /// </summary>
        public uint Nonce { get; set; }

        /// <summary>
        /// 获取区块头的哈希。
        /// </summary>
        /// <returns></returns>
        public string GetBlockHeaderHash()
        {
            var byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(Version));
            byteList.AddRange(PreviousBlockHash.ToByteArray());
            byteList.AddRange(MerkleRoot.ToByteArray());
            byteList.AddRange(BitConverter.GetBytes(Timestamp));
            byteList.AddRange(BitConverter.GetBytes(DifficultyTarget));
            byteList.AddRange(BitConverter.GetBytes(Nonce));
            return byteList.ToArray().Sha256();
        }
    }
}
