using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Griego
    {
        private string nombre;
        private int edad, fuerza;
        private bool herido = false;
        private bool muerto = false;

        public Griego(string nombre, int edad, int fuerza)
        {
            this.nombre = nombre;
            if (ComprobarEdad(edad))
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 25;
            }
            if (ComprobarFuerza(fuerza))
            {
                this.fuerza = fuerza;
            }
            else
            {
                this.fuerza = 5;
            }
        }
        public Griego()
        {
            nombre = "GriegoX";
            edad = 20;
            fuerza = 8;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string introNombre)
        {
            this.nombre = introNombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int introEdad)
        {
            this.edad = introEdad;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public void SetFuerza(int introFuerza)
        {
            this.fuerza = introFuerza;
        }
        public void SetHerido(bool herido)
        {
            this.herido = true;
        }
        public bool GetHerido()
        {
            return herido;
        }
        public bool Retirarse(bool herido)
        {
            if (herido == true)
            {
                Console.WriteLine("Está herido --> RETIRADA");
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ComprobarEdad(int edad)
        {
            if (edad >= 15 && edad <= 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ComprobarFuerza(int fuerza)
        {
            if (fuerza >= 1 && fuerza <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Show()
        {
            return "Griego: " + this.GetNombre() + "\nEdad: " + this.GetEdad() + " Fuerza: " + this.GetFuerza() + "\n " + this.GetHerido();
        }
    }
}
