using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsPlanAlimentacion
    {
        public int PlanId;
        public string PlanNombre;
        public string PlanDesayuno;
        public string PlanComida;
        public string PlanCena;
        public string PlanSnak;

        public System.Collections.ArrayList usuario;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetUsuario()
        {
            if (usuario == null)
                usuario = new System.Collections.ArrayList();
            return usuario;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetUsuario(System.Collections.ArrayList newUsuario)
        {
            RemoveAllUsuario();
            foreach (clsUsuario oUsuario in newUsuario)
                AddUsuario(oUsuario);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddUsuario(clsUsuario newUsuario)
        {
            if (newUsuario == null)
                return;
            if (this.usuario == null)
                this.usuario = new System.Collections.ArrayList();
            if (!this.usuario.Contains(newUsuario))
                this.usuario.Add(newUsuario);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveUsuario(clsUsuario oldUsuario)
        {
            if (oldUsuario == null)
                return;
            if (this.usuario != null)
                if (this.usuario.Contains(oldUsuario))
                    this.usuario.Remove(oldUsuario);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllUsuario()
        {
            if (usuario != null)
                usuario.Clear();
        }
    }
}
