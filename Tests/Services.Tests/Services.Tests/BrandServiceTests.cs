// <copyright file="BrandServiceTests.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Tests
{
    using DataAccess;
    using Domain;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Abstract;

    public sealed class BrandServiceTests
    {
        private DataContext dataContext;

        private IBrandService service;

        [SetUp]
        public void SetUp()
        {
            var services = new ServiceCollection();
            services.AddScoped<IBrandService, BrandService>()
                .AddDataContextTest<DataContext>();

            var serviceProvider = services.BuildServiceProvider();
            this.service = serviceProvider.GetService<IBrandService>() !;
            this.dataContext = serviceProvider.GetService<DataContext>() !;
        }

        [TearDown]
        public void TearDown()
        {
            this.dataContext.Database.EnsureDeleted();
            this.dataContext.ChangeTracker.Clear();
            this.dataContext.Dispose();
        }

        [Test]
        public async Task CrateNewBrand_CrateAndSaveAsync_ObjectsAreSame()
        {
            // Arrange
            var brand = new Brand
            {
                Name = "Ford",
            };

            // Act
            var result = await this.service.CreateAsync(brand);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.Not.EqualTo(default));
            Assert.That(result.Name, Is.EqualTo("Ford"));
        }

        [Test]
        public async Task UpdateBrand_UpdateAndSaveAsync_ObjectsAreSame()
        {
            // Arrange
            var brand = new Brand
            {
                Id = Guid.NewGuid(),
                Name = "Ford",
            };

            this.dataContext.Add(brand);
            this.dataContext.SaveChanges();
            this.dataContext.ChangeTracker.Clear();

            var updateBrand = new Brand
            {
                Id = brand.Id,
                Name = "Audi",
            };

            // Act
            await this.service.UpdateAsync(updateBrand);

            // Assert
            var result = this.dataContext.Brands.SingleOrDefault();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Audi"));
            Assert.That(result.Id, Is.Not.EqualTo(default));
        }
    }
}