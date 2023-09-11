using ExemploHeranca___01.classes;
using ExemploHeranca___01.classes2;

public class Program
{
    static void Main(string[] args)
    {
        //Pessoa
        Aluno a = new Aluno();
        a.Cpf = "000";
        a.Nome = "João";
        a.DataNascimento = DateTime.Parse("22-01-2000");
        a.Responsavel = "Maria";

        Funcionario f = new Funcionario();
        f.Cpf = "111";
        f.Nome = "Elias";

        //Mamifero
        Cachorro c = new Cachorro();
        c.Raca = "Vira-lata";
        c.Barulho();

        Gato g = new Gato();
        g.Raca = "Chatonildo";
        g.Barulho();
    }

}
