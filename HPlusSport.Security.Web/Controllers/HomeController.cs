using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;
/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	Abhay Patel - 2261385
* Date: 		14 November 2025
* Class Name: 	HomeController.cs
* Description: 	Manages the Home page.
* Time Task B):	1 hour
 */
public class HomeController : Controller
{
    public IActionResult Index()
    {
        //var x = 1 / new Random().Next(0, 1);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
