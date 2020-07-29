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
        public Author selectedAuthor { get; set; }
        public List<Play> RetrievePlaysForAuthor(int authorId)
        {
            using(var db = new PlayContext())
            {
                var playQuery = db.Plays.Where(p => p.AuthorId == authorId);
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
        
        public void CreateAAuthor(string firstName, string lastName)
        {
            using(var db = new PlayContext())
            {
                db.Add(new Author
                {
                    FirstName = firstName,
                    LastName = lastName
                });
                db.SaveChanges();
            }
        }
        public void UpdateExistingAuthor(int authorId, string firstName, string lastName)
        {
            using(var db = new PlayContext())
            {
                selectedAuthor = db.Authors.Where(a => a.AuthorId == authorId).FirstOrDefault();
                selectedAuthor.FirstName = firstName;
                selectedAuthor.LastName = lastName;
                db.SaveChanges();
            }
        }

        public void DeleteExistingAuthor(int authorId)
        {
            using(var db = new PlayContext())
            {
                selectedAuthor = db.Authors.Where(a => a.AuthorId == authorId).FirstOrDefault();
                db.Authors.Remove(selectedAuthor);
                db.SaveChanges();
            }
        }
        public void SetSelectedAuthor(object author)
        {
            selectedAuthor = (Author)author;
        }
    }
}
