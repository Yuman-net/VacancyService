// <copyright file="CarProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles
{
    using AutoMapper;
    using Domain;
    using Domain.Enums;
    using Models;

    /// <summary>
    /// Профиль, настраивающий правила отображения из <see cref="Car"/> в <see cref="Models.CarModel"/> и обратно.
    /// </summary>
    public sealed class CarProfile : Profile
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarProfile"/>.
        /// </summary>
        public CarProfile()
        {
            this.CreateMap<Models.CarModel, Car>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id))
                .ForMember(d => d.Brand, ops => ops.MapFrom(s => s.Brand))
                .ForMember(d => d.DriveType, ops => ops.MapFrom(s => (DriveTypeEnum)s.DriveType))
                .ForMember(d => d.BodyType, ops => ops.MapFrom(s => (BodyTypeEnum)s.BodyType))
                .ForMember(d => d.TransmissionType, ops => ops.MapFrom(s => (TransmissionTypeEnum)s.TransmissionType))
                .ForMember(d => d.HasCrached, ops => ops.MapFrom(s => s.HasCrached))
                .ForMember(d => d.CountOwners, ops => ops.MapFrom(s => s.CountOwners))
                .ReverseMap();
        }
    }
}
