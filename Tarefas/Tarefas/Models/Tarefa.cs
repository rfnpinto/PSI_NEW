﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarefas.Models
{
    public class Tarefa
    {
        public int ID { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O Titulo deve ter menos de 50 caracteres;")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "O tamanho maximo da nota é 250 caracteres;")]
        public string Nota { get; set; }

        [Required]
        public bool Lido { get; set; }
    }
}