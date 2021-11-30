using Application.Dtos;
using Application.Interfaces;
using Application.Interfaces.MappersInterface;
using Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class SingersApplicationService : ISingersApplicationService
    {
        private readonly IServiceSinger serviceSinger;
        private readonly ISingersMapper singersMapper;

        public SingersApplicationService(IServiceSinger serviceSinger, ISingersMapper singersMapper)
        {
            this.serviceSinger = serviceSinger;
            this.singersMapper = singersMapper;
        }

        public void Add(SingersDto singersDto)
        {
            var singer = singersMapper.MapperDtoToEntity(singersDto);
            serviceSinger.Add(singer);
        }

        public IEnumerable<SingersDto> GetAll()
        {
            var singer = serviceSinger.GetAll();
            return singersMapper.MapperListSingerDto(singer);
        }

        public SingersDto GetById(int id)
        {
            var singer = serviceSinger.GetById(id);
            return singersMapper.MapperEntityToDto(singer);
        }

        public void Remove(SingersDto singersDto)
        {
            var singer = singersMapper.MapperDtoToEntity(singersDto);
            serviceSinger.Remove(singer);
        }

        public void Update(SingersDto singersDto)
        {
            var singer = singersMapper.MapperDtoToEntity(singersDto);
            serviceSinger.Update(singer);
        }
    }
}
