// <copyright file="DataAccessExtensions.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Extensions
{
    /// <summary>
    /// Класс с методами расшширениями для DataAccess.
    /// </summary>
    public static class DataAccessExtensions
    {
        /// <summary>
        /// Метод для добавления зависимости для работы с базой данных.
        /// </summary>
        /// <param name="services"> Коллекция сервисов. </param>
        /// <param name="connectionString"> Строка подключения к базе данных. </param>
        /// <returns> <see cref="IServiceCollection"/>. </returns>
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));
        }

        /// <summary>
        /// Метод для добавления зависимости для работы с базой данных.
        /// </summary>
        /// <param name="services"> Коллекция сервисов. </param>
        /// <param name="configuration"> Конфигурация. </param>
        /// <param name="connectionStringName"> Строка подключения к базе данных. </param>
        /// <returns> <see cref="IServiceCollection"/>. </returns>
        /// <exception cref="ArgumentNullException">
        /// В случае, если конифгурационный файл <see langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// В случае, если строка подключения была не найдена в конфигурационном файле.
        /// </exception>
        public static IServiceCollection AddDataAccess(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionStringName = "Default")
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            var connectionString = configuration.GetConnectionString(connectionStringName)
                ?? throw new ArgumentException(
                    $"Строка подключения {connectionStringName} в конфигурационном файле не найдена.");

            return services.AddDataAccess(connectionString);
        }
    }
}
