using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary
{
    class BZip2: IPlugin
    {
        public const string filters = "архив (*.bz2)|*.bz2";
        public const string format = ".bz2";
        public void Compress(string filename)
        {
            FileInfo fileToBeZipped = new FileInfo(filename);
            FileInfo zipFileName = new FileInfo(string.Concat(fileToBeZipped.FullName, ".bz2"));
            using (FileStream fileToBeZippedAsStream = fileToBeZipped.OpenRead())
            {
                using (FileStream zipTargetAsStream = zipFileName.Create())
                {
                    ICSharpCode.SharpZipLib.BZip2.BZip2.Compress(fileToBeZippedAsStream, zipTargetAsStream, true, 4096);
                }
            }

            System.IO.File.Delete(filename);
        }
        public string Decompress(string filename)
        {
   
            FileInfo zipFileName = new FileInfo(filename);
            FileInfo decompressedFileName = new FileInfo((string)zipFileName.FullName.Substring(0, zipFileName.FullName.Length - 4));
            using (FileStream fileToDecompressAsStream = zipFileName.OpenRead())
            {
                try
                {
                    using (FileStream decompressedStream = decompressedFileName.Create())
                    {
                        ICSharpCode.SharpZipLib.BZip2.BZip2.Decompress(fileToDecompressAsStream, decompressedStream, true);
                    }
                    return "Success decompressing";

                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }
            }

        }
    }
}
