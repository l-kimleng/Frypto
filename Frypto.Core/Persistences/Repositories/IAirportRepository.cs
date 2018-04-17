using Frypto.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Persistences.Repositories
{
    public interface IAirportRepository
    {
        Task<IList<Airport>> Get(string code);
    }
}
