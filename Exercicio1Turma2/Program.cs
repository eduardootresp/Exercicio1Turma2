//namespace Exercicio1Turma2
//{
//    using System;

//    public abstract class Figura
//    {
//        public abstract string cor { get; set; }
//        public abstract double area();
//    }

//    public class Retangulo : Figura
//    {
//        public double lado1 { get; set; }
//        public double lado2 { get; set; }

//        public override string cor { get; set; }

//        public override double area()
//        {
//            return lado1 * lado2;
//        }
//    }

//    public class Triangulo : Figura
//    {
//        public double baseTriangulo { get; set; }
//        public double alturaTriangulo { get; set; }

//        public override string cor { get; set; }

//        public override double area()
//        {
//            return (baseTriangulo * alturaTriangulo);
//        }
//    }

//    public static class Teste
//    {
//        public static string DetalhesFigura(Figura figura)
//        {
//            return "Cor da figura: " + figura.cor +
//                   " - Área da figura: " + figura.area();
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Retangulo figura1 = new Retangulo();

//            figura1.cor = "Azul";
//            figura1.lado1 = 3.5;
//            figura1.lado2 = 2;

//            Console.WriteLine(Teste.DetalhesFigura(figura1));
//        }
//    }
//}
