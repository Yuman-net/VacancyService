// <copyright file="ModelConfiguration.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace DataAccess.Configuration
{
    using DataAccess.Abstract;
    using Domain;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Конфигуратор сущности <see cref="Model"/>.
    /// </summary>
    public sealed class ModelConfiguration : EntityConfiguration<Model>
    {
        /// <inheritdoc/>
        public override void Configure(EntityTypeBuilder<Model> builder)
        {
            base.Configure(builder);
        }
    }
}
