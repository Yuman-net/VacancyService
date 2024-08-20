// <copyright file="ModelTypeProfileTests.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Tests.Profiles
{
    using WebApi.Profiles;
    using WebApi.Tests.Abstract;

    public sealed class ModelTypeProfileTests : BaseProfileTest<ModelTypeProfile>
    {
        [Test]
        public void Mappings_IsValid()
        {
            // act & assert
            this.mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
