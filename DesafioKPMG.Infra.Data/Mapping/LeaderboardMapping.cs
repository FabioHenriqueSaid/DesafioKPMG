using DesafioKPMG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioKPMG.Infra.Data.Mapping
{
    public class LeaderboardMapping : IEntityTypeConfiguration<Leaderboard>
    {
        public void Configure(EntityTypeBuilder<Leaderboard> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Balance)
                .IsRequired();

            builder.Property(c => c.PlayerId)
                .IsRequired();
        }
    }
}
