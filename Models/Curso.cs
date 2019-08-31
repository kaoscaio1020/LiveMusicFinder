using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiveMusicFInder.Models
{
    public class Curso
    {
        [Key]
        public int Id { get;set; }
        [Required]
        public string Nome { get;set; }
        public DateTime DataInicial { get;set; }
        public DateTime DataFInal { get;set; }
        public List<Cliente> Clientes { get; set; }
    }
}