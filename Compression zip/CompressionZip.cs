using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            using(ZipArchive archive = ZipFile.Open(Path.ChangeExtension(sourceFileName, ".zip"), ZipArchiveMode.Create))
            {

                archive.CreateEntryFromFile(sourceFileName, Path.GetFileName(sourceFileName));
                worker.ReportProgress(1);
            }
            return Path.ChangeExtension(sourceFileName, ".zip");
        }

        public void DeCompressFileZip(string sourceFileName, BackgroundWorker worker)
        {

            using(ZipArchive archive = ZipFile.Open(Path.ChangeExtension(sourceFileName, ".zip"), ZipArchiveMode.Read))
            {
                string directoryName = Path.GetDirectoryName(sourceFileName);
                // var test= AESRJ.GetUniqueFilename(filePath);
                archive.ExtractToDirectory(directoryName, true);
                worker.ReportProgress(1);
            }

        }

    }
}
