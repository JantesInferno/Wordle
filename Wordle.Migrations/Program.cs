using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wordle.Data;
using Wordle.Data.Data.Contexts;

var dbPath = Path.Combine("C:", "Users", "Jens", "source", "repos", "Wordle", "Wordle.Data", "wordle.db");
var connectionString = $"Data Source={dbPath}";

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<WordleDbContext>(options =>
            options.UseSqlite(connectionString));
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<WordleDbContext>();
    dbContext.Database.Migrate();
}