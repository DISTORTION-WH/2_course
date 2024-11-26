using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        BinaryWriter binaryWriter = new BinaryWriter(File.Open("E:\\Key.bin", FileMode.Create));
        BinaryWriter binaryWriter2 = new BinaryWriter(File.Open("E:\\encr.bin", FileMode.Create));
        BinaryWriter binaryWrite3 = new BinaryWriter(File.Open("E:\\hash.bin", FileMode.Create));

        string message = "Шатерник Глеб Игоревич";
        string secretKey = "test";

        // Генерация ключа для AES
        byte[] aesKey;
        byte[] aesIV;
        using (Aes aes = Aes.Create())
        {
            aesKey = aes.Key;
            aesIV = aes.IV;
        }

        // Шифрование сообщения AES
        byte[] encryptedMessage = EncryptStringAES(message, aesKey, aesIV);
        binaryWriter2.Write(encryptedMessage);
        binaryWriter.Write(aesKey);
        // Хеширование ключа AES и секретного ключа
        string aesKeyHash = GetMD5Hash(Encoding.UTF8.GetString(aesKey));
        string secretKeyHash = GetMD5Hash(secretKey);
        binaryWrite3.Write(aesKeyHash);
        // ЭЦП = хешированный ключ AES + хешированный ключ секретный
        string digitalSignature = $"{aesKeyHash}:{secretKeyHash}";
        binaryWriter2.Write(aesKeyHash);
        binaryWriter2.Write(secretKeyHash);

        Console.WriteLine($"Сообщение: {message}");
        Console.WriteLine($"ЭЦП: {digitalSignature}");
        Console.WriteLine("Проверка ЭЦП:");

        // Расшифровка сообщения AES
        byte[] decryptedMessage = DecryptStringAES(encryptedMessage, aesKey, aesIV);

        // Сравнение хешированных ключей 
        if (GetMD5Hash(secretKey) == secretKeyHash)
        {
            Console.WriteLine("ЭЦП действительна.");
        }
        else
        {
            Console.WriteLine("ЭЦП недействительна.");
        }
        binaryWriter.Close();
        binaryWriter2.Close();
        binaryWrite3.Close();
    }

    static byte[] EncryptStringAES(string plainText, byte[] Key, byte[] IV)
    {
        byte[] encrypted;
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }
        return encrypted;
    }

    static byte[] DecryptStringAES(byte[] cipherText, byte[] Key, byte[] IV)
    {
        byte[] decrypted;
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;


            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        decrypted = Encoding.UTF8.GetBytes(srDecrypt.ReadToEnd());
                    }
                }
            }
        }
        return decrypted;
    }

    static string GetMD5Hash(string input)
    {
        using (MD5 md5Hash = MD5.Create())
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
