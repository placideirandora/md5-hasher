using System;
using System.Text;
using System.Security.Cryptography;

namespace md5_hasher
{
    class Program
    {
        static void Main(string[] args)
        {   
            string data;

            Console.WriteLine("Placide IRANDORA Is A Rwandan Software Engineer And Cybersecurity Specialist.\n");
            Console.WriteLine("Type In Some Data To Hash With MD5 Hashing Algorithm:");

            data = Console.ReadLine();

            // Hash and return data by firstly converting it into bytes
            var md5HashedData = ComputeMD5Hash(Encoding.UTF8.GetBytes(data));

            // Display the corresponding hash by firstly converting bytes into string
            Console.WriteLine("MD5 Hash: {0}", Convert.ToBase64String(md5HashedData));
        }

        // Method for Hashing data with MD5 hashing algorithm
        public static byte[] ComputeMD5Hash(byte[] data)
        {
            using (MD5 md5Hasher = MD5.Create())
            {
                return md5Hasher.ComputeHash(data);
            }
        }
    }
}
