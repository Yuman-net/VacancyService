// <copyright file="CarController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Controllers
{
    using AutoMapper;
    using DataAccess;
    using Domain;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services.Abstract;
    using WebApi.Abstract;

    /// <summary>
    /// Контроллер для работы с автомбилями.
    /// </summary>
    [ApiController]
    [Route(CarController.Route)]
    public sealed class CarController : CrudController<Car, CarModel, CarModel, ICarService>
    {
        private const string Route = "api/cars";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarController"/>.
        /// </summary>
        /// <param name="dataContext"></param>
        /// <param name="service"></param>
        /// <param name="mapper"></param>
        public CarController(DataContext dataContext, ICarService service, IMapper mapper)
            : base(dataContext, service, mapper)
        {
        }
    }
}
