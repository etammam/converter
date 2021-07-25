using System.Web.Mvc;
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

        public void FromHtmlString(string html, string outputFileName, ConvertingOptions convertingOptions)
        {
            var converter = Processor.InitConverter();
            var document = converter.Convert(html)
                .InitDocument(convertingOptions);
            document.Save(outputFileName);
            document.Close(true);
        }

        public void FromMvcView(Controller controller,string mvcView,object model, string outputFileName,
            ConvertingOptions convertingOptions)
        {
            var converter = Processor.InitConverter();
            var htmlString = controller.RenderRazorViewToString(mvcView, model);
            var document = converter.Convert(htmlString)
                .InitDocument(convertingOptions);
            document.Save(outputFileName);
            document.Close(true);
        }
    }
}