using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.Finanzas.Domain.POCOS.Context
{
    public class EntityConfiguracionesContext
    {
        public string result { get; set; }
        public int code { get; set; }
        public int usuario_id { get; set; }
        public bool notificaciones_activas { get; set; }
    }
}
