using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore.TestUtilities;

public class SqlServerTestHelpers : TestHelpers
{
    protected SqlServerTestHelpers()
    {
    }

    public static SqlServerTestHelpers Instance { get; } = new();

    public override IServiceCollection AddProviderServices(IServiceCollection services)
        => services.AddEntityFrameworkSqlServer();

    public override DbContextOptionsBuilder UseProviderOptions(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(new SqlConnection("Database=DummyDatabase"));
}
