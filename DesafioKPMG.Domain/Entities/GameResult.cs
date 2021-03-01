using System;

namespace DesafioKPMG.Domain.Entities
{
    public class GameResult : Base
    {
        public long GameId { get;  set; }
        public long PlayerId { get;  set; }    
        public long Win { get;  set; }
        public DateTime TimeStamp { get;  set; }
    }
}