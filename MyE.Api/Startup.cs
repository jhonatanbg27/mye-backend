﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MyE.Api
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
            service.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IFinalReportRepository, FinalReportRepository>();
            services.AddTransient<IFinalReportService, FinalReportService>();

            services.AddTransient<IMachineReviewRepository, MachineReviewRepository>();
            services.AddTransient<IMachineReviewService, MachineReviewService>();

            services.AddTransient<IMedicalEquipmentRepository, MedicalEquipmentRepository>();//revisar
            services.AddTransient<IMedicalEquipmentService, MedicalEquipmentService>();

            services.AddTransient<IMembershipRepository, MembershipRepository>();
            services.AddTransient<IMembershipService, MembershipService>();

            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderService, OrderService>();

            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IRoleService, RoleService>();

            services.AddTransient<IScheduleRepository, ScheduleRepository>();
            services.AddTransient<IScheduleService, ScheduleService>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();




            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
               services.AddSwaggerGen (swagger => {
                var contact = new Contact () { Name = SwaggerConfiguration.ContactName, Url = SwaggerConfiguration.ContactUrl };
                swagger.SwaggerDoc (SwaggerConfiguration.DocNameV1,
                    new Info {
                        Title = SwaggerConfiguration.DocInfoTitle,
                            Version = SwaggerConfiguration.DocInfoVersion,
                            Description = SwaggerConfiguration.DocInfoDescription,
                            Contact = contact
                    }
                );
            });

            services.AddCors (options => {
                options.AddPolicy ("Todos",
                    builder => builder.WithOrigins ("*").WithHeaders ("*").WithMethods ("*"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //CONFIGURAR SWAGGER
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
