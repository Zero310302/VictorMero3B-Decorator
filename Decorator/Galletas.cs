using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Galletas : HeladoDecorador /* Hereda del decorador */
    {
        public Galletas(ComponenteHelado helado) : base(helado) { } /* Obtiene el componente base */
        public override double Precio => _helado.Precio + 0.5;
        public override string Descripcion => string.Format($"{_helado.Descripcion}, Galletas");
    }
}
