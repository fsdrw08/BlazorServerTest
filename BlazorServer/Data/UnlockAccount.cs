using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Data
{
    public class Extra_vars
    {
        [Required(ErrorMessage = "Task name is required")]
        [StringLength(15, ErrorMessage = "Name is too long.")]
        public string user { get; set; }

    }
    public class UnlockAccount
    {
        public Extra_vars extra_vars { get; set; }
    }

}