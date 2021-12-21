using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /* El decorador hereda del componente */
    public abstract class HeladoDecorador : ComponenteHelado
    {
        /* A su vez, el decorador tiene un componente dentro*/
        protected ComponenteHelado _helado;
        public HeladoDecorador(ComponenteHelado helado)
        {
            _helado = helado;
        }
    }
}