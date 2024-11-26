using System.Security.Cryptography;
using System.Text;

namespace Lab5Lib 
{
    public class DecMD5 : Decorator 
    {
        public DecMD5(IWriter writer) : base(writer) { }

        public override string? Save(string? message) //переопределяем метод сейв для додепа функций
        {
            using (var md5 = MD5.Create()) 
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(message ?? string.Empty);
                byte[] encryptedData = md5.ComputeHash(dataBytes);

                string hashedMessage = Convert.ToBase64String(encryptedData);

                var decoratedMessage = $"{message}{Constant.Delimiter}{hashedMessage}";

                return _writer?.Save(decoratedMessage);
            }
        }
    }
}
