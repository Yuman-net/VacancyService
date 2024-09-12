// <copyright file="BrandConfiguration.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace DataAccess.Configuration
{
    using DataAccess.Abstractions;
    using Domain;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Конфигуратор сущности <see cref="Brand"/>.
    /// </summary>
    public sealed class BrandConfiguration : EntityConfiguration<Brand>
    {
        /// <inheritdoc/>
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            base.Configure(builder);

            builder.HasMany(entity => entity.Models).WithOne();
        }
    }
}
