using System;

namespace DesafioKPMG.Domain.Entities
{
    public class Leaderboard  : Base
    {
        public long PlayerId { get; set; }
        public long Balance { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}