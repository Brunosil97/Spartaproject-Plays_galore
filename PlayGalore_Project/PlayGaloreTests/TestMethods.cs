using PlayGalore_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayGaloreTests
{
    public class TestMethods
    {
        public void DeletePlay()
        {
            using(var db = new PlayContext())
            {
                var plays = db.Plays.ToList();
                plays.Reverse();
                var lastPlay = plays[0];
                db.Plays.Remove(lastPlay);
                db.SaveChanges();
            }
        }

        public void DeleteAuthor()
        {
            using (var db = new PlayContext())
            {
                var authors = db.Authors.ToList();
                authors.Reverse();
                var lastAuthor = authors[0];
                db.Authors.Remove(lastAuthor);
                db.SaveChanges();
            }
        }

        public void DeleteTheatre()
        {
            using (var db = new PlayContext())
            {
                var theatres = db.Theatres.ToList();
                theatres.Reverse();
                var lastTheatre = theatres[0];
                db.Theatres.Remove(lastTheatre);
                db.SaveChanges();
            }
        }
    }
}
