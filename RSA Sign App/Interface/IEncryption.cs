using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Sign_App.Interface
{
    public interface IEncryption
    {
        /// <summary>
        /// This function to generate the RSA signing and provide it in Base 64 string format
        /// </summary>
        /// <param name="strBaseString"></param>
        /// <param name="strPrivateKeyLocation"></param>
        /// <param name="strHash"></param>
        /// <returns>
        /// returns in a base 64 string format.
        /// </returns>
        string GenerateRSASignature(string strBaseString, string strPrivateKeyLocation, string strHash);
    }
}
