using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tessa.Dtos
{
    public class RegisterDto
    {

        [Required]
        public string DisplayName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$",
            ErrorMessage ="პაროლი უნდა მოიცავდეს 1 მაღალ სიმბოლოს, 1 დაბალს, 1 ნომერს, ანბანის ასოებს და უნდა იყოს მინიმუმ 6 ასოსგან შემდგარი")]
        public string Password { get; set; }

    }
}
