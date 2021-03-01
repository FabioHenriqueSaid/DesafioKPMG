using System;
namespace DesafioKPMG.Application.Dtos
{
    public class LeaderboardDto
    {
        public int Id { get; set; }
        public long PlayerId { get; set; }
        public long Balance { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
