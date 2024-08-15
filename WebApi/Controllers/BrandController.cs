// <copyright file="BrandController.cs" company="Andrey Nikolaev">
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
    /// Контроллер по работе с брендами автомобилей.
    /// </summary>
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route(BrandController.RouteUrl)]
    public sealed class BrandController : CrudController<Brand, BrandModel, BrandModel, IBrandService>
    {
        private const string RouteUrl = "api/brands";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BrandController"/>.
        /// </summary>
        /// <param name="dataContext"> Конекст базы данных. </param>
        /// <param name="service"> Целевой сервис. </param>
        /// <param name="mapper"> Маппер. </param>
        public BrandController(DataContext dataContext, IBrandService service, IMapper mapper)
            : base(dataContext, service, mapper)
        {
        }
    }
}
