using PlayGalore_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayGalore_controller
{
    public class TheatreController
    {
        public List<Theatre> RetrieveAllTheatres()
        {
            using (var db = new PlayContext())
            {
                return db.Theatres.ToList();
            }
        }
    }
}
