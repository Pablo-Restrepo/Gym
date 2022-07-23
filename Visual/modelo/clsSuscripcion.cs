using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsSuscripcion
    {
        public string SusNombre;
        public float SusPrecio;
        public string SusDescripcion;

        public System.Collections.ArrayList Compra;
        public System.Collections.ArrayList adicional;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetAdicional()
        {
            if (adicional == null)
                adicional = new System.Collections.ArrayList();
            return adicional;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetAdicional(System.Collections.ArrayList newAdicional)
        {
            RemoveAllAdicional();
            foreach (clsAdicional oAdicional in newAdicional)
                AddAdicional(oAdicional);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddAdicional(clsAdicional newAdicional)
        {
            if (newAdicional == null)
                return;
            if (this.adicional == null)
                this.adicional = new System.Collections.ArrayList();
            if (!this.adicional.Contains(newAdicional))
            {
                this.adicional.Add(newAdicional);
                newAdicional.AddSuscripcion(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveAdicional(clsAdicional oldAdicional)
        {
            if (oldAdicional == null)
                return;
            if (this.adicional != null)
                if (this.adicional.Contains(oldAdicional))
                {
                    this.adicional.Remove(oldAdicional);
                    oldAdicional.RemoveSuscripcion(this);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllAdicional()
        {
            if (adicional != null)
            {
                System.Collections.ArrayList tmpAdicional = new System.Collections.ArrayList();
                foreach (clsAdicional oldAdicional in adicional)
                    tmpAdicional.Add(oldAdicional);
                adicional.Clear();
                foreach (clsAdicional oldAdicional in tmpAdicional)
                    oldAdicional.RemoveSuscripcion(this);
                tmpAdicional.Clear();
            }
        }
    }
}
