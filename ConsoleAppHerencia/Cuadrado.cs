﻿namespace ConsoleAppHerencia
{
    class Cuadrado : Rectangulo
    {     
        //public float Lado { get; set; }

        float _base;
        public new float Base { 
            get 
            {
                return _base;
            }
            set
            {
                _base = value;
                _altura = value;
            } 
        }

        float _altura;
        public new float Altura {
            get
            {
                return _altura;
            }
            set
            {
                _base = value;
                _altura = value;
            }
        }

        public new float Area()
        {
            return Base * Altura;
        }
    }
}