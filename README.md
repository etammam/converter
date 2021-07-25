#### Html Convert

A simple NuGet package that's allow c# developers to easily convert a html string or a MVC view to a PDF file

###### Supported Methods

1. Export Html String To PDF
2. Export Html File To PDF 
3. Export MVC View To PDF

###### Installation
you should inject the service and middleware into your startup class as following

`service.RegisterExporterService();`

in the configure service method on the startup class and,

`service.RegisterExporterPipeline();`

in the configure method for complete the pipeline configuration

###### Usage

You can simple use this package from the interface of exporter which hold the following methods

`FromHtmlFile(`
            `string htmlFileLocation,`
            `string outputFileName,`
            `string outputDirection,`
            `ConvertingOptions convertingOptions);`

`FromHtmlString(string html,`
            `string outputFileName,`
            `ConvertingOptions convertingOptions);`

`FromMvcView(Controller controller, string mvcView,`
            `object model,string outputFileName`
            `,ConvertingOptions convertingOptions);`

and you can use the converting options as following 

- PageOrientations
- PageSize
- PdfMargins
- DocumentInformation
- PdfSecurity
