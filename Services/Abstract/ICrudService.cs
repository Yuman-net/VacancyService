// <copyright file="ICrudService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using Domain.Entities.Abstractions;

    /// <summary>
    /// Сервис по CRUD-методам.
    /// </summary>
    /// <typeparam name="TEntity"> Тип целевой сущности. </typeparam>
    public interface ICrudService<TEntity> : IReadOnlyService<TEntity>
        where TEntity : class, IIdEntity
    {
        /// <summary>
        /// Создание сущности.
        /// </summary>
        /// <param name="entity"> Получаемая модель сущности. </param>
        /// <param name="withId"> Флаг, который указывает передобавляется объект (true) или добавляется как новый (false). </param>
        /// <returns> Созданная сущность. </returns>
        public Task<TEntity> CreateAsync(TEntity entity, bool withId = false);

        /// <summary>
        /// Обновляет сущность.
        /// </summary>
        /// <param name="entity"> Модель с обновленными свойствами. </param>
        /// <returns> Обноленная модель. </returns>
        public Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// Удаление сущности по идентификатору.
        /// </summary>
        /// <param name="id"> Идентификатор сущности. </param>
        /// <returns>
        /// <list type="bullet">
        /// <item><c>true</c> в случае успеха. </item>
        /// <item><c>false</c> в противном случае. </item>
        /// </list>
        /// </returns>
        public Task<bool> DeleteAsyns(Guid id);

        /// <summary>
        /// Удаление сущности.
        /// </summary>
        /// <param name="entity"> Целевая сущность. </param>
        /// <returns>
        /// <list type="bullet">
        /// <item><c>true</c> в случае успеха. </item>
        /// <item><c>false</c> в противном случае. </item>
        /// </list>
        /// </returns>
        public bool Delete(TEntity entity);
    }
}
