using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsEntrenador : clsPersona
    {
        public float EntreSalario;

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
        public System.Collections.ArrayList rutina;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetRutina()
        {
            if (rutina == null)
                rutina = new System.Collections.ArrayList();
            return rutina;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetRutina(System.Collections.ArrayList newRutina)
        {
            RemoveAllRutina();
            foreach (clsRutina oRutina in newRutina)
                AddRutina(oRutina);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddRutina(clsRutina newRutina)
        {
            if (newRutina == null)
                return;
            if (this.rutina == null)
                this.rutina = new System.Collections.ArrayList();
            if (!this.rutina.Contains(newRutina))
                this.rutina.Add(newRutina);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveRutina(clsRutina oldRutina)
        {
            if (oldRutina == null)
                return;
            if (this.rutina != null)
                if (this.rutina.Contains(oldRutina))
                    this.rutina.Remove(oldRutina);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllRutina()
        {
            if (rutina != null)
                rutina.Clear();
        }
    }
}
