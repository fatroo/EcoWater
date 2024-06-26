﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoWater.Models
{
    public class RegistrosPoluicao
    {
        [Key]
        public string Id_Registro { get; set; }
        [ForeignKey("Embarcacoes")]
        public int Id_Embarcacao { get; set; }
        public Embarcacoes? Embarcacoes { get; set; }
        [Required]
        public string Data { get; set; }
        [Required]
        public string Hora { get; set; }
        [Required]
        public string Localizacao { get; set; }
        [Required]
        public string Tipo_Poluicao { get; set; }
        [Required]
        public string Quantidade_Poluida { get; set; }
        [Required]
        public string Testemunhas { get; set; }
    }
}
