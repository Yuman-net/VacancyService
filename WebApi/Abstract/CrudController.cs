// <copyright file="CrudController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Abstract
{
    using System.Net.Mime;
    using AutoMapper;
    using DataAccess;
    using Domain.Abstract;
    using Microsoft.AspNetCore.Mvc;
    using Models.Abstract;
    using Services.Abstract;

    /// <summary>
    /// Контроллер для работы с CRUD методами.
    /// </summary>
    /// <typeparam name="TEntity"> Целевая сущность. </typeparam>
    /// <typeparam name="TInModel"> Входная модель. </typeparam>
    /// <typeparam name="TOutModel"> Выходная модель. </typeparam>
    /// <typeparam name="TService"> Целевой сервис. </typeparam>
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

        /// <summary>
        /// Создание сущности по входной модели.
        /// </summary>
        /// <param name="model"> Входная модель. </param>
        /// <returns>
        /// <c>200</c> и выходная модель.
        /// </returns>
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<IActionResult> Create([FromBody] TInModel model)
        {
            var entity = this.Mapper.Map<TEntity>(model);

            await this.Service.CreateAsync(entity);

            var result = this.Mapper.Map<TOutModel>(entity);

            return this.Ok(result);
        }

        /// <summary>
        /// Обновление сущности.
        /// </summary>
        /// <param name="model"> Модель с обновленными полями. </param>
        /// <returns>
        /// <c>200</c> и модель обновленной сущности.
        /// </returns>
        [HttpPost("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<IActionResult> Update([FromBody] TInModel model)
        {
            var entity = this.Mapper.Map<TEntity>(model);

            _ = await this.Service.UpdateAsync(entity);

            var result = this.Mapper.Map<TOutModel>(entity);

            return this.Ok(result);
        }

        /// <summary>
        /// Удаляет сущность по идентификатору.
        /// </summary>
        /// <param name="id"> Идентификатор сущности. </param>
        /// <returns>
        /// <list type="table">
        /// <item><c>200</c> и идентификатор сущности. </item>
        /// <item><c>404</c> и идентификатор сущности. </item>
        /// </list>
        /// </returns>
        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Guid))]
        public virtual async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await this.Service.DeleteAsyns(id);

            return result ? this.Ok(id) : this.NotFound(id);
        }
    }
}
