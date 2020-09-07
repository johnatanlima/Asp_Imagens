using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Work_Images.Models
{
    public class Carro
    {
        public int CarroId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(10, ErrorMessage = "Pra que tudo isso. Usa 10 caracteres!")]
        public string Modelo { get; set; }

        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        public string Foto { get; set; }

    }
}
