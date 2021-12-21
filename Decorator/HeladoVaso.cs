using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HeladoVaso : ComponenteHelado /* Hereda del componente base */
    {
        public override double Precio => 7.00; /* Se sobreescriben los atributos */
        public override string Descripcion => "Helado en vaso";
    }
}
