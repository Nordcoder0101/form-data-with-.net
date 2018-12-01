using Microsoft.AspNetCore.Mvc;
using first_form.Models;

namespace first_form
{
  public class first_formController : Controller
  {
    [HttpGet]
    [Route("")]
    public ViewResult index()
    {

      return View();
    }
    [HttpGet]
    [Route("show/{name}/{dojo}/{language}")]
    public ViewResult result(string name, string dojo, string language, string comment)
    {
      Survey NewSurvey = new Survey(name, dojo, language, comment);
      
      return View(NewSurvey);
    }


    [HttpPost]
    [Route("post")]
    public IActionResult Post(string Name, string Dojo, string Language, string Comment)
    {   
        var response = new {
          name = Name,
          dojo = Dojo,
          language = Language,
          comment = Comment

        };
        
        return RedirectToAction("result", response);
    }
  }
}