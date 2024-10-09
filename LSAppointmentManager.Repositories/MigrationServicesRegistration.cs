using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Repositories
{
    public static class MigrationServicesRegistration
    {
        public static IServiceCollection AddMigrationSQLServerServices(this IServiceCollection services, string connectionString)
        {
            return services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    // Add SQLite support to FluentMigrator
                    .AddSqlServer()
                    // Set the connection string
                    .WithGlobalConnectionString(connectionString)
                    // Define the assembly containing the migrations
                    .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations()
                    )
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole());

        }

        public static IServiceCollection AddMigrationMySQLServerServices(this IServiceCollection services, string connectionString)
        {
            return services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    // Add SQLite support to FluentMigrator
                    .AddMySql8()
                    // Set the connection string
                    .WithGlobalConnectionString(connectionString)
                    // Define the assembly containing the migrations
                    .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations()
                    )
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole());

        }
    }
}
