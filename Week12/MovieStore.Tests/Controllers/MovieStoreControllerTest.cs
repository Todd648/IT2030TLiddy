﻿namespace MovieStore.Tests.Controllers
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MovieStore.Controllers;
    using MovieStore.Models;
    using System.Net;
    using System.Linq;
    using Moq;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Data.Entity;

    [TestClass]
    public class MovieStoreControllerTest
    {
        [TestMethod]
        public void MovieStore_Index_TestView()
        {
            //Arrange
            MoviesController controller = new MoviesController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void MovieStore_ListOfMovies()
        {
            //Arrange
            MoviesController controller = new MoviesController();
            //Act
            List<Movie> result = controller.ListOfMovies();
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Iron Man 1", result[0].Title);
            Assert.AreEqual("Iron Man 2", result[1].Title);
            Assert.AreEqual("Iron Man 3", result[2].Title);
        }
        [TestMethod]
        public void MovieStore_Index_Redirect_Success()
        {
            //Arrange
            MoviesController controller = new MoviesController();
            //Act
            RedirectToRouteResult result = controller.IndexRedirect(1) as RedirectToRouteResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Create", result.RouteValues["action"]);
            Assert.AreEqual("HomeController", result.RouteValues["controller"]);

        }
        [TestMethod]
        public void MovieStore_Index_Redirect_BadRequest()
        {
            //Arrange
            MoviesController controller = new MoviesController();
            //Act
            HttpStatusCodeResult result = controller.IndexRedirect(0) as HttpStatusCodeResult;
            //Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, (HttpStatusCode)result.StatusCode);

        }
        [TestMethod]
        public void MovieStore_ListFromDb()
        {
            //Step 1
            var list = new List<Movie>
            {
                new Movie {MovieID=1, Title = "Spiderman 1"},
                new Movie {MovieID=1, Title = "Spiderman 2"}
            }.AsQueryable();

            //Step 2
            Mock < MovieStoreDBContext > mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            //Step 3
            mockSet.As<IQueryable<Movie>>().Setup(m=>m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            
            //Step 4
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);
            //Arrange
            MoviesController controller = new MoviesController(mockContext.Object);
            //Act
            ViewResult result = controller.ListFromDB() as ViewResult;
            List<Movie> resultMovies = result.Model as List<Movie>;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void MovieStore_Details_Success()
        {
            //Step 1
            var list = new List<Movie>
            {
                new Movie {MovieID=1, Title = "Spiderman 1"},
                new Movie {MovieID=1, Title = "Spiderman 2"}
            }.AsQueryable();

            //Step 2
            Mock<MovieStoreDBContext> mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            //Step 3
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            mockSet.Setup(m => m.Find(It.IsAny<Object>())).Returns(list.First());
            //Step 4
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);
            //Arrange
            MoviesController controller = new MoviesController(mockContext.Object);
            //Act
            ViewResult result = controller.Details(1) as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void MovieStore_Details_IsNull()
        {
            //Step 1
            var list = new List<Movie>
            {
                new Movie {MovieID=1, Title = "Spiderman 1"},
                new Movie {MovieID=1, Title = "Spiderman 2"}
            }.AsQueryable();

            //Step 2
            Mock<MovieStoreDBContext> mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            //Step 3
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            mockSet.Setup(m => m.Find(It.IsAny<Object>())).Returns(list.First());
            //Step 4
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);
            //Arrange
            MoviesController controller = new MoviesController(mockContext.Object);
            //Act
            HttpStatusCodeResult result = controller.Details(null) as HttpStatusCodeResult;
            //Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, (HttpStatusCode)result.StatusCode);
        }
        [TestMethod]
        public void MovieStore_Movie_IsNull()
        {
            //Step 1
            var list = new List<Movie>
            {
                new Movie {MovieID=1, Title = "Spiderman 1"},
                new Movie {MovieID=1, Title = "Spiderman 2"}
            }.AsQueryable();

            //Step 2
            Mock<MovieStoreDBContext> mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            //Step 3
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            Movie movie = null;
            mockSet.Setup(m => m.Find(It.IsAny<Object>())).Returns(movie);
            //Step 4
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);
            //Arrange
            MoviesController controller = new MoviesController(mockContext.Object);
            //Act
            HttpStatusCodeResult result = controller.Details(0) as HttpStatusCodeResult;
            //Assert
            Assert.AreEqual(HttpStatusCode.NotFound, (HttpStatusCode)result.StatusCode);
        }
    }
}