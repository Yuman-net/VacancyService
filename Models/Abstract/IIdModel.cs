// <copyright file="IIdModel.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models.Abstract
{
    /// <summary>
    /// Модель с иденификатором.
    /// </summary>
    public interface IIdModel : IIdModel<Guid>
    {
    }
}
