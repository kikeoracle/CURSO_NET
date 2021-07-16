using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoclub
{
    public class CompactDisc : Producto
    {
        //Constructor
        public CompactDisc(int codigo, double precio, string descripcion, string artista, string discografica) : base(codigo, precio, descripcion)
        {
            Artista = artista;
            Discografica = discografica;
        }
        // ́Métodos y Propiedades
        public string MArtista
        {
            get { return Artista; }
            set { Artista = value; }
        }
        public string MDiscografica
        {
            get { return Discografica; }
            set { Discografica = value; }
        }
        //Atributos
        private string Artista;
        private string Discografica;
    }
}
