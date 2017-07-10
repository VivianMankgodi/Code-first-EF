using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHash
{
    class ProtectedPassword
    {
        public void hash()
        {
            string clearText = "doublecloud.org";
            byte[] clearTextBytes = Encoding.Unicode.GetBytes(clearText);

            //byte[] encryptedTextBytes = ProtectedData.Protect(clearTextBytes, null, DataProtectionScope.CurrentUser);
            //string encryptedTextBase64 = Convert.ToBase64String(encryptedTextBytes);
            //System.Console.WriteLine("Encrypted:" + encryptedTextBase64);

            //// decrypt what's been encrypted
            //string encText = encryptedTextBase64;
            //byte[] encTextBytes = Convert.FromBase64String(encText);

            //byte[] decryptedBytes = ProtectedData.Unprotect(encTextBytes, null, DataProtectionScope.CurrentUser);
            //string decryptedText = Encoding.Unicode.GetString(decryptedBytes);
            //System.Console.WriteLine("Decrypted:" + decryptedText);

            System.Console.WriteLine("Done");
        }
    }
}
