using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformService.DAL.Dtos
{
    public class CreatePlatformDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        public string Publisher { get; init; }

        [Required]
        public string Cost { get; init; }
    }
}
