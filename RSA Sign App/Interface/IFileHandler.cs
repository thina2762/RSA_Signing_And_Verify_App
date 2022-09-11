using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Sign_App.Interface
{
    public interface IFileHandler
    {
        /// <summary>
        /// this function check for the existance of the file;
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Boolean CheckIfFileExist(string path);
        /// <summary>
        /// this interface shall delete the file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Boolean DeleteFile(string path);
        /// <summary>
        /// this Interface shall create the file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        Boolean CreateFile(string path);
        /// <summary>
        /// this functions shall read and store the file content to  string variable
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        String ReadFileContent(string path);
        /// <summary>
        /// this function is to write the message to text file
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="Message"></param>
        /// <returns></returns>
        Boolean WriteTofile(string strPath, string Message);
        /// <summary>
        ///  this function shall create the path.
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        Boolean CreateFolderIFnotExists(string strPath);
        /// <summary>
        /// to create Json folde
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool CreateFolderIfNotExist();
    }
}
