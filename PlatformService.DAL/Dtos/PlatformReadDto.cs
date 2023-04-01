using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformService.DAL.Dtos
{
    public class PlatformReadDto
    {
        public int Id { get; init; }

        public string Name { get; init; }


        public string Publisher { get; init; }


        public string Cost { get; init; }
    }
}
