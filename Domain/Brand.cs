// <copyright file="Brand.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain
{
    using Domain.Abstract;

    /// <summary>
    /// Марка/бренд автомобиля.
    /// </summary>
    public sealed class Brand : NamedEntity
    {
        /// <summary>
        /// Коллекция автомобилей.
        /// </summary>
        public ISet<Car> Cars { get; set; } = new HashSet<Car>();

        /// <summary>
        /// Коллекция моделей.
        /// </summary>
        public ISet<Model> Models { get; set; } = new HashSet<Model>();
    }
}
