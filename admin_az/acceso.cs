using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_az
{
    class acceso
    {
        public bool login(string nombre_user, string password)
        {

            var db = new softcitaEntities();

            var usuario = db.usuarios.FirstOrDefault(u => u.usuario1 == nombre_user && u.clave == password && u.estado ==true);



            if (usuario != null)
            {
                Global.idusuario = usuario.iduser.ToString();
                Global.tipoUsuario = usuario.idtipo.ToString();
                Global.nombre = usuario.nombre.ToString();
                return true;
            }
            return false;


        }


    }
}
