// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Customer.Sample;

public class Program
{
    private static IConfiguration Configuration { get; set; } = null!;

    public static async Task Main(string[] args)
    {
        try
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json", optional: false)
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: false)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
            
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();
            Log.Information("Starting up...");

            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            
            var app = serviceProvider.GetRequiredService<ISampleClient>();
            
            //Start integration function here, supplying the OrganizationId for target Org 
            await app.Run("OrganizationId GUID here");

            Log.Information("Shutting down...");
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application terminated unexpectedly");
        }
        finally
        {
            await Log.CloseAndFlushAsync();
        }
    }
    private static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddSingleton(Configuration);
        services.AddOptions();
        services.Configure<AuthenticationConfig>(Configuration.GetSection("AuthenticationConfig"));
        
        services.AddSingleton<IAuthenticationService, AuthenticationService>();
        services.AddSingleton<ISampleClient, SampleClient>();
        
        return services;
    }
}