using Application.Dtos;
using Application.Interfaces.MappersInterface;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Application.Mapper
{
    public class MapperMusics : IMusicsMapper
    {
        public Musics MapperDtoToEntity(MusicsDto musicsDto)
        {
            var musics = new Musics()
            {
                Id = musicsDto.Id,
                Name = musicsDto.Name,
                Genre = musicsDto.Genre,
                ReleaseYear = musicsDto.ReleaseYear,
            };
            return musics;
        }

        public MusicsDto MapperEntityToDto(Musics musics)
        {
            MusicsDto musicsDto = new MusicsDto()
            {
                Id = musics.Id,
                Name = musics.Name,
                Genre = musics.Genre,
                ReleaseYear = musics.ReleaseYear,
            };
            return musicsDto;
        }

        public IEnumerable<MusicsDto> MapperListMusicsDto(IEnumerable<Musics> musics)
        {
            var dto = musics.Select(c => new MusicsDto { Id = c.Id, Name = c.Name, Genre = c.Genre, ReleaseYear = c.ReleaseYear });
            return dto;
        }
    }
}
