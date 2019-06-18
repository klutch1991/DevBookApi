using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DevBook.Api
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services
				.AddMvc();
		}

		public void Configure(
			IApplicationBuilder application, 
			IHostingEnvironment environment)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
			}

			application
				.UseMvc();
		}
	}
}