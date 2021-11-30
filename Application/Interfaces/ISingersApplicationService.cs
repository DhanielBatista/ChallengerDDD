using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ISingersApplicationService
    {
        void Add(SingersDto singersDto);
        void Update(SingersDto  singersDto);
        void Remove(SingersDto singersDto);
        IEnumerable<SingersDto> GetAll();
        SingersDto GetById(int id);
    }
}
