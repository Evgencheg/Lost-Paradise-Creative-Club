#if TOOLS

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SQLitePCL;

// ReSharper disable UnusedType.Global

namespace Content.Server.Database;

public sealed class DesignTimeContextFactorySqlite : IDesignTimeDbContextFactory<SqliteServerDbContext>
{
    public SqliteServerDbContext CreateDbContext(string[] args)
    {
#if !USE_SYSTEM_SQLITE
        raw.SetProvider(new SQLite3Provider_e_sqlite3());
#endif

        var optionsBuilder = new DbContextOptionsBuilder<SqliteServerDbContext>();
        optionsBuilder.UseSqlite("Data Source=:memory:");
        return new SqliteServerDbContext(optionsBuilder.Options);
    }
}

#endif
