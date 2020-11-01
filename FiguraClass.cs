using System;

namespace Shape_Calculator
{
    abstract class FiguraGeometrica
    {
        public abstract double Area();
    }

    class Circulo : FiguraGeometrica
    {
        private int _radio;


        // A read-write instance property:
        public int Radio
        {
            get
            {
                return _radio;
            }
            set
            {
                _radio = value;
            }
        }


        public Circulo(int r)
        {
            Radio = r;
        }

        public override double Area()
        {
            return (double)(Radio * Radio * 3.14);
        }

    }


    

    class Rectangulo : FiguraGeometrica
    {
        //atributos
        private int _base;
        private int _altura;

        public int Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                _altura = value;
            }
        }

        public int Base
        {
            get
            {
                return _base;
            }
            set
            {
                _base = value;
            }
        }

        public Rectangulo(int b, int a)
        {
            Base = b;
            Altura = a;
        }

        public override double Area()
        {
            return Base * Altura;
        }

    }

}
