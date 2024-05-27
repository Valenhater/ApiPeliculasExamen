using Amazon.Lambda.Annotations;
using ApiPeliculasExamen.Data;
using ApiPeliculasExamen.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApiPeliculasExamen;

[LambdaStartup]
public class Startup
{
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<RepositoryPeliculas>();
        string connectionString = @"server=awsmysqlvalen.crgy64m6eb9m.us-east-1.rds.amazonaws.com;port=3306;user id=admin;password=Admin123;database=television";
        services.AddDbContext<PeliculasContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
    }
}
