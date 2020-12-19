using System.Security.Cryptography;
using System.Text;

namespace Tinkoff_Бюджет
{
    class HashingPsw
    {
        public static string HashPassword(string password)
        {
            // step 1, calculate sha512 hash from input
            SHA512 sha512 = System.Security.Cryptography.SHA512.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = sha512.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
