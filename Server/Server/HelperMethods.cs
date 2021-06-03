using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public static class HelperMethods
    {
        public static byte[] MessageHash(string msg)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                return sHA256.ComputeHash(Encoding.UTF8.GetBytes(msg));
            }
        }

        public static bool VerifyMessage(byte[] hash, byte[] signature)
        {
            try
            {
                CspParameters csp = new CspParameters();

                csp.KeyContainerName = "KeyContainer";

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp))
                {
                    var deformat = new RSAPKCS1SignatureDeformatter(rsa);
                    deformat.SetHashAlgorithm("SHA256");

                    return deformat.VerifySignature(hash, signature);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static string Verify(string msg, byte[] signature)
        {
            byte[] msgHash = HelperMethods.MessageHash(msg);

            //messageTxt.Text = orgMessage;
            if (HelperMethods.VerifyMessage(msgHash, signature))
            {
                MessageBox.Show("You can trust this message !");
                return msg;
            }
            else
            {
                MessageBox.Show("Do not trust this message !");
                return null;
            }
        }

        public static void CallExtraMethod(string msg, byte[] signature)
        {
            Console.WriteLine("MSG +" + msg);
            Server.XCheck(msg, signature);
        }
    }
}