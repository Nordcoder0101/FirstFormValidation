using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstFormValidation.Models;

namespace FirstFormValidation
{
  public class FirstFormValidationController : Controller
  {
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {

      return View();
    }
    [HttpGet]
    [Route("show")]
    public ViewResult Result(Survey survey)
    {

      return View(survey);
    }


    [HttpPost]
    [Route("post")]
    public IActionResult Post(Survey survey)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Result", survey);
        }
        else
        {
            return View("Index");
        }
      

      
    }
  }
}