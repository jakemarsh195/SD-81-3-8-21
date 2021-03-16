using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {//we want to add the method in the repo
        [TestMethod]                                                    ///AAA -> Arrange, Act, Assert
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {        //Arrange = overall setup                                                       
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act = Get/run the code to test
            bool addresult = repository.AddContentToDirectory(content);

            //Assert = Used toget the expected outcome of a test
            Assert.IsTrue(addresult);
        }
        //Testing the Read Method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA RULES APPLY... 
            //ARRANGE = initial setup
            //creating the content
            StreamingContent content = new StreamingContent();
            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
            
            //Adding to the rep (content)
            repo.AddContentToDirectory(content);
            
            //----------------------------------------------------------------------
            //Act
            //our plan is to stor the list of streaming content within a variable
            List<StreamingContent> listOfMovies = repo.GetContent();

            //looks through our entire list and returns true if there is content
            bool directoryHasContent = listOfMovies.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //THIS IS THE ARRANGE PART...
        [TestInitialize]
        public void Arrange() //Properties / contructors / methods
        {//make the repo
            _repo = new StreamingContentRepository();
            //we make a new movie here ...finally...
            _content = new StreamingContent("Rubber", "A car tire come to life with the power to make people explode",
                                             MaturityRating.R,GenreType.Drama,5.8d);
            //now add the movie is in our 'database' (list)
            _repo.AddContentToDirectory(_content);

        }
        //retrieve content by title
        [TestMethod]
        public void GetByTitla_ShouldReturnCorrectContent()
        {//Arrange...Already done above //Arrange sets up test case, rest of the tests test against the test case
            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            StreamingContent theFailure = _repo.GetContentByTitle("Rubber-Duck");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }
        //Test the Update Method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange = Update version of our movie
            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tire come to life with the power to make people explode",
                                             MaturityRating.R, GenreType.Drama, 9.8d);
            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber",newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");
            //Act
            bool removeResult = _repo.DeleteExistingContent(content);
            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
