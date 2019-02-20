using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ItemsController : Controller
  {

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
      if(width == 0 || height == 0 || length == 0 || weight == 0)
      {
        return View();
      }
      else
      {
      Item myItem = new Item(width, height, length, weight);
      return View("ShowItems", myItem);
      }
    }


  }
}
