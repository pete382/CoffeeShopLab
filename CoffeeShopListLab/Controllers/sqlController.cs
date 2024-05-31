using CoffeeShopListLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopListLab.Controllers
{
    public class sqlController : Controller

    {
		CoffeeShopContext dbContext = new CoffeeShopContext();

		public IActionResult Index()
		{
			List<Drink> result = dbContext.Drinks.ToList();
			return View(result);
		}

				
		
		public IActionResult Details(int id)
		{
			Drink result = dbContext.Drinks.FirstOrDefault(d => d.Id == id);
			return View(result);
		}
	}


}

