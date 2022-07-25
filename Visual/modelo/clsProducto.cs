using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.modelo
{
    class clsProducto
    {
        private int prodCodBarras;
        private string prodNombre;
        private float prodPrecio;
        private int prodCantidad;
        //private string prodFoto;
        private byte[] prodFoto = new byte[0];
        private string prodTipoProd;

        public System.Collections.ArrayList Compra1;

        public int ProdCodBarras { get => prodCodBarras; set => prodCodBarras = value; }
        public string ProdNombre { get => prodNombre; set => prodNombre = value; }
        public float ProdPrecio { get => prodPrecio; set => prodPrecio = value; }
        public int ProdCantidad { get => prodCantidad; set => prodCantidad = value; }
        public byte[] ProdFoto { get => prodFoto; set => prodFoto = value; }
        public string ProdTipoProd { get => prodTipoProd; set => prodTipoProd = value; }
    }
}
