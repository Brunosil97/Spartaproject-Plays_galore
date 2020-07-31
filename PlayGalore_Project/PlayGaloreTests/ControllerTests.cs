using NUnit.Framework;
using PlayGalore_controller;
using PlayGalore_model.Models;
using System.Linq;

namespace PlayGaloreTests
{
    public class ControllerTests
    {
        public PlayController _playController = new PlayController();
        public AuthorController _authorController = new AuthorController();
        public TheatreController _theatreController = new TheatreController();

        private TestMethods _testMethods = new TestMethods();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatingANewPlay()
        {
            var authors = _authorController.RetrieveAllAuthors();
            var author = authors[0];
            
            var playCount = _playController.RetrieveAllPlays().Count;
             _playController.CreateAPlay("title", "bio", "genre", author, null);
            var newCount = _playController.RetrieveAllPlays().Count;

            _testMethods.DeletePlay();

            Assert.AreEqual(playCount + 1, newCount);
        }

        [Test]
        public void DeletingAPlay()
        {
            var authors = _authorController.RetrieveAllAuthors();
            var author = authors[0];

            var playCount = _playController.RetrieveAllPlays().Count;
            _playController.CreateAPlay("title", "bio", "genre", author, null);

            _testMethods.DeletePlay();

            var newCount = _playController.RetrieveAllPlays().Count;

            Assert.AreEqual(playCount, newCount);
        }

        [Test]
        public void CreatingANewAuthor()
        {
            var authorCount = _authorController.RetrieveAllAuthors().Count;
            _authorController.CreateAAuthor("firstName", "lastName");
            var newCount = _authorController.RetrieveAllAuthors().Count;

            _testMethods.DeleteAuthor();

            Assert.AreEqual(authorCount + 1, newCount);
        }

        [Test]
        public void DeletingAuthor()
        {
            var authorCount = _authorController.RetrieveAllAuthors().Count;
            _authorController.CreateAAuthor("firstName", "lastName");

            _testMethods.DeleteAuthor();

            var newCount = _authorController.RetrieveAllAuthors().Count;

            Assert.AreEqual(authorCount, newCount);
        }

        [Test]
        public void CreatingANewTheatre()
        {
            var theatreCount = _theatreController.RetrieveAllTheatres().Count;
            _theatreController.CreateATheatre("name", "location", 200);
            var newCount = _theatreController.RetrieveAllTheatres().Count;

            _testMethods.DeleteTheatre();

            Assert.AreEqual(theatreCount + 1, newCount);
        }

        [Test]
        public void DeletingTheatre()
        {
            var theatreCount = _theatreController.RetrieveAllTheatres().Count;
            _theatreController.CreateATheatre("name", "location", 200);

            _testMethods.DeleteTheatre();

            var newCount = _theatreController.RetrieveAllTheatres().Count;

            Assert.AreEqual(theatreCount, newCount);
        }

        [Test]
        public void CheckIfSearchRetrievesSearchedPlay()
        { 
            int searchItem = 1;

            var authors = _authorController.RetrieveAllAuthors();
            var author = authors[0];

            _playController.CreateAPlay("UnitTestSearch", "bio", "genre", author, null);

           var searchedPlays = _playController.SearchedPlays("UnitTestSearch");

            Assert.AreEqual(searchItem, searchedPlays.Count);

            _testMethods.DeletePlay();
        }

        [Test]
        public void UpdatePlay()
        {
            var authors = _authorController.RetrieveAllAuthors();
            var author = authors[0];
            _playController.CreateAPlay("title", "bio", "genre", author, null);

            var play = _playController.RetrieveAllPlays().Last();
            var selectedPlayTitle = play.Title;

            _playController.UpdateAPlay(play.PlayId, "UpdatedTitle", "bio", "genre", author, null);

            var updatedPlay = _playController.RetrieveAllPlays().Last();
            var updatedPlayTitle = updatedPlay.Title;

            Assert.AreNotEqual(selectedPlayTitle, updatedPlayTitle);

            _testMethods.DeletePlay();

        }

        [Test]
        public void UpdateAuthor()
        {
          _authorController.CreateAAuthor("firstName", "lastName");
            var author = _authorController.RetrieveAllAuthors().Last();
            var selectedAuthorTitle = author.FirstName;

            _authorController.UpdateExistingAuthor(author.AuthorId, "UpdatedName", "LastName");

            var updatedAuthor = _authorController.RetrieveAllAuthors().Last();
            var updatedAuthorTitle = updatedAuthor.FirstName;

            Assert.AreNotEqual(selectedAuthorTitle, updatedAuthorTitle);
            _testMethods.DeleteAuthor();
        }

        [Test]
        public void UpdateTheatre()
        {
            _theatreController.CreateATheatre("name", "location", 1);
            var theatre = _theatreController.RetrieveAllTheatres().Last();
            var selectedTheatreName = theatre.Name;

            _theatreController.UpdateExistingTheatre(theatre.TheatreId, "UpdatedName", "location", 1);

            var updatedTheatre = _theatreController.RetrieveAllTheatres().Last();
            var updatedTheatreName = updatedTheatre.Name;

            Assert.AreNotEqual(selectedTheatreName, updatedTheatreName);

            _testMethods.DeleteTheatre();
        }
    }
}