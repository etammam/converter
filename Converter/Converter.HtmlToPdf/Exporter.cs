using System;
using Converter.HtmlToPdf.Enums;
using Converter.HtmlToPdf.Extensions;
using Converter.HtmlToPdf.Options;

namespace Converter.HtmlToPdf
{
    public class Exporter : IExporter
    {
        public void FromHtmlFile(string htmlFileLocation, string outputFileName, string outputDirection,
            ConvertingOptions convertingOptions)
        {
            var converter = Processor.InitConverter();
            var document = converter.Convert(htmlFileLocation)
                .InitDocument(convertingOptions);
            document.Save(outputFileName);
            document.Close(true);
        }

        public void FromHtmlString(string html, string outputFileName, string outputDirection, ConvertingOptions convertingOptions)
        {
            throw new NotImplementedException();
        }

        public void FromHtmlFileAsBase64(string htmlFileLocation, ConvertingOptions convertingOptions)
        {
            throw new NotImplementedException();
        }

        public void FromHtmlStringAsBase64(string html, ConvertingOptions convertingOptions)
        {
            throw new NotImplementedException();
        }

        public void FromMvcViewToFile(string mvcView, string outputFileName, string outputDirection,
            ConvertingOptions convertingOptions)
        {
            throw new NotImplementedException();
        }

        public void FromMvcToBase64(string mvcView, ConvertingOptions convertingOptions)
        {
            throw new NotImplementedException();
        }
    }
}