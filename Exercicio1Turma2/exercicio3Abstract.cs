using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Turma2
{
    public abstract class CartaoWeb
    {
        public string Destinatario { get; set; }
        public CartaoWeb(string destinatario)
        {
            Destinatario = destinatario;
        }

        public abstract string ShowMessage();
    }

    public class DiaDosNamorados : CartaoWeb
    {
        public DiaDosNamorados(string destinatario) : base(destinatario) { }


        public override string ShowMessage()
        {
            return $"Feliz Dia dos Namorados, " + Destinatario + "!";
        }
    }

    public class Natal : CartaoWeb
    {
        public Natal(string destinatario) : base(destinatario) { }

        public override string ShowMessage()
        {
            return $"Feliz Natal, " + Destinatario + "!";
        }

    }

    public class Aniversario : CartaoWeb
    {
        public Aniversario(string destinatario) : base(destinatario) { }

        public override string ShowMessage()
        {
            return $"Feliz Aniversário, " + Destinatario + "!";
        }

    }
}
