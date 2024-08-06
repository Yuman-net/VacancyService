// <copyright file="IIdModel{T}.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models.Abstract
{
    /// <summary>
    /// Модель с идентификатором.
    /// </summary>
    /// <typeparam name="T"> Тип идентификатора. </typeparam>
    public interface IIdModel<T>
        where T : struct
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public T Id { get; set; }
    }
}
