﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entidades
{
    public class Cliente
    {
        public int id {  get; set; }
        public int id_banco { get; set; }
        public string nombre { get; set; } = "";
        public string apellido { get; set; } = "";
        public int documento { get; set; }
        public string direccion { get; set; } = "";
        public string email { get; set; } = "";
        public int celular { get; set; }
        public string estado { get; set; } = "";

    }
}
