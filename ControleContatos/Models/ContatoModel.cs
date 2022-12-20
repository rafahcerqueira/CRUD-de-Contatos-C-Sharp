
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "* Campo nome é obrigatório!")]
        public string? Nome { get; set; }
        
        public string? Email { get; set; }

        //[Required(ErrorMessage = "* Campo celular é obrigatório!")]
        [Phone(ErrorMessage = "O número inserido não é válido")]
        public string? Celular { get; set; }
    }
}
