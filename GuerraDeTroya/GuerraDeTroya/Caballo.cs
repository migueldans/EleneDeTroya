using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Caballo
    {
        private int capacidad, ocupacion;
        private List<Griego> ocupantes;

        public Caballo(int capacidad)
        {
            this.capacidad = capacidad;
            this.ocupacion = 0;
            ocupantes = new List<Griego>();
        }

        public int GetOcupacion()
        {
            return ocupacion;
        }
        public int GetCapacidad()
        {
            return capacidad;
        }

        public int Buscar(String nombre)
        {

            foreach (Griego g in ocupantes)
            {
                if (g.GetNombre() == nombre)
                {
                    return ocupantes.IndexOf(g);
                }
            }
            return -1;
        }

        public void MostrarGuerreroPosicion(int pos)
        {
            if (pos >= 0 && pos < ocupacion)
            {
                //Griego griego = ocupantes.ElementAt(pos);
                //griego.Show();
                Console.WriteLine(ocupantes.ElementAt(pos).Show()); //TODO: el error está aqui
            }
            else
            {
                Console.WriteLine("No es posible");
            }
        }
        public void MontarseEnCaballo(Griego griego)
        {
            if (capacidad > ocupacion)
            {
                ocupacion = ocupacion + 1;
                ocupantes.Add(griego);
                Console.WriteLine("Guerrero Griego " + griego.GetNombre() + " montando en caballo");
            }
            else
            {
                Console.WriteLine("No hay sitio");
            }


        }
        public void MostrarCaballo()
        {
            Console.WriteLine("La capacidad del caballo es de " + GetCapacidad() + " griegos");
            Console.WriteLine("La ocupacion del caballo es de " + GetOcupacion() + " griegos");

            for (int i = 0; i < ocupacion; i++) //ocupantes.count probar // probar foreach tb
            {
                MostrarGuerreroPosicion(i);
            }
        }

    }
}
