using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HeladoCono : ComponenteHelado /* Hereda del componente base */
    {
        public override double Precio => 5.00;
        public override string Descripcion => "Helado en cono";

    }
}
