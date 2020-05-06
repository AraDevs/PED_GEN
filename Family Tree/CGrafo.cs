using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PED_GEN.Controllers
{
    class CGrafo
    {
        public List<CVertice> nodos;
        public List<CVertice> hijos;

        public CGrafo()
        {
            nodos = new List<CVertice>();
        }

        public CVertice AgregarVertice(string Valor)
        {
            CVertice nodo = new CVertice(Valor);
            nodos.Add(nodo);
            return nodo;
        }
        public void AgregarVertice(CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }
        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }
        public bool AgregarArco(String origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
            {
                throw new Exception("El nodo" + origen + "No existe dentro del grafo");
            }
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
            {
                throw new Exception("El nodo" + nDestino + "No existe dentro del grafo");
            }
            return AgregarArco(vOrigen, vnDestino);
        }
        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {

            if (origen.ListadeAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                origen.ListadeAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }


            return false;
        }

        public void DibujarGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.DibujarArco(g);
            }
            foreach (CVertice nodo in nodos)
            {
                nodo.DibujarVertice(g);
            }
        }
        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
            {
                if (nodoActual.DetectarPunto(posicionMouse))
                {
                    return nodoActual;
                }

            }
            return null;
        }
        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach (CArco arco in nodo.ListadeAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }
            DibujarGrafo(g);
        }
    }
}
