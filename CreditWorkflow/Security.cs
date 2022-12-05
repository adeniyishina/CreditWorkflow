using System.Security.Cryptography;
using System.Text;

namespace CreditWorkflow
{
    public class Security
    {
        public static string RequestSignature(string secretKey, string messageRepresentation)
        {
            if (string.IsNullOrWhiteSpace(secretKey) || string.IsNullOrWhiteSpace(messageRepresentation))
                return "";

            string signature;
            var secretBytes = Encoding.UTF8.GetBytes(secretKey);
            var valueBytes = Encoding.UTF8.GetBytes(messageRepresentation);

            using (var hmac = new HMACSHA256(secretBytes))
            {
                var hash = hmac.ComputeHash(valueBytes);
                signature = Convert.ToBase64String(hash);
            }
            return signature;
        }

        public static string CreateContentMd5Hash(byte[] content)
        {
            string result = "";
            if (content != null && content.Length > 0)
            {
                using (var md5 = MD5.Create())
                {
                    byte[] hash = md5.ComputeHash(content);
                    result = Convert.ToBase64String(hash);
                }
            }
            return result;
        }



    }
}
