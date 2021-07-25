using System;
using System.IO;

namespace Converter.HtmlToPdf.Extensions
{
    internal static class Creator
    {
        private const string FolderPath = "wwwroot/converter";
        internal static bool InSureFolderStructure()
        {
            var result = File.Exists(FolderPath);
            return result;
        }

        internal static bool CreateFolderStructure()
        {
            try
            {
                if (InSureFolderStructure() == false)
                {
                    File.Create(FolderPath);
                    return true;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
