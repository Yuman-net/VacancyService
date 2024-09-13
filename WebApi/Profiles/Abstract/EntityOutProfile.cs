// <copyright file="EntityOutProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles.Abstract
{
    using AutoMapper;
    using Domain.Entities.Abstractions;
    using Models.Abstractions;

    /// <summary>
    /// Профиль для настройки сущностией с идентификатором.
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности. </typeparam>
    /// <typeparam name="TOutModel"> Тип выходной модели. </typeparam>
    public abstract class EntityOutProfile<TEntity, TOutModel> : Profile
        where TEntity : class, IIdEntity
        where TOutModel : IdModel
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="EntityOutProfile{TEntity, TOutModel}"/>.
        /// </summary>
        protected EntityOutProfile()
        {
            this.OutputMap = this.CreateMap<TEntity, TOutModel>()
                .ForMember(d => d.Id, ops => ops.MapFrom(s => s.Id));
        }

        /// <summary>
        /// Выражение, описывающее правила отображения из сущности на выходную модель.
        /// </summary>
        protected IMappingExpression<TEntity, TOutModel> OutputMap { get; set; }

    }
}
