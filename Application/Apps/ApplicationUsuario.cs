using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public class ApplicationUsuario : IAppUsuario
    {
        private readonly IUsuario _usuario;

        public ApplicationUsuario(IUsuario usuario)
        {
            _usuario = usuario;
        }

        public void Add(Usuario Entity)
        {
            _usuario.Add(Entity);
        }

        public void Delete(Usuario Entity)
        {
            _usuario.Delete(Entity);
        }

        public Usuario GetEntity(int Id)
        {
            return _usuario.GetEntity(Id);
        }

        public List<Usuario> List()
        {
            return _usuario.List();
        }

        public void Update(Usuario Entity)
        {
            _usuario.Update(Entity);
        }
    }
}
