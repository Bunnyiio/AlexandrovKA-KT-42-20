using _1laba.Interfaces.CourseInterfaces;
using _1laba.Interfaces.StudentsInterfaces;

namespace _1laba.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICoursesService, CourseService>();

            return services;
        }
    }
}
