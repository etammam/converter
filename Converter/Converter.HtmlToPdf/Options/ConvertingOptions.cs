using Converter.HtmlToPdf.Enums;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Security;

namespace Converter.HtmlToPdf.Options
{
    public class ConvertingOptions
    {
        public PageOrientations PageOrientation { get; set; } = PageOrientations.Landscape;
        public PageSize PageSize { get; set; }
        public PdfMargins PdfMargins { get; set; }
        public PdfDocumentInformation DocumentInformation { get; set; }
        public PdfSecurity PdfSecurity { get; set; }
    }
}
