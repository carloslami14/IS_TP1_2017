﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Servicio
    {
        public string nombre { get; set; }
        public Tipo tipo { get; set; }

        public Servicio(string nombre, Tipo tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return nombre + "," + tipo.tipo + "," + tipo.rubro;
        }
    }
}
