using System;
using Aula1.Entities;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
             Aluno aluno1 = new Aluno("Ana", 17, "ana@dio.me",
          "Feminino", "3º ano", 8.6, 5.9);

             Aluno aluno2 = new Aluno("jose", 19, "jose@dio.me",
          "masculino", "3º ano", 5.6, 5.9);
                    
            Console.WriteLine(aluno1);
            aluno1.menssagem();
            Console.WriteLine();
            Console.WriteLine(aluno2);
            aluno2.menssagem();
        }
     }
}

 