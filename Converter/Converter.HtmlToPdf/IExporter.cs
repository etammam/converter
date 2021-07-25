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

        void FromHtmlString(
            [NotNull] string html,
            string outputFileName,
            string outputDirection,
            ConvertingOptions convertingOptions);

        void FromHtmlFileAsBase64(
            [NotNull] string htmlFileLocation,
            ConvertingOptions convertingOptions);

        void FromHtmlStringAsBase64(
            [NotNull] string html,
            ConvertingOptions convertingOptions);

        void FromMvcViewToFile([AspMvcView] string mvcView,string outputFileName,
            string outputDirection, ConvertingOptions convertingOptions);

        void FromMvcToBase64([AspMvcView] string mvcView, ConvertingOptions convertingOptions);
    }
}
