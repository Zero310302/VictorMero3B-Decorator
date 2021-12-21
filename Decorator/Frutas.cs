using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    public class Frutas : HeladoDecorador /* Hereda del decorador */
    {
        public Frutas(ComponenteHelado helado) : base(helado) { } /* Obtiene el componente base */
        public override double Precio => _helado.Precio + 0.75;
        public override string Descripcion => string.Format($"{_helado.Descripcion}, Frutas");
    }
}