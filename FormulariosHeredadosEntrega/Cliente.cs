using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulariosHeredadosEntrega
{
        public class Cliente
        {
            private string nombre;
            private string apellidos;
            private string ciudad;
            private string email;
            private string comentario;
            private bool vip;
            private string foto;

            public Cliente(string nombre, string apellidos, string ciudad, string email, string comentario, bool vip, string foto)
            {
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.ciudad = ciudad;
                this.email = email;
                this.comentario = comentario;
                this.vip = vip;
                this.foto = foto;
            }

            // Getters
            public string GetNombre() { return nombre; }
            public string GetApellidos() { return apellidos; }
            public string GetCiudad() { return ciudad; }
            public string GetEmail() { return email; }
            public string GetComentario() { return comentario; }
            public bool GetVip() { return vip; }
            public string GetFoto() { return foto; }
    }
}
