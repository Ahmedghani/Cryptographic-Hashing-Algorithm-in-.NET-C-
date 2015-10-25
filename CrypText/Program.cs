using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

//SHA-512 sAMPLE
namespace CrypText
{
    class Program
    {
        static void Main(string[] args)
        {
            const string message = "the quick brown fox jumps over the lazy dogs sdfffffffgf fgfd fd g dfg fg dsgdsg dfg sdg sdg dfg sdfg grwtwer wr tthjgj ";
            const string message2 = "The quick brow for jumps over the lazy dogs";

            Console.WriteLine("original message1:" + message);
            Console.WriteLine("original message2:" + message);
            Console.WriteLine();

            var md5hashedMessage = ComputeHashCode(Encoding.UTF8.GetBytes(message));
            var md5hashedMessage2 = ComputeHashCode(Encoding.UTF8.GetBytes(message2));

            Console.WriteLine();
            Console.WriteLine("sha-512 Hash");
            Console.WriteLine();
            Console.WriteLine("Hashed Message1:" + Convert.ToBase64String(md5hashedMessage));
            Console.WriteLine("Hashed Message1:" + Convert.ToBase64String(md5hashedMessage));
            Console.ReadLine();
        }

        private static byte[] ComputeHashCode(byte[] p)
        {
             using(var md5=SHA512.Create())
             {
                 return md5.ComputeHash(p);
             }
        }
    }
}
