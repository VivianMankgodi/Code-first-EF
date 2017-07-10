using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHash
{
  public   class Program
    {
        public static string ComputeHash(string plaintext, string hashAlgorithm, byte[] saltBytes)
        {
            if (saltBytes == null )
            {
                int minSaltSize = 4;
                int maxSaltSize = 8;

                Random random = new Random();
                int saltSize = random.Next(minSaltSize, maxSaltSize);

                saltBytes = new byte[saltSize];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
            }

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plaintext );
            byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];

            for (int i = 0; i < saltBytes.Length; i++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }
            HashAlgorithm hash = null;
            if (hashAlgorithm  == null)
                {
                    hashAlgorithm  = "";
                }

                switch (hashAlgorithm.ToUpper())
                { case "SHA1":
                        hash = new SHA1Managed();
                        break;
                    case "SHA256":
                        hash = new SHA256Managed();
                        break;
                    case "SHA384":
                        hash = new SHA384Managed();
                        break;
                    case "SHA512":
                        break;
                            default:
                        hash = new MD5CryptoServiceProvider();
                        break;
                }

                byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);
                byte[] hasWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

                for (int t = 0; t < hashBytes.Length; t++)
                {
                    hasWithSaltBytes[hashBytes.Length + t] = saltBytes[t];
                }
                
                    string hashValue = Convert.ToBase64String(hasWithSaltBytes);
                

                    return hashValue;        
        }

        public static bool VerifyHash(string plainText, string hashAlgorithm, string hashValue)
        {
            byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);
            int hashSizeInBits=0, hashSizeInBytes;

            if (hashAlgorithm == null)
            {
                hashAlgorithm = "";
            }

            switch (hashAlgorithm.ToUpper() )
            {
                case "SHA1":
                    hashSizeInBits = 160;
                    break;
                case "SHA256":
                    hashSizeInBits = 256;
                    break;
                case "SHA384":
                    hashSizeInBits = 384;
                    break;
                case "SHA512":
                    break;
                default:
                    hashSizeInBits = 128;
                    break;
            }


            hashSizeInBytes = hashSizeInBits / 8;

            if (hashWithSaltBytes.Length < hashSizeInBytes )
            {
                return false;
            }
            byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

            for (int i = 0; i < saltBytes.Length ; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }

            string expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes);
            return (hashValue == expectedHashString);
        }



        static void Main(string[] args)
        {
            ProtectedPassword h = new SimpleHash.ProtectedPassword();
            // h.hash();

            SHA256 hash = new SHA256Cng();
            string password = "password";
            byte[] hashvalue = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            Console.WriteLine(System.Text.Encoding.Default.GetString(hashvalue));
            Console.ReadLine();

          /*  string password = "myP@5sw0rd";
            string wrongPassword = "password";
            string passwordHashMD5 = SimpleHash.Program.ComputeHash(password, "MD5", null);
            string passwordHashSha1 =
              SimpleHash.Program.ComputeHash(password, "SHA1", null);
            string passwordHashSha256 =
                  SimpleHash.Program.ComputeHash(password, "SHA256", null);
            string passwordHashSha384 =
                   SimpleHash.Program.ComputeHash(password, "SHA384", null);
            string passwordHashSha512 =
                  SimpleHash.Program.ComputeHash(password, "SHA512", null);

            Console.WriteLine("COMPUTING HASH VALUES\r\n");
            Console.WriteLine("MD5   : {0}", passwordHashMD5);
            Console.WriteLine("SHA1  : {0}", passwordHashSha1);
            Console.WriteLine("SHA256: {0}", passwordHashSha256);
            Console.WriteLine("SHA384: {0}", passwordHashSha384);
            Console.WriteLine("SHA512: {0}", passwordHashSha512);
            Console.WriteLine("");


            Console.WriteLine("COMPARING PASSWORD HASHES\r\n");
            Console.WriteLine("MD5    (good): {0}",
                                SimpleHash.Program.VerifyHash(
                                password, "MD5",
                                passwordHashMD5).ToString());
            Console.WriteLine("MD5    (bad) : {0}",
                                SimpleHash.Program.VerifyHash(
                                wrongPassword, "MD5",
                                passwordHashMD5).ToString());
            Console.WriteLine("SHA1   (good): {0}",
                                SimpleHash.Program.VerifyHash(
                                password, "SHA1",
                                passwordHashSha1).ToString());
            Console.WriteLine("SHA1   (bad) : {0}",
                                SimpleHash.Program.VerifyHash(
                                wrongPassword, "SHA1",
                                passwordHashSha1).ToString());
            Console.WriteLine("SHA256 (good): {0}",
                                SimpleHash.Program.VerifyHash(
                                password, "SHA256",
                                passwordHashSha256).ToString());
            Console.WriteLine("SHA256 (bad) : {0}",
                                SimpleHash.Program.VerifyHash(
                                wrongPassword, "SHA256",
                                passwordHashSha256).ToString());
            Console.WriteLine("SHA384 (good): {0}",
                               SimpleHash.Program.VerifyHash(
                                password, "SHA384",
                                passwordHashSha384).ToString());
            Console.WriteLine("SHA384 (bad) : {0}",
                                SimpleHash.Program.VerifyHash(
                                wrongPassword, "SHA384",
                                passwordHashSha384).ToString());
            Console.WriteLine("SHA512 (good): {0}",
                                SimpleHash.Program.VerifyHash(
                                password, "SHA512",
                                passwordHashSha512).ToString());
            Console.WriteLine("SHA512 (bad) : {0}",
                               SimpleHash.Program.VerifyHash(
                                wrongPassword, "SHA512",
                                passwordHashSha512).ToString());
*/

        }
    }
}
