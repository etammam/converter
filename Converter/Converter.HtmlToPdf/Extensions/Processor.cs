using System;
using System.IO;
using Converter.HtmlToPdf.Options;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;

namespace Converter.HtmlToPdf.Extensions
{
    public static class Processor
    {
        public static HtmlToPdfConverter InitConverter()
        {
            var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            var webKitSettings = new WebKitConverterSettings
            {
                WebKitPath = Path.GetFullPath("../../QtBinaries")
            };
            htmlConverter.ConverterSettings = webKitSettings;
            return htmlConverter;
        }

        public static PdfDocument InitDocument(this PdfDocument document,ConvertingOptions convertingOptions)
        {
            document.AutoTag = true;

            if (convertingOptions.PdfSecurity != null)
            {
                document.Security.Algorithm = convertingOptions.PdfSecurity.Algorithm;
                document.Security.Permissions = convertingOptions.PdfSecurity.Permissions;
                document.Security.EncryptionOptions = convertingOptions.PdfSecurity.EncryptionOptions;
                document.Security.KeySize = convertingOptions.PdfSecurity.KeySize;
                document.Security.OwnerPassword = convertingOptions.PdfSecurity.OwnerPassword;
                document.Security.UserPassword = convertingOptions.PdfSecurity.UserPassword;
            }

            if (convertingOptions.DocumentInformation != null)
            {
                document.DocumentInformation.Author = convertingOptions.DocumentInformation.Author;
                document.DocumentInformation.Creator = convertingOptions.DocumentInformation.Creator;
                document.DocumentInformation.CreationDate = convertingOptions.DocumentInformation.CreationDate;
                document.DocumentInformation.Keywords = convertingOptions.DocumentInformation.Keywords;
                document.DocumentInformation.Language = convertingOptions.DocumentInformation.Language;
                document.DocumentInformation.Producer = convertingOptions.DocumentInformation.Producer;
                document.DocumentInformation.Subject = convertingOptions.DocumentInformation.Subject;
                document.DocumentInformation.Title = convertingOptions.DocumentInformation.Title;
                document.DocumentInformation.ModificationDate = convertingOptions.DocumentInformation.ModificationDate;
            }

            if (convertingOptions.PdfMargins != null)
            {
                document.PageSettings.Margins = convertingOptions.PdfMargins;
            }

            return document;
        }
    }
}