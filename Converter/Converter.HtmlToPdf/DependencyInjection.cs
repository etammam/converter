using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Converter.HtmlToPdf
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterExporterService(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<IExporter, Exporter>();
            return serviceCollection;
        }

        public static IApplicationBuilder RegisterExporterPipeline(this IApplicationBuilder app)
        {
            app.UseStaticFiles();
            return app;
        }
    }
}
