using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlayGalore_model.Models
{
    public partial class Author
    {
        public int AuthorId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        public List<Play> Plays { get; } = new List<Play>();
    }
}
