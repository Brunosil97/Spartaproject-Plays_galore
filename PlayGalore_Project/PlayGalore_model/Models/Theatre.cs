using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlayGalore_model.Models
{
    public partial class Theatre
    {
        public int TheatreId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        
        public int Capacity { get; set; }

        public List<Play> Plays { get; set; } = new List<Play>();
    }
}
