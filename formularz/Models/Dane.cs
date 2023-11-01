using System.ComponentModel.DataAnnotations;

namespace formularz.Models
{
    public class Dane
    {

        [Required(ErrorMessage = "Pole 'Imię' jest wymagane.")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        [Display(Name = "Imie: ")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Pole 'Nazwisko' jest wymagane.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        [Display(Name = "Nazwisko: ")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Pole 'Adres e-mail' jest wymagane.")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres e-mail.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole 'Hasło' jest wymagane.")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną małą literę, jedną dużą literę i jedną cyfrę.")]
        [Display(Name = "Hasło: ")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Pole 'Potwierdzenie Hasła' jest wymagane.")]
        [Compare("Haslo", ErrorMessage = "Hasło i potwierdzenie hasła nie pasują do siebie.")]
        [Display(Name = "Potwierdzenie Hasła: ")]
        public string PotwierdzenieHasla { get; set; }

        [Phone]
        [Display(Name = "Telefon: ")]
        public string Telefon { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi wynosić od 10 do 80 lat.")]
        [Display(Name = "Wiek: ")]
        public int Wiek { get; set; }

        [Display(Name = "Miasto: ")]
        public string Miasto { get; set; }
        public enum Miasta { Krakow = 1, Warszawa = 2, Gdańsk = 3, Poznań = 4, Wrocław = 5 }


    }
}
