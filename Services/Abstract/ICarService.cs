// <copyright file="ICarService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using Domain;

    /// <summary>
    /// Сервис по работе с автомобилями.
    /// </summary>
    public interface ICarService : ICrudService<Car>
    {
    }
}
