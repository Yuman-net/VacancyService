// <copyright file="CarModel.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models
{
    using Models.Abstractions;

    /// <summary>
    /// Автомобиль.
    /// </summary>
    public sealed class CarModel : IdModel
    {
        /// <summary>
        /// Марка автомобиля.
        /// </summary>
        public BrandModel Brand { get; set; }

        /// <summary>
        /// Статус ДТП.
        /// </summary>
        public bool? HasCrached { get; set; }

        /// <summary>
        /// Количество собственников.
        /// </summary>
        public int CountOwners { get; set; }

        /// <summary>
        /// Тип кузова.
        /// </summary>
        public int BodyType { get; set; }

        /// <summary>
        /// Тип трансмиссии.
        /// </summary>
        public int TransmissionType { get; set; }

        /// <summary>
        /// Тип привода.
        /// </summary>
        public int DriveType { get; set; }

        /// <summary>
        /// Тип система кондиционирования.
        /// </summary>
        public int AirConditioningSystemType { get; set; }
    }
}
