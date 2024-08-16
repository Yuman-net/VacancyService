// <copyright file="BrandProfileTests.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Tests.Profiles
{
    using WebApi.Profiles;
    using WebApi.Tests.Abstract;

    /// <summary>
    /// Тесты на маппинг автомобильного бренда.
    /// </summary>
    public sealed class BrandProfileTests : BaseProfileTest<BrandProfile>
    {
        [Test]
        public void Mappings_IsValid()
        {
            // Act & Assert
            this.mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
