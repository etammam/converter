using System;
using System.Linq;

namespace Converter.HtmlToPdf.Extensions
{
    public static class Renaming
    {
        public static string GetNewName()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Concat(".pdf").ToString();
        }
    }
}
