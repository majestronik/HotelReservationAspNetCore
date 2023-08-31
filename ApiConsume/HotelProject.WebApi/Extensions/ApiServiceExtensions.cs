
using HotelProject.DataAccessLayer;
using HotelProject.DataAccessLayer.Abstact;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Extensions
{
    public static class ApiServiceExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration config)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<Context>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddCors(opt =>
            {
                opt.AddPolicy("HotelApiCors", policy =>
                {
                    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            return services;
        }
    }
}