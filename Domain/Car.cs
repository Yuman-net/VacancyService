﻿// <copyright file="Car.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain
{
    using Domain.Entities.Abstractions;
    using Domain.Enums;

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
        public BodyTypeEnum BodyType { get; set; }

        /// <summary>
        /// Тип трансмиссии.
        /// </summary>
        public TransmissionTypeEnum TransmissionType { get; set; }

        /// <summary>
        /// Тип привода.
        /// </summary>
        public DriveTypeEnum DriveType { get; set; }

        /// <summary>
        /// Тип системы кондиционирования.
        /// </summary>
        public AirConditioningSystemType AirConditioningSystemType { get; set; }
    }
}
