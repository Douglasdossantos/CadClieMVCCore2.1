using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeClientes.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório !")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data é obrigatória !")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage ="É obrigatório  Informar o Sexo!")]
        public string Sexo { get; set; }

        public Endereco EndCliente { get; set; }
    }
}
