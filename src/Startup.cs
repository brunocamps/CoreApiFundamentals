using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCodeCamp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CoreCodeCamp
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      //adding context object to the database 
      services.AddDbContext<CampContext>();
      services.AddScoped<ICampRepository, CampRepository>(); //camp repository and associated interface

      services.AddControllers(); //not adding the view support. No need for this.
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      //using only on development
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting(); //using routing

      //using authentication and authorization
      //marcar metricas que marcou atrasada
      app.UseAuthentication();
      app.UseAuthorization();

      app.UseEndpoints(cfg =>
      {
        cfg.MapControllers(); //for endpoints, we're only mapping controllers
      });
    }
  }
}
