using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.Controllers
{
    class CLista
    {
        private CVertice aElemento;
        private CLista aSublista;
        private int aPeso;

        public CLista()
        {
            aElemento = null;
            aSublista = null;
            aPeso = 0;
        }
        public CLista(CLista plista)
        {
            if (plista != null)
            {
                aElemento = plista.aElemento;
                aSublista = plista.aSublista;
                aPeso = plista.aPeso;
            }
        }
        public CLista(CVertice pElemento, CLista pSubLista, int pPeso)
        {
            aElemento = pElemento;
            aSublista = pSubLista;
            aPeso = pPeso;
        }
        public CVertice Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }
        public CLista SubLista
        {
            get { return aSublista; }
            set { aSublista = value; }
        }
        public int Peso
        {
            get { return aPeso; }
            set { aPeso = value; }
        }
        public bool EsVacia()
        {
            return aElemento == null;
        }
        public void Agregar(CVertice pElemento, int pPeso)
        {
            if (pElemento != null)
            {
                if (aElemento == null)
                {
                    aElemento = new CVertice(pElemento.Valor);
                    aPeso = pPeso;
                    aSublista = new CLista();
                }
                else
                {
                    if (!ExisteElemento(pElemento))
                    {
                        aSublista.Agregar(pElemento, pPeso);
                    }
                }
            }
        }
        public void Eliminar(CVertice pElemento)
        {
            if (aElemento != null)
            {
                if (aElemento.Equals(pElemento))
                {
                    aElemento = aSublista.aElemento;
                    aSublista = aSublista.SubLista;
                }
                else
                {
                    aSublista.Eliminar(pElemento);
                }
            }
        }
        public int NroElementos()
        {
            if (aElemento != null)
            {
                return 1 + aSublista.NroElementos();
            }
            else
            {
                return 0;
            }
        }
        public object IesimoElemento(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aElemento;
                }
                else
                {
                    return aSublista.IesimoElemento(posicion - 1);
                }
            }
            else
            {
                return null;
            }
        }
        public object IesimoElementoPeso(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aPeso;
                }
                else
                {
                    return aSublista.IesimoElementoPeso(posicion - 1);
                }
            }
            else
            {
                return 0;
            }
        }
        public bool ExisteElemento(CVertice pElemento)
        {
            if ((aElemento != null) && (pElemento != null))
            {
                return (aElemento.Equals(pElemento) || (aSublista.ExisteElemento(pElemento)));
            }
            else
            {
                return false;
            }
        }
        public int PosicionElemento(CVertice pElemento)
        {
            if ((aElemento != null) || (ExisteElemento(pElemento)))
            {
                if (aElemento.Equals(pElemento))
                {
                    return 1;
                }
                else
                {
                    return 1 + aSublista.PosicionElemento(pElemento);
                }
            }
            else
                return 0;
        }
    }
}
