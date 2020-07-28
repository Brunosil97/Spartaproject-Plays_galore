using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using PlayGalore_model.Models;
using System.Linq;

namespace PlayGalore_controller
{
    public class PlayController
    {
        public Play selectedPlay { get; set; }
        public List<Play> RetrieveAllPlays()
        {
            using(var db = new PlayContext())
            {
                return db.Plays.Include(p => p.Author).ToList();
            }
            
        }

        //[Obsolete]
        public void CreateAPlay(string title, string bio, string genre, object author, object theatre)
        {

            int? theatreObjId = null;

            if(theatre != null) { theatreObjId = ((Theatre)theatre).TheatreId; };

            using (var db = new PlayContext())
            {
                db.Add(new Play
                {
                    Title = title,
                    Bio = bio,
                    Genre = genre,
                    AuthorId = ((Author)author).AuthorId,
                    TheatreId = theatreObjId
                });
                db.SaveChanges();
            }
        }

        public void SetSelectedPlay(object play)
        {         
            selectedPlay = (Play)play;            
        }
    }
}
