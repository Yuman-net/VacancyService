// <copyright file="CarController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Controllers
{
    using System.Net.Mime;
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
    [Produces(MediaTypeNames.Application.Json)]
    [Route(CarController.RouteUrl)]
    public sealed class CarController : CrudController<Car, CarModel, CarModel, ICarService>
    {
        private const string RouteUrl = "api/cars";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarController"/>.
        /// </summary>
        /// <param name="dataContext"> Конекст базы данных. </param>
        /// <param name="service"> Целевой сервис. </param>
        /// <param name="mapper"> Маппер. </param>
        public CarController(DataContext dataContext, ICarService service, IMapper mapper)
            : base(dataContext, service, mapper)
        {
        }
    }
}
