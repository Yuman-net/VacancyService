// <copyright file="BaseProfileTest.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Tests.Abstract
{
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;
    using WebApi.Profiles;

    /// <summary>
    /// Базовый класс для настройки тестов по маппигу.
    /// </summary>
    /// <typeparam name="TProfile"> Целевой профиль. </typeparam>
    public abstract class BaseProfileTest<TProfile>
        where TProfile : Profile
    {
        /// <summary>
        /// Маппер.
        /// </summary>
        protected readonly IMapper mapper;

        protected IServiceCollection services;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BaseProfileTest{TProfile}"/>.
        /// </summary>
        public BaseProfileTest()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(BrandProfile));
            var serviceProvider = services.BuildServiceProvider();
            this.mapper = serviceProvider?.GetService<IMapper>();
        }
    }
}
