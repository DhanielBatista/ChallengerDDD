using Application.Dtos;
using Application.Interfaces;
using Application.Interfaces.MappersInterface;
using Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class AlbumsApplicationService : IAlbumsApplicationService
    {
        private readonly IServiceAlbums serviceAlbums;
        private readonly IAlbumsMapper albumsMapper;
        
        public AlbumsApplicationService(IServiceAlbums serviceAlbums, IAlbumsMapper mapperAlbums)
        {
            this.serviceAlbums = serviceAlbums;
            this.albumsMapper = mapperAlbums;
        }

        public void Add(AlbumsDto albumsDto)
        {
            var album = albumsMapper.MapperDtoToEntity(albumsDto);
            serviceAlbums.Add(album);
        }

        public IEnumerable<AlbumsDto> GetAll()
        {
            var albums = serviceAlbums.GetAll();
            return albumsMapper.MapperListAlbumsDto(albums);
        }

        public AlbumsDto GetById(int id)
        {
            var albums = serviceAlbums.GetById(id);
            return albumsMapper.MapperEntityToDto(albums);
        }

        public void Remove(AlbumsDto albumsDto)
        {
            var albums = albumsMapper.MapperDtoToEntity(albumsDto);
            serviceAlbums.Remove(albums);
        }

        public void Update(AlbumsDto albumsDto)
        {
            var albums = albumsMapper.MapperDtoToEntity(albumsDto);
            serviceAlbums.Update(albums);
        }
    }
}
