using System.Security.Cryptography;
using System.Text;

namespace iString
{
    /// <summary>
    /// Extension methods for hashing strings
    /// </summary>
    public static class HashExtensions
    {
        /// <summary>
        /// Creates a SHA256 hash of the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A hash</returns>
        public static string Sha256(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha.ComputeHash(bytes);
            return hash.ToHexString();
        }

        /// <summary>
        /// Creates a SHA256 hash of the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A hash.</returns>
        public static string Sha256(this byte[] input)
        {
            if (input == null)
                return null;

            using var sha = SHA256.Create();
            var hash = sha.ComputeHash(input);
            return hash.ToHexString();
        }
    }
}
