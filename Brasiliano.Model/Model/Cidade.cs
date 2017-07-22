﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasiliano.Data.Model
{
    public class Cidade
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int EstadoID { get; set; }

        public Estado Estado { get; set; }
    }
}
