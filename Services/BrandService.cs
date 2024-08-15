// <copyright file="BrandService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services
{
    using DataAccess;
    using Domain;
    using Microsoft.EntityFrameworkCore;
    using Services.Abstract;

    /// <summary>
    /// Сервис по работе с брендом автомобиля.
    /// </summary>
    public sealed class BrandService : CrudService<Brand>, IBrandService
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BrandService"/>.
        /// </summary>
        /// <param name="dataContext"> Контекст базы данных. </param>
        public BrandService(DataContext dataContext)
            : base(dataContext)
        {
        }

        /// <inheritdoc/>
        public override IQueryable<Brand> GetAll(bool track = false)
        {
            var query = this.DataContext.Brands
                .Include(s => s.Models)
                .AsSplitQuery();

            return track ? query : query.AsNoTracking();
        }
    }
}
