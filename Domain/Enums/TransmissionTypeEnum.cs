// <copyright file="TransmissionTypeEnum.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Enums
{
    /// <summary>
    /// Тип коробки передач.
    /// </summary>
    public enum TransmissionTypeEnum
    {
        /// <summary>
        /// Механическая коробка.
        /// </summary>
        Manual = 0,

        /// <summary>
        /// Автоматическая коробка.
        /// </summary>
        Automatic = 1,

        /// <summary>
        /// Роботизированная коробка.
        /// </summary>
        Robotic = 2,

        /// <summary>
        /// Вариатор.
        /// </summary>
        VariableSpeedDrive = 3,
    }
}
