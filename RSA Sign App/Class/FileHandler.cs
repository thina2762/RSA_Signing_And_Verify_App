

using RSA_Sign_App.Interface;

namespace RSA_Sign_App.Class
{
    public class FileHandler : IFileHandler
    {
        public bool CheckIfFileExist(string path)
        {
            try
            {
                return File.Exists(path);

            }
            catch (IOException)
            {

                throw;
            }
        }


        public  bool CreateFolderIfNotExist()
        {
            try
            {
                if(!Directory.Exists(@"~/JsonFile"))
                {
                    Directory.CreateDirectory(@"~/JsonFile");
                    return true;
                };
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool CreateFile(string path)
        {
            try
            {
               var file= File.CreateText(path);
                file.Close();
                return true;
            }
            catch (IOException)
            {
                return false;
                throw;
            }
        }

        public bool CreateFolderIFnotExists(string strPath)
        {
            try
            {
               Directory.CreateDirectory(strPath);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
                return true;
            }
            catch (IOException)
            {
                return false;
                throw;
            }
        }

        public string ReadFileContent(string? path)
        {
            try
            {
                if(path == null)
                {
                    return "";
                }
                if (File.Exists(path))
                {
                    return File.ReadAllText(path);
                }
                return "";
            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }

        public bool WriteTofile(string strPath, string Message)
        {
            try
            {
                using StreamWriter Writer = new StreamWriter(strPath,append:true);
                Writer.Write(Message);
                return true;
               
            }
            catch (IOException)
            {
                return false;
                throw;
            }
        }
    }
}
