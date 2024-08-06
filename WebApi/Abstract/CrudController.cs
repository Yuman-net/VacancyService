// <copyright file="CrudController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Abstract
{
    using System.Net.Mime;
    using AutoMapper;
    using DataAccess;
    using Domain;
    using Domain.Abstract;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Metadata.Conventions;
    using Models;
    using Models.Abstract;
    using Services.Abstract;

    /// <summary>
    /// Контроллер для работы с CRUD методами.
    /// </summary>
    /// <typeparam name="TEntity"> Целевая сущность. </typeparam>
    /// <typeparam name="TInModel"> Входная модель. </typeparam>
    /// <typeparam name="TOutModel"> Выходная модель. </typeparam>
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]

    public abstract class CrudController<TEntity, TInModel, TOutModel, TService>
        : ReadOnlyController<TEntity, TInModel, TOutModel, TService>
        where TEntity : class, IIdEntity
        where TService : class, ICrudService<TEntity>
        where TInModel : class, IIdModel
        where TOutModel : class, IIdModel
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CrudController{TEntity, TInModel, TOutModel, TService}"/>.
        /// </summary>
        /// <param name="dataContext"> Контекст базы данных. </param>
        /// <param name="service"> Целевой сервис. </param>
        /// <param name="mapper"> Маппер. </param>
        protected CrudController(DataContext dataContext, TService service, IMapper mapper)
            : base(dataContext, service, mapper)
        {
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] TInModel model)
        {
            var entity = this.Mapper.Map<TEntity>(model);

            await this.Service.CreateAsync(entity);

            return this.Ok(entity);
        }
    }
}
