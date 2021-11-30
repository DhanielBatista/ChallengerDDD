using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.MappersInterface
{
    public interface IAlbumsMapper
    {
        Albums MapperDtoToEntity(AlbumsDto albumsDto);
        IEnumerable<AlbumsDto> MapperListAlbumsDto(IEnumerable<Albums> albums);
        AlbumsDto MapperEntityToDto(Albums albums);
    }
}
