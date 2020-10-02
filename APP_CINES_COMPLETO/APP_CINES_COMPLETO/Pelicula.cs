using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_CINES_COMPLETO
{
    class Pelicula
    {
        private int id;
        private string nombre;
        private int tipo;
        private PictureBox tapa=new PictureBox();
        public Pelicula()
        {

        }
        public string TostringPelicula()
        {
            return id + " - " + nombre;
        }

        public int Pid { get => id; set => id = value; }
        public string Pnombre { get => nombre; set => nombre = value; }
        public int Ptipo { get => tipo; set => tipo = value; }
        public PictureBox Ptapa { get => tapa; set => tapa = value; }
    }
}
