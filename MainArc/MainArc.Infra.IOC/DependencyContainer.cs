using MainArc.Application.InterFaces;
using MainArc.Application.Services;
using MainArc.Ddomain.InterFaces;
using MainArc.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainArc.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Repository Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
