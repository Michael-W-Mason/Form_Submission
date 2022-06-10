using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;
namespace FormSubmission.Controllers;

public class FormController : Controller
{
    [HttpGet("")]
    public ViewResult Form()
    {
        return View("Form");
    }

    [HttpPost("submit")]
    public IActionResult Submit(User user)
    {
        if (ModelState.IsValid)
        {
            return View("Register");
        }
        else{
            return View("Form");
        }
    }
}