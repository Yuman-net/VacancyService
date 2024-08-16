// <copyright file="ModelTypeProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles
{
    using AutoMapper;
    using Domain;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Models;

    /// <summary>
    /// Профиль для настройки отображения модели автомобиля.
    /// </summary>
    public class ModelTypeProfile : Profile
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ModelTypeProfile"/>.
        /// </summary>
        public ModelTypeProfile()
        {
            this.CreateMap<ModelTypeModel, ModelType>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name));

            this.CreateMap<ModelType, ModelTypeModel>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name));
        }
    }
}
