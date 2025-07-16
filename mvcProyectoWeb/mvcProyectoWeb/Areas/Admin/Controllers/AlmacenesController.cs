﻿using Microsoft.AspNetCore.Mvc;
using mvcProyectoWeb.AccesoDatos.Data.Repository;
using mvcProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using mvcProyectoWeb.Models;

namespace mvcProyectoWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AlmacenesController : Controller
	{
		private readonly IContenedorTrabajo _contenedorTrabajo;

		public AlmacenesController(IContenedorTrabajo contenedorTrabajo) 
		{
			_contenedorTrabajo = contenedorTrabajo;
		}
		[HttpGet]
		public IActionResult Index() 
		{
			return View();
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Almacen almacen)
		{
			if (ModelState.IsValid)
			{
				//logica para guardar en bd
				_contenedorTrabajo.Almacen.Add(almacen);
				_contenedorTrabajo.Save();
				return RedirectToAction(nameof(Index));

			}
			return View(almacen);
		}
		[HttpGet]
		public IActionResult GetAll()
		{
			return Json(new { data = _contenedorTrabajo.Almacen.GetAll() });
		}


	}
}
