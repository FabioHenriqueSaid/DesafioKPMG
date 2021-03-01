using System;

namespace DesafioKPMG.Application.Dtos
{
    public class GameResultDto
    {
        public int Id { get; set; }
        public long GameId { get; set; }
        public long PlayerId { get; set; }
        public long Win { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}