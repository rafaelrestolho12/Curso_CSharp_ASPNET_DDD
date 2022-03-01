using Microsoft.EntityFrameworkCore;

namespace Infra.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> optionsBuilder) : base(optionsBuilder)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(StringConnectionConfig());
        }
        public static string StringConnectionConfig()
        {
            string connectionString = @"Data Source=RAFAEL-PC\SQLEXPRESS;
                                        Initial Catalog=DDDTeste;
                                        User id=sa;
                                        Password=123456;";
            return connectionString;
        }
    }
}
