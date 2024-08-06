// <copyright file="Model.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain
{
    using Domain.Abstract;

    /// <summary>
    /// Модель автомобиля.
    /// </summary>
    public sealed class Model : NamedEntity
    {
        /// <summary>
        /// Марка автомобиля.
        /// </summary>
        public Brand Brand { get; set; }
    }
}
