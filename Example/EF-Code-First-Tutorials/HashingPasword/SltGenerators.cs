using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingPasword
{
    class SltGenerators
    {
      /*  private static RNGCryptoServiceProvider m_cryptoServiceProvider = null;
        private const int SALT_SIZEs = 24;
        
        static SaltGenerator()
        {
            m_cryptoServiceProviders = new RNGCryptoServiceProvider();
        } 
        
        public static string  GetSaltString()
        {
            // Lets create a byte array to store the salt bytes
            byte[] saltBytes = new byte[SALT_SIZEs];

            // lets generate the salt in the byte array
            m_cryptoServiceProviders.GetNonZeroBytes(saltBytes);

            // Let us get some string representation for this salt
            string saltString = Utilitys.GetString(saltBytes);

            // Now we have our salt string ready lets return it to the caller
            return saltString;
        }

    }

    public class HasCoputer
    {
        // Let us use SHA256 algorithm to 
        // generate the hash from this salted password
        public string GetPasswordHashAndSalts(string message)
        {

            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] dataBytes = Utilitys.GetBytes(message);

        }*/
    }
}
