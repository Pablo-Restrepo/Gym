using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsEjercicio
    {
        public int EjerCodigo;
        public string EjerNombre;
        public int EjerSeries;
        public int EjerRepeSeries;
        public string EjerDescanso;
        public string EjerDescripcion;
        public string EjerMusculoEjer;
        public byte[] EjerFoto = new byte[0];
        public string EjerTipoTrenEjer;

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
                newRutina.AddEjercicio(this);
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
                    oldRutina.RemoveEjercicio(this);
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
                    oldRutina.RemoveEjercicio(this);
                tmpRutina.Clear();
            }
        }
    }
}
