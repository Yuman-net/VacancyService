// <copyright file="BrandProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles
{
    using AutoMapper;
    using Domain;
    using Models;

    /// <summary>
    /// Профиль, настраивающий правила отображения из <see cref="Brand"/> и обратно <see cref="BrandModel"/>.
    /// </summary>
    public sealed class BrandProfile : Profile
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BrandProfile"/>.
        /// </summary>
        public BrandProfile()
        {
            this.CreateMap<BrandModel, Brand>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name))
                .ForMember(d => d.Models, ops => ops.MapFrom(s => s.CarModels))
                .ForMember(d => d.Cars, ops => ops.Ignore());

            this.CreateMap<Brand, BrandModel>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Name, ops => ops.MapFrom(s => s.Name))
                .ForMember(d => d.CarModels, ops => ops.MapFrom(s => s.Cars));
        }
    }
}
