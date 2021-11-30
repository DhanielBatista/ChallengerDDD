using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ServiceMusic : ServiceBase<Musics>, IServiceMusic
    {
        private readonly IMusicRepository musicsRepository;

        public ServiceMusic(IMusicRepository musicRepository) : base(musicRepository)
        {
            this.musicsRepository = musicRepository;
        }
    }
}
