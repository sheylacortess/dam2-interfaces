using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMDi
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;
        private bool nuevo; 
        private string foto;

        public Libro (string t, string a, string e,bool n, string f)
        {
            this.titulo = t;
            this.autor = a; 
            this.editorial = e; 
            this.nuevo = n;
            this.foto = f;
        }

        public void setTitulo (string t)
        {
            titulo = t;

        }
        public string getTitulo()
        {
            return titulo;
        }

        public void setAutor(string a)
        {
            autor = a;
        }
        public string getAutor()
        {
            return autor;
        }
        public void setEditorial(string e)
        {
            editorial = e;
        }
        public string getEditorial()
        {
            return editorial;
        }
        public void setNuevo(bool n) 
        {
            nuevo = n; 
        }
        public bool getNuevo() 
        { 
            return nuevo; 
        }

        public void setFoto(string f) 
        { 
            foto = f; 
        }
        public string getFoto() 
        { 
            return foto; 
        }


    }
}
