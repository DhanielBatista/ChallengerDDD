using Application.Dtos;
using Application.Interfaces.MappersInterface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Application.Mapper
{
    public class MapperAlbums : IAlbumsMapper
    {
        public Albums MapperDtoToEntity(AlbumsDto albumsDto)
        {
            var album = new Albums()
            {
                Id = albumsDto.Id,
                Name = albumsDto.Name,
                Year = albumsDto.Year,
            };
            return album;
        }

        public AlbumsDto MapperEntityToDto(Albums albums)
        {
            AlbumsDto albumsDto = new AlbumsDto()
            {
                Id = albums.Id,
                Name = albums.Name,
                Year = albums.Year,
            };
            return albumsDto;
        }

        public IEnumerable<AlbumsDto> MapperListAlbumsDto(IEnumerable<Albums> albums)
        {
            var dto = albums.Select(c => new AlbumsDto { Id = c.Id, Name = c.Name, Year = c.Year });
            return dto;
        }
    }

}
