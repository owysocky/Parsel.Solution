using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels")]
    public ActionResult ShowItems()
    {
      return View();
    }


    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int width, int height, int length, int weight)
    {
      Item myItem = new Item(width, height, length, weight);
      return View("ShowItems", myItem);
    }


  }
}
