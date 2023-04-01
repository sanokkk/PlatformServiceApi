using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformService.Domain.Models
{
    public class Platform
    {
        //key
        //required
        public int Id { get; init; }

        //required
        public string Name { get; init; }

        //required
        public string Publisher { get; init; }

        //required
        public string Cost { get; init; }
    }
}
