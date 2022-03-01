using Infra.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Usuarios;

namespace Infra.Repositories.Usuarios
{
    public class UsuarioRepository : RepositoryGeneric<Usuario>, IUsuario
    {

    }
}
