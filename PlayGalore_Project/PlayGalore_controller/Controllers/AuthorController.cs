using Microsoft.EntityFrameworkCore;
using PlayGalore_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayGalore_controller
{
    public class AuthorController
    {

        public List<Play> RetrievePlaysForAuthor(int authorId)
        {
            using(var db = new PlayContext())
            {
                var playQuery = db.Plays.Include(p => p.Author).Where(p => p.AuthorId == authorId);
                var ans = playQuery.ToList();
                return ans ;
            }
        }

        public List<Author> RetrieveAllAuthors()
        {
            using(var db = new PlayContext())
            {
                return db.Authors.ToList();
            }
        }
    }
}
