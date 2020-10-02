using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_CINES_COMPLETO
{
    class Usuario
    {
        private string usuario;
        private string pass;
        private string tipo;

        public Usuario()
        {

        }
        public string Pusuario { get => usuario; set => usuario = value; }
        public string Ppass { get => pass; set => pass = value; }
        public string Ptipo { get => tipo; set => tipo = value; }
    }
}
