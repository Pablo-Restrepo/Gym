using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsMaquina
    {
        public int MaqCodigo;
        public string MaqNombre;
        public float MaqPeso;
        public string MaqTipoMaquina;
        public string MaqMusculoTrabaja;
        public string MaqMarca;
        public byte[] MaqFoto = new byte[0];

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
                this.ejercicio.Add(newEjercicio);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveEjercicio(clsEjercicio oldEjercicio)
        {
            if (oldEjercicio == null)
                return;
            if (this.ejercicio != null)
                if (this.ejercicio.Contains(oldEjercicio))
                    this.ejercicio.Remove(oldEjercicio);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllEjercicio()
        {
            if (ejercicio != null)
                ejercicio.Clear();
        }
    }
}
