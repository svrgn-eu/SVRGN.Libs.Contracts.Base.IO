using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SVRGN.Libs.Contracts.Base.IO
{
    public interface IFileIOWrapper
    {
        #region Methods
        bool Exists(string path);
        string ReadAllText(string path);
        bool WriteAllText(string path, string text);

        List<string> DirectoryGetFiles(string Path);
        Stream ReadStream(string Filename);
        bool WriteStream(string Filename, Stream Input);
        #endregion Methods
    }
}
