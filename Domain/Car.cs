// <copyright file="Car.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain
{
    using Domain.Abstract;

    /// <summary>
    /// Автомобиль.
    /// </summary>
    public sealed class Car : IdEntity
    {
        /// <summary>
        /// Марка автомобиля.
        /// </summary>
        public Brand Brand { get; set; }

        /// <summary>
        /// Модель автомобиля.
        /// </summary>
        public Model Model { get; set; }

        /// <summary>
        /// Статус ДТП.
        /// </summary>
        public bool? HasCrached { get; set; }

        /// <summary>
        /// Количество собственников.
        /// </summary>
        public int CountOwners { get; set; }
    }
}
