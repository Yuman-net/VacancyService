// <copyright file="Startup.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

using DataAccess;
using DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public sealed class Startup
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Startup"/>.
        /// </summary>
        /// <param name="configuration"> Конфигурация. </param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        /// <summary>
        /// Конфигурация.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Метод конфигурации сервисов.
        /// </summary>
        /// <param name="services"> Коллекция сервисов. </param>
        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddDataAccess(this.Configuration);
        }

        /// <summary>
        /// Конфигурирование хоста.
        /// </summary>
        /// <param name="app"> Строитель приложения. </param>
        /// <param name="env"> Параметры среды хоста. </param>
        /// <param name="dataContext"> Контекст базы данных. </param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
}
