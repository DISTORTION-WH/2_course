using System.Security.Cryptography;
using System.Text;

namespace Lab5Lib
{
    public class DecSHA512 : Decorator 
    {
        public DecSHA512(IWriter writer) : base(writer) { }

        public override string? Save(string? message) 
        {
            using (var sha512 = SHA512.Create()) 
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(message ?? string.Empty);
                byte[] hashedData = sha512.ComputeHash(dataBytes);

                string hashedMessage = Convert.ToBase64String(hashedData);

                var decoratedMessage = $"{message}{Constant.Delimiter}{hashedMessage}";

                return _writer?.Save(decoratedMessage);
            }
        }
    }
}
