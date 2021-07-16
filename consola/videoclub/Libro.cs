using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoclub
{
    public class Libro : Producto
    {
        //Constructor
        public Libro (int codigo, double precio, string descripcion, string autor,string isbn): base(codigo, precio, descripcion)
        {
            Autor = autor;
            Isbn = isbn;
        }
        //Métodos y Propiedades 
        public string MAutor{get {
                return Autor; 
            }
            set { 
                Autor=value; 
            }
        }
        public string MIsbn{
            get { return Isbn; }
            set { Isbn=value; }}
        //Atributos
        private string Autor;
        private string Isbn;}
    }
