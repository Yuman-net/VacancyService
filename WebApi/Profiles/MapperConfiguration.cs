// <copyright file="MapperConfiguration.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles
{
    /// <summary>
    /// Регистриует все првила отображения.
    /// </summary>
    public static class MapperConfiguration
    {
        /// <summary>
        /// Регистриует праивла отображения из сущности в модель и обратно.
        /// </summary>
        /// <param name="services"> Коллекция сервисов. </param>
        /// <returns> Обновленная коллекция сервисов. </returns>
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            return services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
