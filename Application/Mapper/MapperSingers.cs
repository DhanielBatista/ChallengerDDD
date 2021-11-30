using Application.Dtos;
using Application.Interfaces.MappersInterface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Mapper
{
    public class MapperSingers : ISingersMapper
    {

        public Singers MapperDtoToEntity(SingersDto singersDto)
        {
            var singer = new Singers()
            {
                Id = singersDto.Id,
                Name = singersDto.Name,
            };
            return singer;
        }

        public SingersDto MapperEntityToDto(Singers singers)
        {
            SingersDto singersDto = new SingersDto()
            {
                Id = singers.Id,
                Name = singers.Name
            };
            return singersDto;
        }

        public IEnumerable<SingersDto> MapperListSingerDto(IEnumerable<Singers> singers)
        {
            var dto = singers.Select(c => new SingersDto { Id = c.Id, Name = c.Name });
            return dto;
        }
    }
}
