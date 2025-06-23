using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModel
{
	public class TicketViewModel
	{
        [Required(ErrorMessage ="Please select a severity")]
        public int? SelectedSeverityId { get; set; }
        public List<SelectListItem> Severities { get; set; }=new List<SelectListItem>();

        
        public int? SelectedDeparmentId{get; set; }
        public List<SelectListItem> Departments{get;set; } =new List<SelectListItem>();

        
        public int? SelectedPersonnelId { get; set; }
        public List<SelectListItem> Personnels{get;set; }=new List<SelectListItem>();
        
        
        public string FirstName{get;set; }=string.Empty;
        
        public string LastName{get;set; }=string.Empty;
        
        public string Subject { get; set; }=string.Empty;
        
        public string Description { get; set; }=string.Empty;
    }
}
