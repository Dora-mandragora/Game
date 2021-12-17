using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Game
{
    internal class Hash
    {
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        public readonly string HexHash;
        readonly byte[] secretKey = new byte[64];

        //msg - это ответ компа
        //key - случайно сгенерированный ключ
        public Hash(string msg)
        {
            rng.GetBytes(secretKey);
            HexHash = GetHMAC(msg);
            //Console.WriteLine(HexHash);
        }

        public string GetHMAC(string message)
        {
            byte[] bmessage = Encoding.UTF8.GetBytes(message);         
            HMACSHA256 hmac = new HMACSHA256(secretKey);
            hmac.ComputeHash(bmessage);
            hmac.Initialize();
            return string.Concat(Array.ConvertAll(hmac.Hash, b => b.ToString("x"))).ToLower();
        }

        public string GetKey() => string.Concat(Array.ConvertAll(secretKey, b => b.ToString("x"))).ToLower();
        

    }
}
