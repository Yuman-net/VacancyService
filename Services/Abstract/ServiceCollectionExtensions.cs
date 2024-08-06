// <copyright file="ServiceCollectionExtensions.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Расширения для использования сервисов.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Регистриует сервисы.
        /// </summary>
        /// <param name="services"> Коллекция сервисов. </param>
        /// <returns> Обновленная коллекция сервисов. </returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<ICarService, CarService>();
        }
    }
}
