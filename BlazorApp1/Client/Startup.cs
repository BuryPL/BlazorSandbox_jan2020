using LogicAndShit.Validation;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.EJ2.Blazor;

namespace BlazorApp1.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IValidations, Validations>();
            //services.AddTelerikBlazor();
            services.AddSyncfusionBlazor();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
