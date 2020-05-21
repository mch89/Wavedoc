using System;
using System.Collections.Generic;
using System.Text;

namespace WavedocProyecto
{
   public class MasterPageItem
    {
        public String Titulo { get; set; }
        public String Icono { get; set; }
        public Type PaginaHija { get; set; }
    }
}
