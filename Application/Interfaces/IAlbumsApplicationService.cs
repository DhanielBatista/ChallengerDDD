using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IAlbumsApplicationService 
    {
        void Add(AlbumsDto albumsDto);
        void Update(AlbumsDto albumsDto);
        void Remove(AlbumsDto albumsDto);
        IEnumerable<AlbumsDto> GetAll();
        AlbumsDto GetById(int id);
    }
}
