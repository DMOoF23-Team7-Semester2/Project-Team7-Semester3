using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rally.Application.Dto.Track
{
    public class CreateTrackDto
    {
        public string Name { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}