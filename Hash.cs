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
        readonly byte[] secretKey = new byte[32];
        
        readonly string Message;
        public readonly string HexHash;

        public Hash(string msg)
        {
            rng.GetBytes(secretKey);
            Message = msg;
            HexHash = GetHMAC();
        }

        public string GetHMAC()
        {
            byte[] bMessage = Encoding.UTF8.GetBytes(Message);         
            HMACSHA256 hmac = new HMACSHA256(secretKey);
            hmac.ComputeHash(bMessage);            
            return string.Concat(Array.ConvertAll(hmac.Hash, b => b.ToString("x")));
        }

        public string GetKey() => string.Concat(Array.ConvertAll(secretKey, b => b.ToString("x")));
        

    }
}
