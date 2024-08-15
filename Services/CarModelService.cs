// <copyright file="CarModelService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services
{
    using DataAccess;
    using Domain;
    using Microsoft.EntityFrameworkCore;
    using Services.Abstract;

    /// <summary>
    /// Сервис по работе с моделями автомобилей.
    /// </summary>
    public sealed class CarModelService : CrudService<ModelType>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarModelService"/>.
        /// </summary>
        /// <param name="dataContext"> Контекс базы данных. </param>
        public CarModelService(DataContext dataContext)
            : base(dataContext)
        {
        }

        /// <inheritdoc/>
        public override IQueryable<ModelType> GetAll(bool track = false)
        {
            var query = this.DataContext.Models
                .AsSplitQuery();

            return track
                ? query
                : query.AsNoTracking();
        }
    }
}
