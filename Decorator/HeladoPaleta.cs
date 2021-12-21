using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HeladoPaleta : ComponenteHelado /* Hereda del componente base */
    {
        public override double Precio => 2.00;
        public override string Descripcion => "Helado en paleta";
    }
}
