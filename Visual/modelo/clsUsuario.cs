using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsUsuario
    {
        public string usuLogin;
        public string UsuPassword;
        public string UsuCorreo;

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
            {
                this.rutina.Add(newRutina);
                newRutina.AddUsuario(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveRutina(clsRutina oldRutina)
        {
            if (oldRutina == null)
                return;
            if (this.rutina != null)
                if (this.rutina.Contains(oldRutina))
                {
                    this.rutina.Remove(oldRutina);
                    oldRutina.RemoveUsuario(this);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllRutina()
        {
            if (rutina != null)
            {
                System.Collections.ArrayList tmpRutina = new System.Collections.ArrayList();
                foreach (clsRutina oldRutina in rutina)
                    tmpRutina.Add(oldRutina);
                rutina.Clear();
                foreach (clsRutina oldRutina in tmpRutina)
                    oldRutina.RemoveUsuario(this);
                tmpRutina.Clear();
            }
        }
        public System.Collections.ArrayList Compra;
        public System.Collections.ArrayList Compra1;

    }
}
