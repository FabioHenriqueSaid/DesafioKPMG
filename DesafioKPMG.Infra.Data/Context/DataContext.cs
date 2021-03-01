using DesafioKPMG.Domain.Entities;
using DesafioKPMG.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
namespace DesafioKPMG.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<GameResult> GameResults { get; set; }
        public DbSet<Leaderboard> Leaderboards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GameResultMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}