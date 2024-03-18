using System.ComponentModel.DataAnnotations;

namespace ASP_NET_MVC_LOGIN_LOGOUT_2.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="First Name")]
        [Required]
        public string StuFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string StuLastName { get; set; }

        [Display(Name = "City Name")]
        [Required]
        public string City { get; set; }

        [Display(Name ="State Name")]
        [Required]
        public string State { get; set; }
    }
}
