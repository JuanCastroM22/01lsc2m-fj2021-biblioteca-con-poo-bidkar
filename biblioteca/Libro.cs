using System;
using System.Collections.Generic;

namespace biblioteca
{
    class Libro
    {
        public int Id;
        public string Titulo;
        public Editorial Editorial;
        public DateTime FechaDeEdición;
        public List<Autor> Autores;
        public List<Categoria> Categorías;
        public int NúmeroDePáginas;
        public string Isbn;
        public string Idioma;
        public string Portada;
    }
}