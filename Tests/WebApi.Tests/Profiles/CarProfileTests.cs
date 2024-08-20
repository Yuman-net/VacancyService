// <copyright file="CarProfileTests.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Tests.Profiles
{
    using Domain;
    using Domain.Enums;
    using Models;
    using WebApi.Profiles;
    using WebApi.Tests.Abstract;

    /// <summary>
    /// Тесты на профили из <see cref="Car"/> в <see cref="CarModel"/> и обратно.
    /// </summary>
    public class CarProfileTests : BaseProfileTest<CarProfile>
    {
        [Test]
        public void Mappings_IsValid()
        {
            // act & assert
            this.mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        [Test]
        public void CarToCarModel_ObjectsAreSame()
        {
            // Arrange
            var brand = new Brand
            {
                Id = Guid.NewGuid(),
                Models = new HashSet<ModelType>()
                {
                    new ModelType
                    {
                        Id = Guid.NewGuid(),
                        Name = "Focus 3",
                    },
                },
                Name = "Ford",
            };

            var car = new Car
            {
                AirConditioningSystemType = AirConditioningSystemType.MultiZoneClimateSystem,
                BodyType = BodyTypeEnum.Wagon,
                Brand = brand,
                CountOwners = 1,
                DriveType = DriveTypeEnum.Front,
                HasCrached = true,
                TransmissionType = TransmissionTypeEnum.Robotic,
                Id = Guid.NewGuid(),
            };

            // Act
            var model = this.mapper.Map<CarModel>(car);

            // Assert
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Id, Is.Not.EqualTo(default));
            Assert.That(model.HasCrached, Is.True);
            Assert.That(model.BodyType, Is.EqualTo(1));
            Assert.That(model.TransmissionType, Is.EqualTo(2));
            Assert.That(model.CountOwners, Is.EqualTo(1));
            Assert.That(model.Brand, Is.Not.Null);
            Assert.That(model.Brand.Name, Is.EqualTo("Ford"));

            var brandModel = model.Brand.CarModels.SingleOrDefault();

            Assert.That(model.Brand.CarModels, Has.Count.EqualTo(1), message: "Count models");
            Assert.That(brandModel, Is.Not.Null);
            Assert.That(brandModel.Name, Is.EqualTo("Focus 3"));
        }
    }
}