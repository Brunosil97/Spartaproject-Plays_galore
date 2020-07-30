using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGalore_model.Models
{
    public partial class Author
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string Initials()
        {
            return $"{FirstName[0]} . {LastName[0]}";
        }
    }
}
