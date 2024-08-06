// <copyright file="CarService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services
{
    using DataAccess;
    using Domain;
    using Microsoft.EntityFrameworkCore;
    using Services.Abstract;

    /// <summary>
    /// Сервис по работе с автомоблями.
    /// </summary>
    public sealed class CarService : CrudService<Car>, ICarService
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarService"/>.
        /// </summary>
        /// <param name="dataContext"> Конекст базы данных. </param>
        public CarService(DataContext dataContext)
            : base(dataContext)
        {
        }

        /// <inheritdoc/>
        public override IQueryable<Car> GetAll(bool track = false)
        {
            var query = this.DataContext.Cars
                .AsSingleQuery();

            return track
                ? query
                : query.AsNoTracking();
        }
    }
}
