using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EaseCost.ApiEmail.Models
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato de e-mail inválido.")]
        public string email { get; set; }
    }
}
