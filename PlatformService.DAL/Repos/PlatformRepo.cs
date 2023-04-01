using PlatformService.DAL.Interfaces;
using PlatformService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformService.DAL.Repos
{
    public class PlatformRepo : IPlatfromRepo
    {
        private readonly ApplicationDbContext _db;
        public PlatformRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(Platform platform) => _db.Platforms.Add(platform);

        public IEnumerable<Platform> Get() => _db.Platforms.ToArray();
        
        public Platform GetById(int id) => _db.Platforms.FirstOrDefault(f => f.Id == id);
        
        public bool SaveChanges() => (_db.SaveChanges() >= 0);
    }
}
