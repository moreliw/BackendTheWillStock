using Microsoft.EntityFrameworkCore;
using TheWillStock.Data;
using Pomelo.EntityFrameworkCore.MySql;

namespace TheWillStock
{
  public class Startup
  {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

          services.AddDbContext<DataContext>(options =>
          options.UseMySql(Configuration.GetConnectionString("DataContext"),
          ServerVersion.AutoDetect(Configuration.GetConnectionString("DataContext")), builder => builder.MigrationsAssembly("TheWillStock")));

      //services.AddDbContext<DataContext>(options =>
      //      options.UseMySql(Configuration.GetConnectionString("DataContext"),
      //      ServerVersion.AutoDetect(Configuration.GetConnectionString("DataContext"))));


      services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configuração da pipeline de requisição da aplicação
        }
   }
}
