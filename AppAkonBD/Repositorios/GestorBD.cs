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
            int n = 0;
            using (AlissEntities contextoBD = new AlissEntities())
            {
                contextoBD.Usuarios.Add(pUsuario);
               n = contextoBD.SaveChanges();
            }
            return n;
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
