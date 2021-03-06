﻿using System;
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
using System.Drawing.Imaging;

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
        int contadorY = 1;
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
        public void NodoHj(string name, int posX, int posY)
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
            string[] hijos = person.sons.Select(x => x.name).ToArray();

            if (person.spouse != null)
            {
                string s = person.spouse.name.ToString();
                name[0] += ("\n" + s);
            }

            NodoPdr(name, posX, posY);
            contador = 0; int con = 0;
            int[] posH = new int[person.sons.Count];

            foreach (People nombre in person.sons)
            {
                //string Nom = nombre.name;
                int poshX = (Pizarra.Width / (person.sons.Count + 1)) + contador;

                posH[con] = poshX;
                NodoHj(Namespo(nombre), poshX, 100);
                con++;
                contador = poshX;
            }
            con = 0; contador = 0;
            foreach (People son in person.sons)
            {
                if (son.sons != null)
                {
                    Nodo = grafo.BuscarVertice(Namespo(son));
                    foreach (People s in son.sons)
                    {
                        int poshX = (posH[0] / (s.sons.Count + 1)) + contador;
                        contador += poshX;
                        NodoHj(Namespo(s), poshX, 200);
                    }
                }
                con++;
            }

            string Namespo(People persona)
            {
                if (persona.spouse != null)
                {
                    string nombre = persona.name + "\n" + persona.spouse;
                    return nombre;
                }
                return persona.name;
            }
            void PeopleSon(People son, People father, int x)
            {

                Nodo = grafo.BuscarVertice(Namespo(father));
                NodoHj(Namespo(son), x, 100 * contadorY);
                contadorY++;
                if (son.sons.Count > 0)
                {
                    foreach (People s in son.sons)
                    {
                        contador = x;
                        int poshX = (Pizarra.Width / (son.sons.Count + 1)) + contador;
                        PeopleSon(s, son, poshX);


                    }

                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width = Pizarra.Size.Width;
            int height = Pizarra.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            Pizarra.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            sf.ShowDialog();
            var path = sf.FileName;
            bm.Save(path, ImageFormat.Png);
        }
    }
}

