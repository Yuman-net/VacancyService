// <copyright file="IIdEntity.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Domain.Abstract
{
    /// <summary>
    /// Сущность с идентификатором.
    /// </summary>
    public interface IIdEntity : IIdEntity<Guid>
    {
    }
}
