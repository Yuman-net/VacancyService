// <copyright file="NamedModel.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models.Abstract
{
    /// <summary>
    /// Модель сущности с назанием.
    /// </summary>
    public abstract class NamedModel : IdModel
    {
        /// <summary>
        /// Имя сущности.
        /// </summary>
        public string Name { get; set; }
    }
}
