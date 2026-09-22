using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Turma2
{
    /*ENUNCIADO
     * Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

    Elas podem conter propriedades e métodos abstratos ou não abstratos, mas não podem ser instanciadas e permitem novas implementações de seus métodos virtuais.

    Crie uma classe abstrata chamada Figura. Nessa classe, nós teremos uma propriedade abstrata cor do tipo string e um método abstrato double area().

    Em seguida, vamos criar a classe Retangulo que vai herdar a classe Figura e declarar dois atributos nela como double (lado1 e lado2). Vamos também sobrescrever o método double area(), onde colocaremos um return com a função lado 1 * lado 2, para obtermos a área.

    Vamos criar uma classe Triangulo, que vai herdar a classe Figura, com os atributos base e altura e um método double area() que retorna base * altura.

    Para finalizar, vamos criar uma classe estática chamada Teste com um método estático chamado DetalhesFigura que receberá um objeto do tipo Figura e retornará as informações sobre o objeto.

    Exemplo:

    Retangulo retangulo = new Retangulo();
    retangulo.cor = "Azul";
    retangulo.lado1 = 3.5;
    retangulo.lado2 = 2;
    Teste.DetalhesFigura(retangulo); //"Cor da figura: Azul - Área da figura: 7"
     */
    public abstract class Figura
    {
        public abstract string cor { get; set; }
        public abstract double area();
    }

    public class Retangulo : Figura
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }

        public override string cor { get; set; }

        public override double area()
        {
            return lado1 * lado2;
        }
    }

    public class Triangulo : Figura
    {
        public double @base { get; set; }
        public double altura { get; set; }

        public override string cor { get; set; }

        public override double area()
        {
            return @base * altura;
        }
    }

    public static class Teste
    {
        public static string DetalhesFigura(Figura figura)
        {
            return "Cor da figura: " + figura.cor +
                   " - Área da figura: " + figura.area();
        }
    }

}
