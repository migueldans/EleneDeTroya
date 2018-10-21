using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class GuerraTroya
    {
        static void Main(string[] args)
        {
            Caballo caballoTroya = new Caballo(20);

            Troyano troyano1 = new Troyano();

            troyano1.SetNombre("Troy");
            troyano1.SetEdad(20);
            troyano1.SetFuerza(7);

            Troyano troyano2 = new Troyano("Toy", 22, 9);
            Troyano troyano3 = new Troyano("Roi", 122, 9);
            Troyano troyano4 = new Troyano("Troll ", 57, 3);
            Troyano troyano5 = new Troyano();


            Griego griego1 = new Griego();

            griego1.SetNombre("Grieg");
            griego1.SetEdad(20);
            griego1.SetFuerza(7);

            Griego griego2 = new Griego("Aquiles", 45, 4);
            Griego griego3 = new Griego("Agamenon", 67, 2);
            Griego griego4 = new Griego("Ajax", 34, 9);
            Griego griego5 = new Griego();

            caballoTroya.MontarseEnCaballo(griego2);
            caballoTroya.MontarseEnCaballo(griego3);
            caballoTroya.MontarseEnCaballo(griego4);

            caballoTroya.MostrarCaballo();

            Griego griego6 = new Griego();
            caballoTroya.MontarseEnCaballo(griego6);
            caballoTroya.MostrarCaballo();

            caballoTroya.MostrarGuerreroPosicion(caballoTroya.Buscar("Agamenon"));

            caballoTroya.MostrarGuerreroPosicion(caballoTroya.Buscar("Odiseo"));

            Troyano troyano6 = new Troyano("Paris ", 20, 9);

            Console.ReadLine();
            //caballoTroya.MontarseEnCaballo(troyano6);


            //List<Troyano> troyanos = new List<Troyano>
            //{
            //    troyano1,
            //    troyano2,
            //    troyano3,
            //    troyano4,
            //    troyano5
            //};

            //ShowTroyanos(troyanos);

            //List<Griego> griegos = new List<Griego>
            //{
            //    griego1,
            //    griego2,
            //    griego3,
            //    griego4,
            //    griego5
            //};

            //ShowGriegos(griegos);

            //foreach (Griego griego in griegos)
            //{
            //    caballoTroya.MontarseEnCaballo(griego);
            //}
        }


        public static void ShowTroyanos(List<Troyano> troyanos)
        {
            foreach (Troyano troyano in troyanos)
            {
                Console.WriteLine(troyano.Show());
                //Console.WriteLine("Troyano: "+troyano.GetNombre() + "\nEdad: " + troyano.GetEdad()+ " Fuerza: " + troyano.GetFuerza() + "\n " + troyano.SetHerido());
                //esto lo hemos puesto en la clase
            }
            Console.ReadLine();
        }
        public static void ShowGriegos(List<Griego> griegos)
        {
            foreach (Griego griego in griegos)
            {
                Console.WriteLine(griego.Show());
                //Console.WriteLine("Griego: " + griego.GetNombre() + "\nEdad: " + griego.GetEdad() + " Fuerza: " + griego.GetFuerza()+ "\n " + griego.SetHerido());
                //esto lo hemos puesto en la clase
            }
            Console.ReadLine();
        }
    }
}
