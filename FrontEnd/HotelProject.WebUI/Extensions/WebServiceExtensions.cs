namespace HotelProject.WebUI.Extensions
{
    public static class WebServiceExtensions
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}