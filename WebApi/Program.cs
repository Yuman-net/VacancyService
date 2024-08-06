// <copyright file="Program.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

using DataAccess.Extensions;

namespace WebApi
{
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

            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoint => endpoint.MapControllers());
        }
    }
}
