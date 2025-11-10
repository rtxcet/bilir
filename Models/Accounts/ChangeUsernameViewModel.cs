using System.ComponentModel.DataAnnotations;

namespace bilir.Models
{
    public class ChangeUsernameViewModel
    {
        [Required]
        [Display(Name = "Yeni Kullanıcı Adı")]
        public string NewUsername { get; set; }
    }
}
