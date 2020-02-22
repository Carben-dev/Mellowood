using System.ComponentModel.DataAnnotations;

namespace Mellowood.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}