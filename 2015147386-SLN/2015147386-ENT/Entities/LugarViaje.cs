﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.Entities
{
    class LugarViaje
    {
        public TipoLugar TipoLugar { get; set; }
        public string Descripcion { get; set; }


        public LugarViaje()
        {
            TipoLugar = new TipoLugar();
        }
    }
}
