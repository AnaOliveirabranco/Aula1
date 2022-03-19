
namespace Aula1.Entities{

    public class Pessoa
    {
       public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public Pessoa(string nome, int idade, 
        string email, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.sexo = sexo;

        }

        // public override string ToString()
        // {
        //     return 
              
        // }
    }
}