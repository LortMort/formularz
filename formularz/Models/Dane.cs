using System.ComponentModel.DataAnnotations;

namespace formularz.Models
{
    public class Dane
    {
     
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Podaj potwierdzenie hasła")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set;}

        [Range(10,80)]
        public int Wiek { get; set; }



    }
}
