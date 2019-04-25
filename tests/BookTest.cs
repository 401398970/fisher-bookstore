using Fisher.Bookstore.Models;
using System;
using Xunit;

namespace tests
{
    public class BookTest
    {
        [Fact]
        public void ChangePublicationDate()
        {
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();               
            Assert.Equal(expectedPublicationDate,actualPublicationDate);
        }    

        [Fact]
        public void ChangeTitle()
        {
            var book2 = new Book()
            {
                Id = 2,
                Title = "Arts",
                Author = new Author()
                {
                    Id = 81,
                    Name = "Frank James"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            //Act
            var newTitle = "New Title";
            book2.ChangeTitle(newTitle);

            //Assert
            var expectedTitle = newTitle;
            var actualTitle = book2.Title;               
            Assert.Equal(expectedTitle,actualTitle);
        }    


        [Fact]
        public void ChangePublisher()
        {
            var book3 = new Book()
            {
                Id = 3,
                Title = "Arts",
                Author = new Author()
                {
                    Id = 93,
                    Name = "Tracy McGrady"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            //Act
            var newPublisher = "The Ohio State University Press";
            book3.ChangePublisher(newPublisher);

            //Assert
            var expectedPublisher = newPublisher;
            var actualPublisher = book3.Publisher;               
            Assert.Equal(expectedPublisher,actualPublisher);
        }    
    }
}