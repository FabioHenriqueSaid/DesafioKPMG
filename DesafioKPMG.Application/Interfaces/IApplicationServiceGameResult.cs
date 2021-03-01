using DesafioKPMG.Application.Dtos;
using System.Collections.Generic;

namespace DesafioKPMG.Application.Interfaces
{
    public interface IApplicationServiceGameResult
    {
        void Add(GameResultDto gameResultDto);
        IEnumerable<GameResultDto> GetAll();
    }
}
