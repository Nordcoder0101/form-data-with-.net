using Microsoft.AspNetCore.Mvc;

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
    public ViewResult result(string name, string dojo, string language)
    {
      ViewBag.name = name;
      ViewBag.dojo = dojo;
      ViewBag.language = language;

      return View();
    }


    [HttpPost]
    [Route("post")]
    public IActionResult Post(string name, string dojo, string language)
    {   
        var response = new {
          name = name,
          dojo = dojo,
          language = language

        };
        
        return RedirectToAction("result", response);
    }
  }
}