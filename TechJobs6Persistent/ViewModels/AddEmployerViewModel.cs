using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required]
        [StringLength(255,MinimumLength = 1)]
        public string? Name { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string? Location { get; set; }

        public Boolean isError { get; set; } = false;
        public String Message { get; set; } = String.Empty;
    }
}
