using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using LSAppointmentManager.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace LSAppointmentManager.Migrator
{
    public class Program
    {
        public static string connectionString { get; set; } = "Data Source=MAX;Database=ls_appointment;Integrated Security=sspi;TrustServerCertificate=True;";
        public static void Main(string[] args)
        {

            Console.WriteLine(">> Current connection string is:");
            Console.WriteLine();
            Console.WriteLine($"{connectionString}");
            Console.WriteLine();
            Console.WriteLine(">> Do you want to change it? (Press ENTER to stay with the same connection)");
            Console.WriteLine();
            var internalConnectionString = Console.ReadLine();
            Console.WriteLine(">> Processing...");

            using (var serviceProvider = CreateServices(string.IsNullOrEmpty(internalConnectionString) ? connectionString : internalConnectionString))
            using (var scope = serviceProvider.CreateScope())
            {
                // Put the database update into a scope to ensure
                // that all resources will be disposed.
                UpdateDatabase(scope.ServiceProvider);
            }
        }
        private static ServiceProvider CreateServices(string connectionString)
        {
            return new ServiceCollection()
                .AddMigrationSQLServerServices(connectionString)
                .BuildServiceProvider(false);
        }

        /// <summary>
        /// Update the database
        /// </summary>
        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            // Instantiate the runner
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            // Execute the migrations
            runner.MigrateUp();
        }

    }
}
