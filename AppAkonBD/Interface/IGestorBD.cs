using AppAkonBD.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAkonBD.Interface
{
    public interface IGestorBD
    {
        IEnumerable<Usuario> ListadoUsuarios();

        int CrearUsuario(Usuario pUsuario);

        int ActualizarUsuario(int pIdUsuario);

        int BorrarUsuario(Usuario pUsuario);




    }
}
