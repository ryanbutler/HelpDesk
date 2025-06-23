using HelpDesk.DAL;
using HelpDesk.Models;
using HelpDesk.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
namespace HelpDesk.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;
		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult LoadDropDowns()
		{
			var model = new TicketViewModel
			{
				Severities = _context.Severity.Select(c => new SelectListItem{
					Value = c.Id.ToString(),
					Text = c.Severity.ToString()
				}).ToList(),
				Personnels = _context.Personnel.Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Personnel.ToString()
                    }).ToList(),
                Departments = _context.Department.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Department.ToString()
                }).ToList()

            };

			return View(model);
		}
				
        

        public IActionResult Ticket()
		{
			LoadDropDowns();
            return View();
		}

		[HttpPost]
		public IActionResult Ticket(TicketViewModel model)
		{
			if (ModelState.IsValid)
			{
				var ticket=new Tickets();
				ticket.FirstName = model.FirstName;
				ticket.LastName = model.LastName;
				ticket.Subject = model.Subject;
				ticket.Description= model.Description;
				ticket.PersonnelId = model.SelectedPersonnelId ?? 0;
				ticket.DepartmentId = model.SelectedDeparmentId ?? 0;
				ticket.SeverityId = model.SelectedSeverityId ?? 0;
				_context.Add(ticket);
				_context.SaveChanges();
				return RedirectToAction("Success");
			}
			LoadDropDowns();
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
