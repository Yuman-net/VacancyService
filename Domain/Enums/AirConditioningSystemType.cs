// <copyright file="AirConditioningSystemType.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Enums
{
    /// <summary>
    /// Тип системы кондиционирования.
    /// </summary>
    public enum AirConditioningSystemType
    {
        /// <summary>
        /// Отсутсвует.
        /// </summary>
        None = 0,

        /// <summary>
        /// Кондиционер.
        /// </summary>
        AirConditioner = 1,

        /// <summary>
        /// Климатическая система.
        /// </summary>
        SingleZoneClimateSystem = 2,

        /// <summary>
        /// Многозонная климатическая система.
        /// </summary>
        MultiZoneClimateSystem = 3,
    }
}
