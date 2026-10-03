using System.ComponentModel.DataAnnotations;

namespace Contact_systems_in_MVC.Models
{
    public class ContatoModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Email do Contato")]
        [EmailAddress(ErrorMessage = "O Email Informado não e Valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Telefone do Contato")]
        [Phone(ErrorMessage = "O Telefone Informado não e Valido")]
        public string Telefone { get; set; }

       

    }
}
