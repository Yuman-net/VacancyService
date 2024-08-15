// <copyright file="CarModelProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles
{
    using AutoMapper;
    using Domain;
    using Models;

    /// <summary>
    /// Профиль для настройки отображения модели автомобиля.
    /// </summary>
    public class CarModelProfile : Profile
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarModelProfile"/>.
        /// </summary>
        public CarModelProfile()
        {
            this.CreateMap<CarModelModel, Domain.ModelType>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name));
                //.ForMember(d => d.Brand, ops => ops.Ignore());
        }
    }
}
