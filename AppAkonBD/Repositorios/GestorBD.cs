using AppAkonBD.Interface;
using AppAkonBD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAkonBD.Repositorios
{
    public class GestorBD : IGestorBD
    {
        public int ActualizarUsuario(int pIdUsuario)
        {
            throw new NotImplementedException();
        }

        public int BorrarUsuario(Usuario pUsuario)
        {
            throw new NotImplementedException();
        }

        public int CrearUsuario(Usuario pUsuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ListadoUsuarios()
        {
            List<Usuario> ListadoRetornar = new List<Usuario>();

            using (AlissEntities contextoBD = new AlissEntities())
            {
                ListadoRetornar = contextoBD.Usuarios.ToList();
            }

            return ListadoRetornar;
        }
    }
}
