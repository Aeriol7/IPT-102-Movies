using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
     new MovieViewModel { Id = 1, Name = "Eternals", Rating = "4", ReleaseYear = 2021, Genre = "Action/Drama", link="x_me3xsvDgk", Image ="/Image/Eternals.jpg" },
    new MovieViewModel { Id = 2, Name = "Captain Marvel", Rating = "7.5", ReleaseYear = 2019,  Genre = "Action/Drama", link = "Z1BCujX3pw8" , Image ="/Image/capMarvel.jpg" },
    new MovieViewModel { Id = 3, Name = "Captain America: Civil War", Rating = "10", ReleaseYear = 2016, Genre = "Action/Drama",link="dKrVegVI0Us", Image ="/Image/CivilWar.jfif" },
     new MovieViewModel { Id = 4, Name = "Icredible Hulk", Rating = "5", ReleaseYear = 2008, Genre = "Drama/Action", link="xbqNb2PFKKA", Image ="/Image/Hulk.jpg" },
    new MovieViewModel { Id = 5, Name = "Avengers: End Game", Rating = "10", ReleaseYear = 2019, Genre = "Action/Drama", link="TcMBFSGVi1c", Image ="/Image/EngGame.jpeg" },
    new MovieViewModel { Id = 6, Name = "Thor", Rating = "6.3", ReleaseYear = 2017, Genre = "Action/Drama",link="w1k59SJ_-Uo", Image ="/Image/Thor.jpg" },
    new MovieViewModel { Id = 7, Name = "Iron Man", Rating = "7.6", ReleaseYear = 2008, Genre = "Action/Drama", link="8ugaeA-nMTc",Image ="/Image/iron man.jfif" },
    new MovieViewModel { Id = 8, Name = "Iron Man 2", Rating = "7.6", ReleaseYear = 2010, Genre = "Action/Drama", link = "wKtcmiifycU", Image ="/Image/iron man 2.jfif" },
    new MovieViewModel { Id = 9, Name = "Iron Man 3", Rating = "7.6", ReleaseYear = 2013, Genre = "Action/Drama", link = "Ke1Y3P9D0Bc", Image ="/Image/iron man 3.jfif" },
    new MovieViewModel { Id = 10, Name = "Doctor Strange", Rating = "6.4", ReleaseYear = 2016, Genre = " Drama/Action", link = "h7gvFravm4A", Image ="/Image/doctor strange.jpg" },
    new MovieViewModel { Id = 11, Name = "Ant-Man", Rating = "6.2", ReleaseYear = 2015, Genre = "Action/Drama", link = "pWdKf3MneyI", Image ="/Image/antman.jpg" },
    new MovieViewModel { Id = 12, Name = "Guardians of the Galaxy", Rating = "7.8", ReleaseYear = 2015, Genre = "Action/Drama", link = "d96cjJhvlMA", Image ="/Image/GOG.jpg" },
    new MovieViewModel { Id = 13, Name = "Guardians of the Galaxy Vol. 2", Rating = "7.1", ReleaseYear = 2017, Genre = "Action/Drama", link = "dW1BIid8Osg", Image ="/Image/images.jfif" },
    new MovieViewModel { Id = 14, Name = "Spider-Man: Far From Home", Rating = "7.2", ReleaseYear = 2019, Genre = "Action/Drama", link = "Nt9L1jCKGnE", Image = "/Image/far.jfif" },
    new MovieViewModel { Id = 15, Name = "Spider-Man: No Way Home", Rating = "4.5", ReleaseYear = 2021, Genre = "Action/Drama", link = "JfVOs4VSpmA", Image ="/Image/spider man now way home.jpg" },
};
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

