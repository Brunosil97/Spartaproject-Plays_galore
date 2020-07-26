using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGalore_model.Models
{
    public partial class Theatre
    {
        public int TheatreId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int Capacity { get; set; }

        public List<Play> Plays { get; set; } = new List<Play>();
    }
}
