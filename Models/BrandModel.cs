// <copyright file="BrandModel.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Models
{
    using Models.Abstract;

    /// <summary>
    /// Марка автомобиля.
    /// </summary>
    public sealed class BrandModel : NamedModel
    {
        /// <summary>
        /// Коллекция моделей у марки.
        /// </summary>
        public ISet<ModelTypeModel> CarModels { get; set; } = new HashSet<ModelTypeModel>();
    }
}
