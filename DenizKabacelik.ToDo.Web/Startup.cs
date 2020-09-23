using DenizKc.ToDo.Business.Concrete;
using DenizKc.ToDo.Business.Interfaces;
using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DenizKabacelik.ToDo.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IGorevService, GorevManager>();
            services.AddScoped<IAciliyetService, AciliyetManager>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<IGorevDal, EFGorevRepositories>();
            services.AddScoped<IAciliyetDal, EfAciliyetRepository>();
            services.AddScoped<IRaporDal, EfRaporRepository>();
            services.AddDbContext<ToDoContext>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ToDoContext>(); 
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {

                 endpoints.MapControllerRoute(
                    name: "areas",
                    pattern:"{area}/{controller=Home}/{action=Index}/{Id?}"

                     );

                endpoints.MapControllerRoute(


                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    
                    
                    );
                
            });
        }
    }
}
