using ProAspNetCoreMvcValidation.Util.Validation;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProAspNetCoreMvcValidation.Models
{
    public class Compra
    {
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Informe se o número tem WhatsApp")]
        public bool NumeroComWhatsApp { get; set; }

        [Range(minimum: 5, maximum: 10, ErrorMessage = "Valor mínimo 5 e máximo 8")]
        public int Quantidade { get; set; }

        [StringLength(10)]
        public string Mensagem { get; set; }

        [MarcarComoTrue(ErrorMessage = "Você deve marcar como true")]
        public bool TermosEntrega { get; set; }
    }

}
