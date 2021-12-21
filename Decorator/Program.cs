using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponenteHelado Cono = new HeladoCono(); /* Se llama a la clase desde el componente */
            Cono = new Chispas(Cono); /* Se agrega la clase decoradora */


            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("Descripción de compra: " + Cono.Descripcion + "\nEl precio total es: $" + Cono.Precio);
            Console.WriteLine("**************************************************************************************");

            /*
            ComponenteHelado Vaso = new HeladoVaso();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("Descripción de compra: " + Vaso.Descripcion + "\nEl precio total es: $" + Vaso.Precio);
            Console.WriteLine("**************************************************************************************");

            ComponenteHelado Paleta = new HeladoPaleta();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("Descripción de compra: " + Paleta.Descripcion + "\nEl precio total es: $" + Paleta.Precio);
            Console.WriteLine("**************************************************************************************");
            */
        }
    }
}
