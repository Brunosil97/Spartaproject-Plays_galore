using NUnit.Framework;
using PlayGalore_controller;
using PlayGalore_model.Models;

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

        //[Test]
        //public void ReturnsListOfPlays()
        //{
        //    _playController.RetrieveAllPlays()
        //}
    }
}