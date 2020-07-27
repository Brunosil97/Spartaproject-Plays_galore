using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGalore_model.Models
{
    public partial class Play
    {
        public override string ToString()
        {
            return $"{Title}\n By: " + $"{Author}";
        }
    }
}
