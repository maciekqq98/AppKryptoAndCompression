using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using File = System.IO.File;


namespace AppKryptoAndCompression
{
    public class AESRJ
    {
        public AESRJ()
        {
        }

        public static byte[] CreatingPassword(string password)
        {

            byte[] salt =  new byte[] { 23, 21, 32, 33, 46, 59, 60, 74 };
            int keyLength = 16;

            byte[] key;

            using (var pbkdf = new Rfc2898DeriveBytes(password, salt))
            {
                key = pbkdf.GetBytes(keyLength);
            }
            return key;
        }

        public  void EncryptFile(string inputFile, string outputFile, string password, BackgroundWorker worker)
        {
            //
            try
            {
             
               byte[] key = CreatingPassword(password);
                // password = @"myKey123"; // Your Key Here
                //UnicodeEncoding UE = new UnicodeEncoding();
                //byte[] key = UE.GetBytes(password);
                outputFile += ".aes";
                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);
                long size;

                using (FileStream file = new FileStream(inputFile, FileMode.Open))
                {
                    
                    int ToRead;
                    long BRead = 0;
                    var buffer = new byte[1024];
                    size = file.Length;

                    while ((ToRead = file.Read(buffer, 0, buffer.Length)) > 0)
                    {

                        BRead += ToRead;

                        worker.ReportProgress((int)(100 * ((double)BRead / size)));
                        //cs.WriteByte((byte)ToRead);
                        cs.Write(buffer, 0, (int)ToRead);
                    }

                    file.Close();
                    cs.Close();
                    fsCrypt.Close();

                }

            }
            catch
            {
                Console.WriteLine("Encryption failed!", "Error");
            }



        }


        public string DecryptFile(string inputFile, string outputFile,BackgroundWorker worker, string password)
        {
            
            if (!inputFile.EndsWith(".aes")) //jeżeli plik nie ma rozszerzenia .aes, nie możemy go odszyfrować
            {
                //throw new FileNotFoundException("plik nie ma rzoszerzenia aes");
                return "repeat";
            }
            
            try
            {
                
                string newFile = GetUniqueFilename(outputFile); //zabezpieczenie przed taka sama nazwą plików nizej funkcja
                // string password = @"myKey123"; // Your Key Here
               // UnicodeEncoding UE = new UnicodeEncoding();
                //byte[] key = UE.GetBytes(password);
                byte[] key = CreatingPassword(password);

                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                 {
                    RijndaelManaged RMCrypto = new RijndaelManaged();

                    CryptoStream cs = new CryptoStream(fsCrypt,
                        RMCrypto.CreateDecryptor(key, key),
                        CryptoStreamMode.Read);
                    long size;
                    using (FileStream fileOut = new FileStream(newFile, FileMode.Create))
                    { // po using usuwa pamiec nie ma błedu z brakiem dostepu do pliku
  
                        int ToRead;
                        long BRead = 0;
                        var buffer = new byte[1024];
                        size = fsCrypt.Length;

                        //while ((data=cs.ReadByte()) != -1)
                        //{

                        //    fileOut.WriteByte((byte)data); 
                        //}
                        while ((ToRead = cs.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            BRead += ToRead;
                            worker.ReportProgress((int)(100 * ((double)BRead / size)));
                            //cs.WriteByte((byte)ToRead);
                            fileOut.Write(buffer, 0, (int)ToRead);
                        }

                        fileOut.Close();
                        cs.Close();
                        fsCrypt.Close();
                    }

                  } 
                }
                catch
                {

                    Console.WriteLine("Encryption failed!", "Error");
                    return "error";

                }

                return "OK";
        }

        public static string GetUniqueFilename(string fullPath) // zabezpieczenie przed taką sama nazwa plkiku po odszyfrowaniu
        {
            ;
            if (!Path.IsPathRooted(fullPath))
                fullPath = Path.GetFullPath(fullPath);
            if (File.Exists(fullPath))
            {
                string filename = Path.GetFileName(fullPath);
                string path = fullPath.Substring(0, fullPath.Length - filename.Length);
                string filenameWOExt = Path.GetFileNameWithoutExtension(fullPath);
                string ext = Path.GetExtension(fullPath);
                int n = 1;
                do
                {
                    fullPath = Path.Combine(path, String.Format("{0} ({1}){2}", filenameWOExt, (n++), ext));
                }
                while (File.Exists(fullPath));
            }
            return fullPath;
        }

    }

}
