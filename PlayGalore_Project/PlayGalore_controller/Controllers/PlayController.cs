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

        public void CreateAPlay(string title, string bio, string genre, object author, object theatre)
        {
            using(var db = new PlayContext())
            {
                var play = new Play();
                play.Title = title; play.Bio = bio; play.Genre = genre; 
                play.AuthorId = (Author)author.AuthorId; play.TheatreId = (Theatre)theatre.TheatreId;
            }
        }

        public void SetSelectedPlay(object play)
        {         
            selectedPlay = (Play)play;            
        }
    }
}
