using Microsoft.AspNetCore.Mvc;
using Jobboard.Models;


namespace Jobboard.Controllers
{
  public class JobboardController : Controller
  {
    [HttpPost("/jobboard")]
    public ActionResult Create(string title, string contact, string desc)
    {
      JobOpening myJobOpening = new JobOpening(title, contact, desc);
      return RedirectToAction("Index");
    }
    [HttpGet("/jobboard")]
    public ActionResult Index()
    {
      // JobOpening jobs = JobOpening.GetJob();
      //list<JobOpening>
      JobOpening jobs = JobOpening.Job;
      return View(jobs);
    }
    [HttpGet("/jobboard/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}