using PlayGalore_model.Models;
using System;
using System.Data.Common;
using System.Linq;

namespace PlayGalore_model
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            using (var db = new PlayContext())
            {
                //var author1 = new Author();
                //author1.FirstName = "Bruno";
                //author1.LastName = "Silva";

                //db.Add(author1);
                //db.SaveChanges();

                //var theatre1 = new Theatre();
                //theatre1.Name = "Almedia Theatre";
                //theatre1.Location = "Clapham";
                //theatre1.Capacity = 250;

                //db.Add(theatre1);
                //db.SaveChanges();

                //var play1 = new Play();
                //play1.AuthorId = author1.AuthorId;
                //play1.TheatreId = theatre1.TheatreId;
                //play1.Title = "This is a play";
                //play1.Genre = "Scary";
                //play1.Bio = "asiuejsdpof fhsdoijwpas ehfoudsijei";

                //db.Add(play1);
                //db.SaveChanges();
                //var author = db.Authors.ToList().First();
                //var play2 = new Play();
                //play2.AuthorId = author.AuthorId;
                //play2.Title = "This is a play 2";
                //play2.Genre = "Fun";
                //play2.Bio = "ijfooefjowejijiwe";

                //db.Add(play2);
                //db.SaveChanges();


            }
        }
    }
}
