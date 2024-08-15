// <copyright file="ICarModelService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Abstract
{
    using Domain;

    /// <summary>
    /// Сервис по работае с моделями автомобиля.
    /// </summary>
    public interface ICarModelService : ICrudService<ModelType>
    {
    }
}
