using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Preparativos;

namespace TDD
{
    public class MaquinaCafe
    {
        
        private Cafetera cafetera;
        private Vaso vasosPequenos;
        private Vaso vasosMedianos;
        private Vaso vasosGrandes;
        private Azuquero azuquero;

        
        public Vaso getTipoVaso(string tipoDeVaso)
        {
            if(tipoDeVaso == "pequeno")
            {
                return vasosPequenos;
            } 
            else if (tipoDeVaso == "mediano")
            {
                return vasosMedianos;
            }
            else if (tipoDeVaso == "grande")
            {
                return vasosGrandes;
            }
            return null;
        }

        public void getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, Azuquero cantidadDeAzucar)
        {

        }

        public void setCafetera(Cafetera cafetera) => this.cafetera = cafetera;

        public void setAzucarero(Azuquero azuquero) => this.azuquero = azuquero;

        public void setVasosGrande(Vaso vasosGrande) => this.vasosGrandes = vasosGrande;

        public void setVasosMediano(Vaso vasosMediano) => this.vasosMedianos = vasosMediano;

        public void setVasosPequenos(Vaso vasosPequenos) => this.vasosPequenos = vasosPequenos;

        public Vaso getVasosGrande() => this.vasosGrandes;
        public Vaso getVasosMediano() => this.vasosMedianos;
        public Vaso getVasosPequenos() => this.vasosPequenos;
    }
}
