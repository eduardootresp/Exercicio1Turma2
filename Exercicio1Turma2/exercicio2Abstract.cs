using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Turma2
{
    /* ENUNCIADO
     * Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas. Elas podem conter propriedades e métodos abstratos ou não abstratos, mas não podem ser instanciadas e permitem novas implementações de métodos virtuais.

    Nesse exercício, você deverá implementar uma classe abstrata com o nome EsporteBase que será a base para outras classes. Essa classe deverá conter os seguintes métodos e propriedades abstratas:

    Propriedades:
        QuantidadeJogadoresPorTime
        TempoDeJogoEmMinutos  

    Métodos:
        IniciarJogo
        FinalizarJogo
        ExibirDescricao  

    Implemente uma segunda classe que irá herdar de EsporteBase, chamada Futebol. Essa classe deverá implementar as propriedade e métodos da classe base.

    Crie um construtor para essa classe definindo as propriedades:

    QuantidadeJogadoresPorTime = 11
    TempoDeJogoEmMinutos = 90  

    Os métodos IniciarJogo e FinalizarJogo, devem retornar as frases "O jogo foi iniciado" e "O jogo foi finalizado", respectivamente.

    O método ExibirDescricao deverá retornar a frase "O futebol é um esporte praticado por X jogadores em cada time durante Y minutos", onde as informações X e Y devem ser os valores das propriedades preenchidas no construtor.
    */


    public abstract class EsporteBase
    {
        public abstract int QuantidadeJogadoresPorTime {get; set;}
        public abstract int TempoDeJogoEmMinutos { get; set;}

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public abstract string ExibirDescricao();
    }

    public class Futebol : EsporteBase
    {
        public override int QuantidadeJogadoresPorTime { get; set; }
        public override int TempoDeJogoEmMinutos { get; set; }
        public Futebol()
        {
            QuantidadeJogadoresPorTime = 11;
            TempoDeJogoEmMinutos = 90;
        }

        public override string IniciarJogo() { return "O jogo foi iniciado"; }
        public override string FinalizarJogo() { return "O jogo foi finalizado"; }

        public override string ExibirDescricao()
        {
            return "O futebol é um esporte praticado por " +QuantidadeJogadoresPorTime+" jogadores em cada time durante "+TempoDeJogoEmMinutos+" minutos";
        }

    }
}


