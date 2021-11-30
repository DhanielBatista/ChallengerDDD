using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.MappersInterface
{
    public interface IMusicsMapper
    {
        Musics MapperDtoToEntity(MusicsDto musicsDto);
        IEnumerable<MusicsDto> MapperListMusicsDto(IEnumerable<Musics> musics);
        MusicsDto MapperEntityToDto(Musics musics);
    }
}
