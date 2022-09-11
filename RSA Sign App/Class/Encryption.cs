using RSA_Sign_App.Interface;
using System.Security.Cryptography;
using System.Text;

namespace RSA_Sign_App.Class
{
    public class Encryption : IEncryption
    {
        private readonly IFileHandler _fileManager;

        public Encryption(IFileHandler filemanager)
        {
            _fileManager=filemanager;
        }


        public string GenerateRSASignature(string strBaseString, string strPrivateKeyLocation, string strHash)
        {
			try
			{
                string RSAPrivateKey = _fileManager.ReadFileContent(path: strPrivateKeyLocation);
                string Signature = "";


                if (RSAPrivateKey == null || RSAPrivateKey == "")
                {
                    return "";
                }
                using (var RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportFromPem(RSAPrivateKey);

                    byte[] Data = Encoding.UTF8.GetBytes(strBaseString);


#pragma warning disable CS8604 // Possible null reference argument.
                    var Sign = RSA.SignData(Data, halg: CryptoConfig.MapNameToOID(strHash));
#pragma warning restore CS8604 // Possible null reference argument.

                    Signature = Convert.ToBase64String(Sign);

                }
                return Signature;
            }
			catch (Exception e)
			{
                MessageBox.Show(e.Message.ToString());
				throw;
			}
        }

        public bool VerifySigning(string strSignValue, string strMessage, string strPublicKeyLocations, string strHash)
        {
            string RSAPublicKey = _fileManager.ReadFileContent(path: strPublicKeyLocations);
            using (var RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportFromPem(RSAPublicKey);
#pragma warning disable CS8604 // Possible null reference argument.
                var status = RSA.VerifyData(Encoding.UTF8.GetBytes(strMessage), halg: CryptoConfig.MapNameToOID(strHash), Convert.FromBase64String(strSignValue));
#pragma warning restore CS8604 // Possible null reference argument.
                return status;
            }
        }
    }
}
