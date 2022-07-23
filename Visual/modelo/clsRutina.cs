using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsRutina
    {
        public int RutId;
        public string RutNombre;
        public string RutTipoTrenEjer;

        public System.Collections.ArrayList ejercicio;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetEjercicio()
        {
            if (ejercicio == null)
                ejercicio = new System.Collections.ArrayList();
            return ejercicio;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetEjercicio(System.Collections.ArrayList newEjercicio)
        {
            RemoveAllEjercicio();
            foreach (clsEjercicio oEjercicio in newEjercicio)
                AddEjercicio(oEjercicio);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddEjercicio(clsEjercicio newEjercicio)
        {
            if (newEjercicio == null)
                return;
            if (this.ejercicio == null)
                this.ejercicio = new System.Collections.ArrayList();
            if (!this.ejercicio.Contains(newEjercicio))
            {
                this.ejercicio.Add(newEjercicio);
                newEjercicio.AddRutina(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveEjercicio(clsEjercicio oldEjercicio)
        {
            if (oldEjercicio == null)
                return;
            if (this.ejercicio != null)
                if (this.ejercicio.Contains(oldEjercicio))
                {
                    this.ejercicio.Remove(oldEjercicio);
                    oldEjercicio.RemoveRutina(this);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllEjercicio()
        {
            if (ejercicio != null)
            {
                System.Collections.ArrayList tmpEjercicio = new System.Collections.ArrayList();
                foreach (clsEjercicio oldEjercicio in ejercicio)
                    tmpEjercicio.Add(oldEjercicio);
                ejercicio.Clear();
                foreach (clsEjercicio oldEjercicio in tmpEjercicio)
                    oldEjercicio.RemoveRutina(this);
                tmpEjercicio.Clear();
            }
        }
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
            {
                this.usuario.Add(newUsuario);
                newUsuario.AddRutina(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveUsuario(clsUsuario oldUsuario)
        {
            if (oldUsuario == null)
                return;
            if (this.usuario != null)
                if (this.usuario.Contains(oldUsuario))
                {
                    this.usuario.Remove(oldUsuario);
                    oldUsuario.RemoveRutina(this);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllUsuario()
        {
            if (usuario != null)
            {
                System.Collections.ArrayList tmpUsuario = new System.Collections.ArrayList();
                foreach (clsUsuario oldUsuario in usuario)
                    tmpUsuario.Add(oldUsuario);
                usuario.Clear();
                foreach (clsUsuario oldUsuario in tmpUsuario)
                    oldUsuario.RemoveRutina(this);
                tmpUsuario.Clear();
            }
        }
    }
}
