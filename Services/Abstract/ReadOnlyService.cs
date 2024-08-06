// <copyright file="ReadOnlyService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using DataAccess;
    using Domain.Abstract;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Сервис по чтению данных из БД.
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности. </typeparam>
    public abstract class ReadOnlyService<TEntity> : IReadOnlyService<TEntity>
        where TEntity : class, IIdEntity
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ReadOnlyService{TEntity}"/>.
        /// </summary>
        /// <param name="dataContext"> Контекст бызы данных. </param>
        public ReadOnlyService(DataContext dataContext)
        {
            this.DataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        /// <summary>
        /// Контекст базы данных.
        /// </summary>
        protected DataContext DataContext { get; }

        /// <summary>
        /// Получает все сущности.
        /// </summary>
        /// <param name="track"> Флаг отслеживания сущности. </param>
        /// <returns> Перечисление объектов. </returns>
        public abstract IQueryable<TEntity> GetAll(bool track = false);

        /// <inheritdoc/>
        public TEntity? GetId(Guid id)
        {
            return this.GetAll().SingleOrDefault(entity => entity.Id == id);
        }

        /// <inheritdoc/>
        public async Task<TEntity?> GetIdAsync(Guid id)
        {
            return await this.GetAll().SingleOrDefaultAsync(entity => entity.Id == id);
        }
    }
}
