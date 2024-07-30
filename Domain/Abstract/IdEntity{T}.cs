// <copyright file="IdEntity{T}.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Abstract
{
    /// <summary>
    /// Сущность с идентификатором.
    /// </summary>
    /// <typeparam name="T"> Тип идентификатора. </typeparam>
    public abstract class IdEntity<T>
        where T : struct
    {
    }
}
