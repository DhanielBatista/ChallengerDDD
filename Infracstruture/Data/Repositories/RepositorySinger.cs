using Domain.Core.Interfaces.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infracstruture.Data.Repositories
{
    public class RepositorySinger : RepositoryBase<Singers>, ISingerRepository
    {
        private readonly SqlContext sqlContext;

        public RepositorySinger(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

    }
}
