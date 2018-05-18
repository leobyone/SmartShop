using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;

namespace SmartShop.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SmartShopApplicationModule))]
    public class SmartShopWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SmartShopApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

			ConfigureSwaggerUi();
        }

		private void ConfigureSwaggerUi()
		{
			Configuration.Modules.AbpWebApi().HttpConfiguration
				.EnableSwagger(c =>
				{
					c.SingleApiVersion("v1", "SmartShopAPI文档");
					c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
					//将application层中的注释添加到SwaggerUI中
					var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

					var commentsFileName = "Bin//SmartShop.Application.xml";
					var commentsFile = Path.Combine(baseDirectory, commentsFileName);
					//将注释的XML文档添加到SwaggerUI中
					c.IncludeXmlComments(commentsFile);
				})
				.EnableSwaggerUi();
		}
	}
}
