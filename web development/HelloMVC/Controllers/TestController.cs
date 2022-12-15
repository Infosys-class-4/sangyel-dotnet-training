using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

public class TestController : Controller
{
    public IActionResult Action1(int num)
    {
        return View(num);
    }
    public IActionResult MultiplicationTable(int upto)
    {
        return View(upto);
    }
}
