using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string? Name { get; set; }

      
        public int EmployerId { get; set; }

        public List<Employer> SelectListItem { get; set; } = new List<Employer> ();

        public Boolean isError { get; set; } = false;
        public String Message { get; set; } = String.Empty;
    }
}
