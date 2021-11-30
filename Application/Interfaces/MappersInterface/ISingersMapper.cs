using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.MappersInterface
{
    public interface ISingersMapper
    {
        Singers MapperDtoToEntity(SingersDto singersDto);
        IEnumerable<SingersDto> MapperListSingerDto(IEnumerable<Singers> singers);
        SingersDto MapperEntityToDto(Singers singers);
    }
}
