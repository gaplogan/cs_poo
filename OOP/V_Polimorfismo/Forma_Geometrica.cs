using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Polimorfismo
{
    abstract class Forma_Geometrica
    {
        int _largura;
        int _altura;

        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        // Método herdado por todas as classes derivadas.
        public void Apresentar()
        {
            Console.WriteLine("Este metódo pertence a classe base.");
        }

        // Este método terá que ser implementado em todas as classes.
        public abstract void Area();

        // Este método Pode ou não ser alterado nas classes derivadas.
        public virtual void Perimetro()
        {
            int perimetro = 2 * (_largura + _altura);
            Console.WriteLine("Perimetro Retangulo: " + perimetro);
        }
    }

    class Rectangulo : Forma_Geometrica
    {
        public override void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine("Area Retangulo " + area);
        }

        public override void Perimetro()
        {
            base.Perimetro();
        }
    }

    class Triangulo : Forma_Geometrica
    {
        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine("Area Triangulo " + area);
        }

        public override void Perimetro()
        {
            double perimetro = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            Console.WriteLine("Perimetro Triangulo: " + perimetro);
        }
    }

    class Circulo : Forma_Geometrica
    {
        public override void Area()
        {
            double area = 3.14 * (_raio * _raio);
            Console.WriteLine("Area Circulo " + area);
        }

        public override void Perimetro()
        {
            double perimetro = 2 * 3.14 * _raio;
            Console.WriteLine("Perimetro Triangulo: " + perimetro);
        }
    }
}
