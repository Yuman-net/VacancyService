// <copyright file="ReadOnlyController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Abstract
{
    using System.Linq.Expressions;
    using AutoMapper;
    using DataAccess;
    using Domain.Abstract;
    using Microsoft.AspNetCore.Mvc;
    using Models.Abstract;
    using Services.Abstract;

    /// <summary>
    /// Котроллер для операций на чтение.
    /// </summary>
    /// <typeparam name="TEntity"> Целевая сущность. </typeparam>
    /// <typeparam name="TInModel"> Входная модель. </typeparam>
    /// <typeparam name="TOutModel"> Выходная модель. </typeparam>
    /// <typeparam name="TService"> Целевой сервис. </typeparam>
    [ApiController]
    public abstract class ReadOnlyController<TEntity, TInModel, TOutModel, TService> : ControllerBase
        where TEntity : class, IIdEntity
        where TService : class, IReadOnlyService<TEntity>
        where TInModel : class, IIdModel
        where TOutModel : class, IIdModel
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ReadOnlyController{TEntity, TInModel, TOutModel, TService}"/>.
        /// </summary>
        /// <param name="dataContext"> Контекст базы данных. </param>
        /// <param name="service"> Целевой сервис. </param>
        /// <param name="mapper"> Маппер. </param>
        protected ReadOnlyController(DataContext dataContext, TService service, IMapper mapper)
        {
            this.DataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            this.Service = service ?? throw new ArgumentNullException(nameof(service));
            this.Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Целевой сервис.
        /// </summary>
        public TService Service { get; }

        /// <summary>
        /// Маппер.
        /// </summary>
        public IMapper Mapper { get; }

        /// <summary>
        /// Контекст базы данных.
        /// </summary>
        protected DataContext DataContext { get; }

        /// <summary>
        /// Возвращает сущность по идентификатору.
        /// </summary>
        /// <param name="id"> Идентифкатор сущности. </param>
        /// <returns>
        /// <list type="table">
        /// <item><c>200</c> и сущность. </item>
        /// <item><c>400</c> и идентификатор сущности. </item>
        /// </list>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Guid))]
        public async virtual Task<IActionResult> GetId([FromRoute] Guid id)
        {
            var entity = await this.Service.GetIdAsync(id);

            if (entity is null)
            {
                return this.BadRequest(id);
            }

            var model = this.Mapper.Map<TOutModel>(entity);

            return this.Ok(model);
        }

        /// <summary>
        /// Получает все сущности.
        /// </summary>
        /// <returns>
        /// <c>200</c> и коллекция сущностей.
        /// </returns>
        [HttpGet("get-all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual IActionResult Index()
        {
            return this.Ok(this.Mapper.ProjectTo(this.Service.GetAll(), null, Array.Empty<Expression<Func<TOutModel, object>>>()));
        }
    }
}
