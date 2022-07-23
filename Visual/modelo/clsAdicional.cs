using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsAdicional
    {
        public string AdiNombre;
        public float AdiPrecio;
        public string AdiDescripcion;

        public System.Collections.ArrayList suscripcion;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetSuscripcion()
        {
            if (suscripcion == null)
                suscripcion = new System.Collections.ArrayList();
            return suscripcion;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetSuscripcion(System.Collections.ArrayList newSuscripcion)
        {
            RemoveAllSuscripcion();
            foreach (clsSuscripcion oSuscripcion in newSuscripcion)
                AddSuscripcion(oSuscripcion);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddSuscripcion(clsSuscripcion newSuscripcion)
        {
            if (newSuscripcion == null)
                return;
            if (this.suscripcion == null)
                this.suscripcion = new System.Collections.ArrayList();
            if (!this.suscripcion.Contains(newSuscripcion))
            {
                this.suscripcion.Add(newSuscripcion);
                newSuscripcion.AddAdicional(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveSuscripcion(clsSuscripcion oldSuscripcion)
        {
            if (oldSuscripcion == null)
                return;
            if (this.suscripcion != null)
                if (this.suscripcion.Contains(oldSuscripcion))
                {
                    this.suscripcion.Remove(oldSuscripcion);
                    oldSuscripcion.RemoveAdicional(this);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllSuscripcion()
        {
            if (suscripcion != null)
            {
                System.Collections.ArrayList tmpSuscripcion = new System.Collections.ArrayList();
                foreach (clsSuscripcion oldSuscripcion in suscripcion)
                    tmpSuscripcion.Add(oldSuscripcion);
                suscripcion.Clear();
                foreach (clsSuscripcion oldSuscripcion in tmpSuscripcion)
                    oldSuscripcion.RemoveAdicional(this);
                tmpSuscripcion.Clear();
            }
        }
    }
}
