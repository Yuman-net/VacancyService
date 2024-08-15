// <copyright file="IBrandService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using Domain;

    /// <summary>
    /// Сервис по работе с автомобильным брендом.
    /// </summary>
    public interface IBrandService : ICrudService<Brand>
    {
    }
}
