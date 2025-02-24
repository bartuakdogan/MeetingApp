﻿using MeetingApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp1.Controllers;

public class MeetingController : Controller
{
    

    [HttpGet]
    public IActionResult Apply()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Apply(UserInfo model)
    {
        if (ModelState.IsValid)
        {
            //database
            // list
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            return View("Thanks", model);
        }
        else
        {
            return View(model);
        }
        
    }

    [HttpGet]
    public IActionResult List()
    {
        return View(Repository.Users);
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        return View(Repository.GetById(id));
    }
}