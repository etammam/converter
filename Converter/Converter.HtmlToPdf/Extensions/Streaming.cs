using System.IO;
using System.Text;


namespace Converter.HtmlToPdf.Extensions
{
    public static class Streaming
    {
        public static Stream StringToStream(this string sentence)
        {
            var byteArray = Encoding.UTF8.GetBytes(sentence);
            var stream = new MemoryStream(byteArray);
            return stream;
        }

        public static string StreamToString(this Stream stream)
        {
            var reader = new StreamReader(stream);
            var text = reader.ReadToEnd();
            return text;
        }
    }
}
