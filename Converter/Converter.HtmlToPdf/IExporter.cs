using System.Web.Mvc;
using Converter.HtmlToPdf.Options;
using JetBrains.Annotations;

namespace Converter.HtmlToPdf
{
    public interface IExporter
    {
        void FromHtmlFile(
            [NotNull] string htmlFileLocation,
            string outputFileName,
            string outputDirection,
            ConvertingOptions convertingOptions);

        void FromHtmlString([NotNull] string html,
            string outputFileName,
            ConvertingOptions convertingOptions);
        
        void FromMvcView([AspMvcController] Controller controller, [AspMvcView] string mvcView,
            object model,string outputFileName
            ,ConvertingOptions convertingOptions);
    }
}
