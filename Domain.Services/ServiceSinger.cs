using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ServiceSinger : ServiceBase<Singers>, IServiceSinger
    {
        private readonly ISingerRepository singersRepository;

        public ServiceSinger(ISingerRepository singersRepository) : base(singersRepository)
        {
            this.singersRepository = singersRepository;
        }
    }
}
