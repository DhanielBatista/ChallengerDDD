using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IMusicApplicationService
    {
        void Add(MusicsDto musicsDto);
        void Update(MusicsDto musicsDto);
        void Remove(MusicsDto musicsDto);
        IEnumerable<MusicsDto> GetAll();
        MusicsDto GetById(int id);
    }
}
