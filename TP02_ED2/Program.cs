using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_ED2
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "";


            while (opcao != "0")
            {


                Console.WriteLine(("0. Sair"));
                Console.WriteLine(("1. Adicionar Curso"));
                Console.WriteLine(("2. Pesquisar Curso"));
                Console.WriteLine(("3. Remover Curso"));
                Console.WriteLine(("4. Adicionar disciplina no curso"));
                Console.WriteLine(("5. Pesquisar disciplina"));
                Console.WriteLine(("6. Remover disciplina do curso"));
                Console.WriteLine("7. Matricular aluno na disciplina");
                Console.WriteLine("8. Remover aluno da disciplina");
                Console.WriteLine("8. Pesquisar aluno");

                opcao = Console.ReadLine();




                switch (opcao)
                {

                    case "1":
                        {

                            
                            Console.WriteLine(("Adicionar Curso - Digite o ID do Curso: "));
                            int idCurso = int.Parse(Console.ReadLine());

                            Console.WriteLine(("Adicionar Curso - Digite o Nome do Curso: "));
                            string nome = Console.ReadLine();

                            Disciplina[] novaDisciplina= new Disciplina[10];

                            Curso novoCurso = new Curso(idCurso, nome, novaDisciplina);

                            break;

                        }

                    case "2":
                        {

                          
                            


                            break;
                        }



                }


            }

        }
    }
}