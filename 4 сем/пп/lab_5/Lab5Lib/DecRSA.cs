using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Lab5Lib 
{
    public class DecRSA : Decorator 
    {
        public DecRSA(IWriter writer) : base(writer) { }

        public override string? Save(string? message) 
        {
            string publicKeyXml;
            byte[] encyptedData;

            message = message ?? string.Empty;

            int k1 = message.IndexOf(Constant.Delimiter);

            if (k1 == -1)
            {
                throw new Exception("delimiter not found");
            }

            string firstStep = message.Substring(0, k1);
            string tempStep = message.Substring(k1 + 1);

            byte[] hashBytes = Convert.FromBase64String(tempStep);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider()) {
                publicKeyXml = rsa.ToXmlString(true);
                rsa.ImportParameters(rsa.ExportParameters(false));

                encyptedData = rsa.Encrypt(hashBytes, false);
            }

            string result = $"{firstStep}{Constant.Delimiter}{Convert.ToBase64String(encyptedData)}{Constant.Delimiter}{publicKeyXml}";

            return _writer?.Save(result);
        }
    }
}
