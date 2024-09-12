// <copyright file="Brand.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain
{
    using Domain.Entities.Abstractions;

    /// <summary>
    /// Марка/бренд автомобиля.
    /// </summary>
    public sealed class Brand : NamedEntity
    {
        /// <summary>
        /// Коллекция моделей.
        /// </summary>
        public ISet<ModelType> Models { get; set; } = new HashSet<ModelType>();
    }
}
