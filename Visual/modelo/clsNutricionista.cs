using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsNutricionista : clsPersona
    {
        public string NutriTitulo;
        public float NutriSalario;

        public System.Collections.ArrayList planAlimentacion;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetPlanAlimentacion()
        {
            if (planAlimentacion == null)
                planAlimentacion = new System.Collections.ArrayList();
            return planAlimentacion;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetPlanAlimentacion(System.Collections.ArrayList newPlanAlimentacion)
        {
            RemoveAllPlanAlimentacion();
            foreach (clsPlanAlimentacion oPlanAlimentacion in newPlanAlimentacion)
                AddPlanAlimentacion(oPlanAlimentacion);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddPlanAlimentacion(clsPlanAlimentacion newPlanAlimentacion)
        {
            if (newPlanAlimentacion == null)
                return;
            if (this.planAlimentacion == null)
                this.planAlimentacion = new System.Collections.ArrayList();
            if (!this.planAlimentacion.Contains(newPlanAlimentacion))
                this.planAlimentacion.Add(newPlanAlimentacion);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemovePlanAlimentacion(clsPlanAlimentacion oldPlanAlimentacion)
        {
            if (oldPlanAlimentacion == null)
                return;
            if (this.planAlimentacion != null)
                if (this.planAlimentacion.Contains(oldPlanAlimentacion))
                    this.planAlimentacion.Remove(oldPlanAlimentacion);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllPlanAlimentacion()
        {
            if (planAlimentacion != null)
                planAlimentacion.Clear();
        }
    }
}
