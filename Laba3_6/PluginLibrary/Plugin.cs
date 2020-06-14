using System;
using System.Collections.Generic;

namespace PluginLibrary
{
    public interface IPlugin
    {
        void Compress(string filename);
       string  Decompress(string filename);
    }
}
