// <copyright file="IReadOnlyService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using Domain.Entities.Abstractions;

    /// <summary>
    /// Сервис по чтению данных из БД.
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности. </typeparam>
    public interface IReadOnlyService<TEntity>
        where TEntity : class, IIdEntity
    {
        /// <summary>
        /// Получает сущность по идентификатору.
        /// </summary>
        /// <param name="id"> Идентификатор сущности. </param>
        /// <returns> Найденная сущность. </returns>
        public TEntity? GetId(Guid id);

        /// <summary>
        /// Получает асинхронно сущность по идентификатору.
        /// </summary>
        /// <param name="id"> Идентификатор сущности. </param>
        /// <returns> Найденная сущность. </returns>
        public Task<TEntity?> GetIdAsync(Guid id);

        /// <summary>
        /// Получение всех сущностей.
        /// </summary>
        /// <param name="track"> Статус необходимости отслеживания сущности. </param>
        /// <returns> Коллекция сущностей. </returns>
        public IQueryable<TEntity> GetAll(bool track = false);
    }
}
