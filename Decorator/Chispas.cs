using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Chispas : HeladoDecorador /* Hereda del decorador */
    {
        public Chispas(ComponenteHelado helado) : base(helado) { } /* Obtiene el componente base */
        public override double Precio => _helado.Precio + 0.25;
        public override string Descripcion => string.Format($"{_helado.Descripcion}, Chispas");
    }
}
