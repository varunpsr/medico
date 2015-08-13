using BMIBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace BMIBase.Controllers
{
	[RequireHttps]
	[Authorize]
	public class HomeController : Controller
	{
		BMIContext _dbContext;

		public ActionResult Index()
		{
			var userId = User.Identity.GetUserId();
			_dbContext = new BMIContext();

			var userData = _dbContext.UserData.Where(item=>item.UserId.Equals(userId)).ToList();
			if (userData.Count() == 0)
				return RedirectToAction("UserData");
			else
			{
				//show usertable
				var list = _dbContext.BodyComposition.Where(item => item.Userid.Equals(userId)).AsEnumerable();
				return View(list);
			}

			//_dbContext.BodyComposition.Add()
			//BodyComposition comp = new BodyComposition();
			//comp.BMI = 40.00;
			//comp.MetabolicRate = 1200;
			//comp.FatPercentage = 25.00;
			//comp.MuscleMass = 75.00;
			//comp.WaterPercentage = 30.00;
			//comp.BoneDensity = 2.20;
			//comp.FatWeight = 25.00;
			//comp.MusclePercentage = 75.00;
			//comp.BodyAge = 150;
			//comp.Userid = userId;

			//_dbContext.BodyComposition.Add(comp);
			//_dbContext.SaveChanges();
			//return View();
		}

		[HttpGet]
		public ActionResult UserData()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(BodyComposition composition)
		{
			var userId = User.Identity.GetUserId();
			composition.Userid = userId;
			_dbContext = new BMIContext();
			_dbContext.BodyComposition.Add(composition);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult UserData(UserData data)
		{
			var userId = User.Identity.GetUserId();
			data.UserId = userId;
			_dbContext = new BMIContext();
			_dbContext.UserData.Add(data);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult About()
		{
			_dbContext = new BMIContext();
			ViewBag.Message = "Your application description page.";
			var temp = _dbContext.BodyComposition.ToList();

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}