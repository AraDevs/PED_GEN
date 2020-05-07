using System;
using Realms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PED_GEN.Controllers;
using PED_GEN.Models;
using PED_GEN.RealmConnection;

namespace PED_GEN
{
    public partial class Arbol_Familiar : Form
    {
        PeopleController peopleController = new PeopleController();

        People spouse = new People();
        List<People> allPeople = new List<People>();    //Listado de todas las personas para llenar cbo
        List<People> allPeople2 = new List<People>();    //Listado de todas las personas para llenar cbo
        List<People> relatives = new List<People>();
        private People person;
        private CGrafo grafo;
        private CVertice nuevoNodo;
        private CVertice Nodo;
        private CVertice NuevoOrigen;
        private CVertice NodoDestino;
        private int var_control = 0;
        int contador = 0;
        internal People Person { get => person; set => person = value; }
        public Arbol_Familiar()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region
        public void NodoPdr(string[] name, int posX, int posY)
        {
            Nodo = new CVertice();
            var_control = 2;
            if (Nodo != null)
            {
                if (posX < Nodo.Dimensiones.Width / 2)
                    posX = Nodo.Dimensiones.Width / 2;
                else if (posX > Pizarra.Size.Width - Nodo.Dimensiones.Width / 2)
                    posX = Pizarra.Size.Width - Nodo.Dimensiones.Width / 2;
                if (posY < Nodo.Dimensiones.Height / 2)
                    posY = Nodo.Dimensiones.Height / 2;
                else if (posY > Pizarra.Size.Height - Nodo.Dimensiones.Width / 2)
                    posY = Pizarra.Size.Height - Nodo.Dimensiones.Width / 2;
                Nodo.Posicion = new Point(posX, posY);
                Pizarra.Refresh();
                Nodo.DibujarVertice(Pizarra.CreateGraphics());
            }
            if ((NuevoOrigen = grafo.DetectarPunto(new Point(posX, posY))) != null)
            {
                var_control = 1;

            }
            if (Nodo != null && NuevoOrigen == null)
            {

                grafo.AgregarVertice(Nodo);
                Nodo.Valor = name[0];


                var_control = 0;
                Pizarra.Refresh();
                
            }
            
        }
        public void NodoHj(string name,int posX,int posY)
        {
            nuevoNodo = new CVertice();
            var_control = 2;
            if (nuevoNodo != null)
            {
                if (posX < nuevoNodo.Dimensiones.Width / 2)
                    posX = nuevoNodo.Dimensiones.Width / 2;
                else if (posX > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                    posX = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;
                if (posY < nuevoNodo.Dimensiones.Height / 2)
                    posY = nuevoNodo.Dimensiones.Height / 2;
                else if (posY > Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2)
                    posY = Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;
                nuevoNodo.Posicion = new Point(posX, posY);
                Pizarra.Refresh();
                nuevoNodo.DibujarVertice(Pizarra.CreateGraphics());
            }
            if ((NuevoOrigen = grafo.DetectarPunto(new Point(50, 50))) != null)
            {
                var_control = 1;
            }
            if (nuevoNodo != null && NuevoOrigen == null)
            {
                
                grafo.AgregarVertice(nuevoNodo);
                nuevoNodo.Valor = name;
                    
                    
                    //nuevoNodo = null;
                    var_control = 0;
                    Pizarra.Refresh();

                if (nuevoNodo != null)
                {

                    grafo.AgregarVertice(nuevoNodo);

                    
                        nuevoNodo.Valor = name;
                        if ((NodoDestino = grafo.DetectarPunto(new Point(posX, posY))) != null && NuevoOrigen != NodoDestino)
                        {
                        grafo.AgregarArco(Nodo, NodoDestino);
                        }
                    
                    var_control = 0;
                    NuevoOrigen = null;
                    NodoDestino = null;
                    Pizarra.Refresh();
                }          
                


            }
            

            nuevoNodo = null;
            var_control = 0;
            contador++;
            Pizarra.Refresh();
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainForm m = new mainForm();
            m.Show();
            this.Hide();
        }

        private void Arbol_Familiar_Load(object sender, EventArgs e)
        {
            
            int posX = Pizarra.Width / 2;
            
            int posY = 50;
            string[] name = person.name.Split(' ');
            string[] hijos= person.sons.Select(x => x.name).ToArray();
                        
            if(person.spouse != null)
            {
                string s = person.spouse.name.ToString();
                name[0] += ("\n"+ s);                
            }

            NodoPdr(name, posX, posY);

            contador = 0; int con = 0;

            foreach (string nombre in hijos)
            {
                string n = Espo(nombre, person.name);
                int poshX = (Pizarra.Width / (person.sons.Count + 1)) + contador;
                con++;
                NodoHj(n, poshX, 100);
                contador = poshX;
            }

            foreach (People son in person.sons)
            {
                if (son.sons != null)
                {
                    contador = 0;
                    int poshX = Pizarra.Width / 2;
                    Nodo = grafo.BuscarVertice(son.name);
                    foreach (People s in son.sons)
                    {
                        NodoHj(s.name, poshX * contador, 200);
                    }
                }
            }
        }
        string Espo(string n, string p)
        {
            People selectedP;
            List<People> allPeople = new List<People>();
            string[] name = person.name.Split(' ');
            int count = 0;
            while (n != name[count])
            {
                count++;
            }

            selectedP = allPeople[count];            
            Person = selectedP;
            count = 0;
            if (person.spouse != null)
            {
                n += ("\n" + person.spouse.name);
            }

            while (p != name[count])
            {
                count++;
            }

            selectedP = allPeople[count];
            Person = selectedP;

            return n;
        }
    }
}

