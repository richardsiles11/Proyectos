﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Consulta
    {
        public int consultaId { get; set; }
        public string fechaHora { get; set; }
        public string observacion { get; set; }
        public string diagnostico { get; set; }
        public string estudio { get; set; }
        public int citaId { get; set; }

        public Consulta() { }
    }
}