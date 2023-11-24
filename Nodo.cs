using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Sigfrido_Encinas
{
    public class Nodo
    {
        private Nodo _siguiente;
        public Persona Persona = new Persona();

        public Nodo()
        {
            _siguiente = null;
        }
        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
