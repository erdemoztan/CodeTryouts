using Domain;
using Domain.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PublisherRepository : Repository<DiceContext, Publisher>, IPublisherRepository
    {
    }
}
