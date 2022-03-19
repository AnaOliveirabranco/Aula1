namespace Aula1.Entities
{
    public class Aluno : Pessoa
    {
        public string anoEscolar { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
       
        public Aluno(string nome, int idade, string email, string sexo,
         string anoEscolar, double nota1, double nota2) : 
         base(nome, idade, email, sexo)
        {
            this.anoEscolar = anoEscolar;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public double mediaFinal()
        {
            return (nota1 + nota2)/2;
        }
        public string situaçao(double mediaFinal)
        {
            return mediaFinal >=6 ? "Parabés, Aluno(a) foi aprovado!":
            "Aluno(a) Reprovado";
        }
        public void menssagem()
        {
            double obterMedia = mediaFinal();
            string obterSituaçao = situaçao(obterMedia);
            
            System.Console.WriteLine("O Aluno(a) obteve a média: "+
             obterMedia+ "\n" + obterSituaçao);

        }
        public override string ToString()
        {
            return 
              "Aluno(a):    " + nome + "\n"
            + "Idade:       " + idade + "\n"
            + "E-mail:      " + email + "\n"
            + "Sexo:        " + sexo + "\n"
            + "Nota1:       " + nota1 + "\n"
            + "Nota2:       " + nota2 + "\n"
            + "Nota final:  " + mediaFinal() + "\n"
            + "Ano letivo:  " + anoEscolar;
        }

    }
}