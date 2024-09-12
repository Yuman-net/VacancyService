// <copyright file="CarConfiguration.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace DataAccess.Configuration
{
    using Abstract.DataAccess;
    using Domain;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    ///  Конфигуратор сущности <see cref="Car"/>.
    /// </summary>
    public sealed class CarConfiguration : IdEntityConfiguration<Car>
    {
        /// <inheritdoc/>
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);

            builder.Property(entity => entity.HasCrached);
            builder.Property(entity => entity.CountOwners);
            builder.Property(entity => entity.BodyType);
            builder.Property(entity => entity.DriveType);
            builder.Property(entity => entity.TransmissionType);

            builder.HasOne(entity => entity.Brand).WithMany();

            builder.Navigation(entity => entity.Brand).AutoInclude();
        }
    }
}
