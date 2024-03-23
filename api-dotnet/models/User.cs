using System;
using System.ComponentModel.DataAnnotations;

namespace api_dotnet.models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome do usuário deve ter entre 2 e 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O e-mail do usuário é obrigatório.")]
        [EmailAddress(ErrorMessage = "O e-mail do usuário não é válido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "A senha do usuário é obrigatória.")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "A senha do usuário deve ter entre 6 e 40 caracteres.")]
        public string Password { get; set; }

        public User()
        {
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }
    }
}
