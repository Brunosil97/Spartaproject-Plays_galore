using PlayGalore_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayGalore_controller
{
    public class TheatreController
    {
        public Theatre SelectedTheatre {get; set;}
        public List<Theatre> RetrieveAllTheatres()
        {
            using (var db = new PlayContext())
            {
                return db.Theatres.ToList();
            }
        }

        public void CreateATheatre(string name, string location, int capacity)
        {
            using(var db = new PlayContext())
            {
                db.Add(new Theatre
                {
                    Name = name,
                    Location = location,
                    Capacity = capacity
                });
                db.SaveChanges();
            }
        }

        public void DeleteExistingTheatre(int theatreId)
        {
            using (var db = new PlayContext())
            {
                SelectedTheatre = db.Theatres.Where(t => t.TheatreId == theatreId).FirstOrDefault();
                db.Remove(SelectedTheatre);
                db.SaveChanges();
            }
        }

        public void UpdateExistingTheatre(int theatreId, string name, string location, int capacity)
        {
            using(var db = new PlayContext())
            {
                SelectedTheatre = db.Theatres.Where(t => t.TheatreId == theatreId).FirstOrDefault();
                SelectedTheatre.Name = name;
                SelectedTheatre.Location = location;
                SelectedTheatre.Capacity = capacity;
                db.SaveChanges();
            }
        }

        public void SetSelectedTheatre(object selectedItem)
        {
            SelectedTheatre = (Theatre)selectedItem;
        }
    }
}
