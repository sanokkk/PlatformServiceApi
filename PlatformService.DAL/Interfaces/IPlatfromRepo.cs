using PlatformService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformService.DAL.Interfaces
{
    public interface IPlatfromRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> Get();

        Platform GetById(int id);

        void Create(Platform platform);
    }
}
