// <copyright file="DataContext.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace DataAccess
{
    using Domain;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Контекст базы данных.
    /// </summary>
    public sealed class DataContext : DbContext
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DataContext"/>.
        /// </summary>
        /// <param name="options"> Опции контекста. </param>
        public DataContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Автоиобили.
        /// </summary>
        public DbSet<Car> Cars { get; set; }

        /// <summary>
        /// Марки.
        /// </summary>
        public DbSet<Brand> Brands { get; set; }

        /// <summary>
        /// Модели.
        /// </summary>
        public DbSet<Model> Models { get; set; }
    }
}
