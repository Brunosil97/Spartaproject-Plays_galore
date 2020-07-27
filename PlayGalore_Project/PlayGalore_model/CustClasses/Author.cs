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
    }
}
