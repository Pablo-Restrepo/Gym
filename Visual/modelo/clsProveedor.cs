using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsProveedor
    {
        public int ProveNit;
        public string ProveNombre;
        public long ProveTelefono;
        public string ProveDireccion;
        public string ProveCorreo;

        public System.Collections.ArrayList producto;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetProducto()
        {
            if (producto == null)
                producto = new System.Collections.ArrayList();
            return producto;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetProducto(System.Collections.ArrayList newProducto)
        {
            RemoveAllProducto();
            foreach (clsProducto oProducto in newProducto)
                AddProducto(oProducto);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddProducto(clsProducto newProducto)
        {
            if (newProducto == null)
                return;
            if (this.producto == null)
                this.producto = new System.Collections.ArrayList();
            if (!this.producto.Contains(newProducto))
                this.producto.Add(newProducto);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveProducto(clsProducto oldProducto)
        {
            if (oldProducto == null)
                return;
            if (this.producto != null)
                if (this.producto.Contains(oldProducto))
                    this.producto.Remove(oldProducto);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllProducto()
        {
            if (producto != null)
                producto.Clear();
        }
    }
}
