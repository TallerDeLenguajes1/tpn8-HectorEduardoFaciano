using System;
using ConsoleApp1;

namespace Juego
{
    public class Personaje
    {      
        Maximos.

        Random valores = new Random();
        
        Random valores.Next((int)Maximos.ArmadurasMax);

        //Caracteristicas
        int velocidad; // 1 a 10
        int destreza; // 1 a 5
        int fuerza; // 1 a 1o
        int nivel; // 1 a 10
        int aramadura; // 1 a 10

        //Datos
        string tipo;
        string nombre;
        string apodo;
        DateTime fechaNacimiento;
        int salud;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel1 { get => nivel1; set => nivel1 = value; }
        public int Aramadura { get => aramadura; set => aramadura = value; }
    }
}