
using HotelProject.DataAccessLayer;
using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<Context>(opt =>
            {
                opt.UseSqlServer("server=.\\SQLExpress;initial catalog=ApiDb;integrated security=true;TrustServerCertificate=True;");
            });
            services.AddScoped<IStaffDal, EfStaffDal>();


            // services.AddCors(opt =>
            // {
            //     opt.AddPolicy("CorsPolicy", policy =>
            //     {
            //         policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:5000");
            //     });
            // });


            return services;
        }
    }
}