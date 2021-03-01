using DesafioKPMG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioKPMG.Infra.Data.Mapping
{
    public class GameResultMapping : IEntityTypeConfiguration<GameResult>
    {
        public void Configure(EntityTypeBuilder<GameResult> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.GameId)
                .IsRequired();

            builder.Property(c => c.PlayerId)
                .IsRequired();

            builder.Property(c => c.Win)
              .IsRequired();

            builder.Property(c => c.TimeStamp)
               .IsRequired();
        }
    }
}
