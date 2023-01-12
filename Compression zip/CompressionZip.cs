using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppKryptoAndCompression.Compression_zip
{
    public class CompressionZip
    {
        public CompressionZip()
        {
        }

        public string CompressFileZip(string sourceFileName, BackgroundWorker worker)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(Path.ChangeExtension(sourceFileName, ".zip"), ZipArchiveMode.Create))
                {

                    archive.CreateEntryFromFile(sourceFileName, Path.GetFileName(sourceFileName));
                    worker.ReportProgress(1);
                }
                return Path.ChangeExtension(sourceFileName, ".zip");

            }
            catch(Exception e) { 
               
                return e.Message;   
            }
            
        }

        public void DeCompressFileZip(string sourceFileName, BackgroundWorker worker)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(Path.ChangeExtension(sourceFileName, ".zip"), ZipArchiveMode.Read))
                {
                    string directoryName = Path.GetDirectoryName(sourceFileName);
                    archive.ExtractToDirectory(directoryName, true);
                    worker.ReportProgress(1);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            

        }
       


    }
}
