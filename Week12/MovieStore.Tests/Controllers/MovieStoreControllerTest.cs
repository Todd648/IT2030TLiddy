using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Controllers;
using MovieStore.Models;
using System.Net;

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
            //Arrange
            MoviesController controller = new MoviesController();
            //Act
            ViewResult result = controller.ListFromDB() as ViewResult;
            //Assert
            Assert.IsNotNull(result);
        }

    }
}