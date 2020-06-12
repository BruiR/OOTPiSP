using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary
{
    class Deflate : IPlugin
    {
        public const string filters = "архив (*.cmp)|*.cmp";
        public const string format = ".cmp";


        public void Compress(string filename)
        {
            FileInfo fileToBeDeflateZipped = new FileInfo(filename);
            FileInfo deflateZipFileName = new FileInfo(string.Concat(fileToBeDeflateZipped.FullName, ".cmp"));

            using (FileStream fileToBeZippedAsStream = fileToBeDeflateZipped.OpenRead())
            {
                using (FileStream deflateZipTargetAsStream = deflateZipFileName.Create())
                {
                    using (DeflateStream deflateZipStream = new DeflateStream(deflateZipTargetAsStream, CompressionMode.Compress))
                    {
                        try
                        {
                            fileToBeZippedAsStream.CopyTo(deflateZipStream);
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }
        public string Decompress(string filename)
        {
            FileInfo deflateZipFileName = new FileInfo(filename);
            FileInfo decompressedFileName = new FileInfo((string)deflateZipFileName.FullName.Substring(0, deflateZipFileName.FullName.Length - 4));

            using (FileStream fileToDecompressAsStream = deflateZipFileName.OpenRead())
            {
                using (FileStream decompressedStream = decompressedFileName.Create())
                {
                    using (DeflateStream decompressionStream = new DeflateStream(fileToDecompressAsStream, CompressionMode.Decompress))
                    {
                        try
                        {
                            decompressionStream.CopyTo(decompressedStream);
                            return ("Success decompressing");
                        }
                        catch (Exception ex)
                        {
                            return (ex.Message);
                        }
                    }
                }
            }
        }

    }
}
    