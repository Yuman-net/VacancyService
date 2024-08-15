// <copyright file="CarModelController.cs" company="Andrey Nikolaev">
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
    /// Контроллер по работе с моделями автомобиля.
    /// </summary>
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route(CarModelController.RouteUrl)]
    public sealed class CarModelController : CrudController<ModelType, CarModelModel, CarModelModel, ICarModelService>
    {
        private const string RouteUrl = "api/car-models";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarModelController"/>.
        /// </summary>
        /// <param name="dataContext"> Конекст базы данных. </param>
        /// <param name="service"> Целевой сервис. </param>
        /// <param name="mapper"> Маппер. </param>
        public CarModelController(DataContext dataContext, ICarModelService service, IMapper mapper)
            : base(dataContext, service, mapper)
        {
        }
    }
}
