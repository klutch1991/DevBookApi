using DevBook.Data;
using DevBook.Data.Abstraction;
using DevBook.Data.Models;
using DevBook.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevBook.Api
{
	public class Startup
	{
		private readonly IConfiguration _configuration;

		public Startup(
			IConfiguration configuration) 
				=> _configuration = configuration;

		public void ConfigureServices(IServiceCollection services)
			=> services
				.AddScoped<IRepository<Objective>, ObjectivesRepository>()
				.AddDbContextPool<DevBookContext>(opts => opts
					.UseSqlServer(_configuration.GetConnectionString("DevBookDb")))
				.AddMvc();

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