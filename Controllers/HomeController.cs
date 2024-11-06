using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeetingApp1.Models;

namespace MeetingApp1.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        int saat = DateTime.Now.Hour;
        
        ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
        ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
        // ViewBag.UserName = "Bartu";

        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "İstanbul, Bostancı Gösteri Merkezi",
            Date = new DateTime(2024, 01, 20, 20, 0, 0),
            NumberOfPeople = 100
        };
        
        return View(meetingInfo);
    }
    
}