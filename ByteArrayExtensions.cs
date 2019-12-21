namespace iString
{
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// 字节数组转十六进制字符串。
        /// </summary>
        /// <param name="bytes">字节数组。</param>
        /// <returns></returns>
        public static string ToHexString(this byte[] bytes)
        {
            string returnStr = "";

            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("x2");
                }
            }

            return returnStr;
        }
    }
}
