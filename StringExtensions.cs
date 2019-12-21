using System;
using System.Text.RegularExpressions;

namespace iString
{
    public static class StringExtensions
    {
        /// <summary>
        /// 十六进制字符串转字节数组。
        /// </summary>
        /// <param name="hexString">十六进制字符串。</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string hexString)
        {
            if (string.IsNullOrEmpty(hexString) || !Regex.IsMatch(hexString, "^[0-9a-fA-F]{64}$"))
                return new byte[0];

            hexString = hexString.Replace(" ", "");

            if ((hexString.Length % 2) != 0)
                hexString += " ";

            byte[] returnBytes = new byte[hexString.Length / 2];

            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);

            return returnBytes;
        }
    }
}
