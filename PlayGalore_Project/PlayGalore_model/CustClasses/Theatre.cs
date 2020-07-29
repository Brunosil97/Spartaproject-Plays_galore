using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGalore_model.Models
{
    public partial class Theatre
    {
        public override string ToString()
        {
            return $"{Initial()}";
        } 

        public string Initial()
        {
            return $"{Name[0]}";
        }
    }
}
