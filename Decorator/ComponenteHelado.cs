using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /* Se define el componente base con sus operaciones */
    public abstract class ComponenteHelado /* El componente se define bajo una clase abstracta */
    {
        public abstract double Precio { get; }
        public abstract string Descripcion { get; }
    }
}
