using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGalore_model.Models
{
    public partial class Play
    {
        public int PlayId { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int? TheatreId { get; set; }

        public Theatre Theatre { get; set; }

        public string Title { get; set; }

        public string Bio { get; set; }

        public string Genre { get; set; }
    }
}
