using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingPasword
{
    class Class1
    {
    }
    public static class SaltGenerator
    {
        private static RNGCryptoServiceProvider m_cryptoServiceProvider = null;
        private const int SALT_SIZE = 24;

        static SaltGenerator()
        {
            m_cryptoServiceProvider = new RNGCryptoServiceProvider();
        }

        /* public static string GetSaltString()
         {
             // Lets create a byte array to store the salt bytes
             byte[] saltBytes = new byte[SALT_SIZE];

             // lets generate the salt in the byte array
             m_cryptoServiceProvider.GetNonZeroBytes(saltBytes);

             // Let us get some string representation for this salt
             string saltString = Utility.GetString(saltBytes);

             // Now we have our salt string ready lets return it to the caller
             return saltString;
         }
     }

     public class HashComputer
     {
         public object Utility { get; private set; }

         public string GetPasswordHashAndSalt(string message)
         {
             // Let us use SHA256 algorithm to 
             // generate the hash from this salted password
             SHA256 sha = new SHA256CryptoServiceProvider();
             byte[] dataBytes = Utility. (message);
             byte[] resultBytes = sha.ComputeHash(dataBytes);

             // return the hash string to the caller
             return Utility.GetString(resultBytes);
         }
     }

     public class PasswordManager
     {
         HashComputer m_hashComputer = new HashComputer();

         public string GeneratePasswordHash(string plainTextPassword, out string salt)
         {
             salt = SaltGenerator.GetSaltString();

             string finalString = plainTextPassword + salt;

             return m_hashComputer.GetPasswordHashAndSalt(finalString);
         }

         public bool IsPasswordMatch(string password, string salt, string hash)
         {
             string finalString = password + salt;
             return hash == m_hashComputer.GetPasswordHashAndSalt(finalString);
         }
     }

  public    class User
     {
         public string UserId { get; set; }
         public string PasswordHash { get; set; }
         public string Salt { get; set; }
     }

 public     class MockUserRepository
     {
         List<User> users = new List<User>();

         // Function to add the user to im memory dummy DB
         public void AddUser(User user)
         {
             users.Add(user);
         }

         // Function to retrieve the user based on user id
         public User GetUser(string userid)
         {
             return users.Single(u => u.UserId == userid);
         }
     }*/
    }
}
