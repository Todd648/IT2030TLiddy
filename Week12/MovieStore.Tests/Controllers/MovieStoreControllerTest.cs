using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Controllers;
using MovieStore.Models;

namespace MovieStore.Tests.Controllers
{
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
        public void MovieStore_Index_Redirect()
        {
            //Arrange
            MoviesController controller = new MoviesController();
            //Act
            RedirectToRouteResult result = controller.IndexRedirect() as RedirectToRouteResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Create", result.RouteValues["action"]);
        }

    }
}