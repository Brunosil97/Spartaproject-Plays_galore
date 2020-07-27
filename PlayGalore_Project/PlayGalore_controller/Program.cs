using PlayGalore_model.Models;
using System;

namespace PlayGalore_controller
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayController ds = new PlayController();
            ds.RetrieveAllPlays();

            AuthorController ed = new AuthorController();
            ed.RetrievePlaysForAuthor(1);
        }
    }
}
