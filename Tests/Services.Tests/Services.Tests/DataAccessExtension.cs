// <copyright file="DataAccessExtension.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Методы расширения для DataAccess.
    /// </summary>
    public static class DataAccessExtension
    {
        public static IServiceCollection AddDataContextTest<TDataContext>(this IServiceCollection services, string? databaseName = "Default")
            where TDataContext : DbContext
        {
            return services.AddDbContext<TDataContext>(delegate(DbContextOptionsBuilder options)
            {
                options.UseInMemoryDatabase(databaseName ?? $"TestDatabase_{Guid.NewGuid()}");
            });
        }

        public static IServiceCollection AddTestDataContext<TDataContext>(this IServiceCollection services, string? databaseName = null, bool showErrors = false, bool showFullLog = false, Action<string>? logAction = null, LogLevel minimumLogLevel = LogLevel.Trace) where TDataContext : DbContext
        {
            string databaseName2 = databaseName;
            Action<string> logAction2 = logAction;
            return services.AddDbContext<TDataContext>(delegate(DbContextOptionsBuilder options)
            {
                options.UseInMemoryDatabase(databaseName2 ?? $"TestDatabase_{Guid.NewGuid()}").EnableDetailedErrors(showErrors).EnableSensitiveDataLogging(showFullLog)
                    .LogTo(logAction2 ?? new Action<string>(Console.WriteLine), minimumLogLevel);
            });
        }
    }
}
