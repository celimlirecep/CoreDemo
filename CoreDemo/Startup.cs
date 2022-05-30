using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal,EFCategoryRepository>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EFBlogRepository>();
            services.AddScoped<ICommentDAL, EFCommentRepository>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IWriterService, WriterManager>();
            services.AddScoped<IWriterDAL, EFWriterRepository>();
            services.AddScoped<INewsLetterDAL, EFNewsLetterRepository>();
            services.AddScoped<INewsLetterService, NewsLetterManager>();
            services.AddScoped<IAboutDAL, EFAboutRepository>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IContactDAL, EFContactRepository>();
            services.AddScoped<IContactService, ContactManager>();

            //Login iþlemi için authorization devam(2)
            services.AddSession(); //yeni düzenleme ile gerek kalmadý

            //Authentication iþlemleri 
            //Proje seviyesinde Authorize iþlemi gerçekleþtirmiþ olduk
            services.AddMvc(config => {

                var policy = new AuthorizationPolicyBuilder()
                  .RequireAuthenticatedUser()
                  .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            
            });

            //Authentice olunmayan yerde ki durumlarý ayarlýyoruz
            services.AddMvc();
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(i =>
                {
                    i.LoginPath = "/Login/Index";// authentice deðilse buraya yönlendirir
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");
          //  app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();



            //login iþlemi için gerekli
            app.UseAuthentication();
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
