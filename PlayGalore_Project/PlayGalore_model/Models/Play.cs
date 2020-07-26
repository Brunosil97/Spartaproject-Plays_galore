using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlayGalore_model.Models
{
    public partial class Play
    {
        public int PlayId { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int? TheatreId { get; set; }

        public Theatre Theatre { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Bio { get; set; }
        [StringLength(25)]
        public string Genre { get; set; }
    }
}
