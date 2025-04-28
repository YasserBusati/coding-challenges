using System.Security.Cryptography;
using System.Text;

namespace CodingChallenges.Cryptograghic;

public class AesEncryption
{
    private static readonly string _key = "MySecureKey123";

    private static byte[] GetKeyBytes()
    {
        return SHA256.HashData(Encoding.UTF8.GetBytes(_key));
    }

    public static string Encrypt(string plainText)
    {
        byte[] keyBytes = GetKeyBytes();
        using var aes = Aes.Create();
        aes.Key = keyBytes;
        aes.GenerateIV();

        using var msEncrypt = new MemoryStream();
        msEncrypt.Write(aes.IV, 0, aes.IV.Length);

        using var encryptor = aes.CreateEncryptor();
        using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
        csEncrypt.FlushFinalBlock();

        return Convert.ToBase64String(msEncrypt.ToArray());
    }

    public static string Decrypt(string cipherText)
    {
        byte[] combinedBytes = Convert.FromBase64String(cipherText);
        if (combinedBytes.Length < 16)
            throw new ArgumentException("Invalid cipher text length.");

        byte[] keyBytes = GetKeyBytes();
        using var aes = Aes.Create();
        aes.Key = keyBytes;

        byte[] iv = new byte[16];
        Array.Copy(combinedBytes, iv, iv.Length);
        aes.IV = iv;

        var decryptor = aes.CreateDecryptor();

        using var msDecrypt = new MemoryStream(combinedBytes, iv.Length, combinedBytes.Length - iv.Length);
        using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using var srDecrypt = new StreamReader(csDecrypt);
        string decryptedText = srDecrypt.ReadToEnd();
        return decryptedText;
    }

    public static void Run()
    {
        string plainText = "Hello, World!";
        string encryptedText = Encrypt(plainText);
        Console.WriteLine($"Encrypted Text: {encryptedText}");

        string decryptedText = Decrypt(encryptedText);
        Console.WriteLine($"Decrypted Text: {decryptedText}");
    }
}