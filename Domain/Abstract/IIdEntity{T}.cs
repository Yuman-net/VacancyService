// <copyright file="IIdEntity{T}.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Abstract
{
    /// <summary>
    /// Сущность с идентификатором.
    /// </summary>
    /// <typeparam name="T"> Тип идентификатора. </typeparam>
    public interface IIdEntity<T>
        where T : struct
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        public T Id { get; set; }
    }
}
