using Fiver.Mvc.TagHelpers.Components.Lib;
using Fiver.Mvc.TagHelpers.Components.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;

namespace Fiver.Mvc.TagHelpers.Components
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddSingleton<IMetaService, MetaService>();

            services.AddSingleton<ITagHelperComponent, MetaTagHelperComponent>();
            services.AddSingleton<ITagHelperComponent, FooterTagHelperComponent>();
            services.AddSingleton<ITagHelperComponent, ScriptsTagHelperComponent>();

            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
