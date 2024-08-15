// <copyright file="Program.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi
{
    using DataAccess.Extensions;
    using Microsoft.OpenApi.Models;
    using Services.Abstract;
    using WebApi.Profiles;

    /// <summary>
    /// Класс, описывающий точку входа.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        /// <param name="args"> Входные аргументы. </param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            _ = builder.Services.AddDataAccess(builder.Configuration);
            _ = builder.Services.AddAutoMapper();
            _ = builder.Services.AddControllers();
            _ = builder.Services.AddServices();
            _ = builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = $"Yuman.Car", Version = "v1" });
                var xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml");
                foreach (var xmlFile in xmlFiles)
                {
                    options.IncludeXmlComments(xmlFile);
                }
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}
