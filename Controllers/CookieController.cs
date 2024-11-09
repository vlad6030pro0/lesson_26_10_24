using System;
using Microsoft.AspNetCore.Mvc;

namespace lesson_26_10_24.Controllers;

public class CookieController : Controller
{
    public IActionResult Index()
    {
        //создание куки
        //Response.Cookies.Append("name","Vlad");

        //получение куки
        //var cookie = Request.Cookies["name"];
        /*foreach(var item in Request.Cookies)
        {
            System.Console.WriteLine(item.Key + " " + item.Value);
        }*/

        //удаление куки
        //Response.Cookies.Delete("name");

        Response.Cookies.Append("name", "Vlad", new CookieOptions{
            Expires = DateTimeOffset.Now.AddDays(7)
        });

        Response.Cookies.Append("info", "Привет! Как дела?");

        return View();
    }

    public IActionResult Settings()
    {
        ViewBag.Theme = "light";

        return View();
    }
}
