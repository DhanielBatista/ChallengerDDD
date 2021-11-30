using Application.Dtos;
using Application.Interfaces;
using Application.Interfaces.MappersInterface;
using Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class MusicsApplicationService : IMusicApplicationService
    {
        private readonly IServiceMusic serviceMusic;
        private readonly IMusicsMapper musicsMapper;

        public MusicsApplicationService(IServiceMusic serviceMusic, IMusicsMapper musicsMapper)
        {
            this.serviceMusic = serviceMusic;
            this.musicsMapper = musicsMapper;
        }
        public void Add(MusicsDto musicsDto)
        {
            var music = musicsMapper.MapperDtoToEntity(musicsDto);
            serviceMusic.Add(music);
        }

        public IEnumerable<MusicsDto> GetAll()
        {
            var musics = serviceMusic.GetAll();
            return musicsMapper.MapperListMusicsDto(musics);
        }

        public MusicsDto GetById(int id)
        {
            var musics = serviceMusic.GetById(id);
            return musicsMapper.MapperEntityToDto(musics);
        }

        public void Remove(MusicsDto musicsDto)
        {
            var musics = musicsMapper.MapperDtoToEntity(musicsDto);
            serviceMusic.Remove(musics);
        }

        public void Update(MusicsDto musicsDto)
        {
            var musics = musicsMapper.MapperDtoToEntity(musicsDto);
            serviceMusic.Update(musics);
        }
    }
}
