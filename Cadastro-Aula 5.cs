using System;
using System.Collections.Generic;


public class Pessoa
{
    public string nome;
    public string CorDoCabelo;
    public string Altura;
    public string CPF;
}

public static class CreateMethodsForPeopleClass
{
    public static void AddDataIntoList(this List<Pessoa> GlobalList, string NOMEx, string CorDoCabelox, string Alturax, string CPFx)
    {

        if (null == GlobalList)
            throw new NullReferenceException();


        var PersonData = new Pessoa
        {
            nome = NOMEx,
            CorDoCabelo = CorDoCabelox,
            Altura= Alturax,
            CPF = CPFx

        };


        GlobalList.Add(PersonData);

    }


}


public class CadastradosZ
{

    static List<Pessoa> cadastroP = new List<Pessoa>();

    private static string ConvertPersonText(int value)
    {

        switch (value)
        {
            case 0:
                return "Primeira Pessoa";
            case 1:
                return "Segunda Pessoa";
            case 2:
                return "Terceira Pessoa";
            case 3:
                return "Quarta Pessoa";
            case 4:
                return "Quinta Pessoa";

            default:
                return ("MaxLimit");
        }
    }
 
    static void Main(string[] args)
    {
        bool MenuImp= true;
        while (MenuImp)
        {
            MenuImp= MenuImp();
        }
    }


    private static bool Menu Principal()
    {

        Console.Clear();
        Console.WriteLine("1- Cadastro");
        Console.WriteLine("2 - Lista de Cadastrados");
        Console.WriteLine("3 -Fechar ");

         if (Console.ReadLine() = 1)
        {
                Console.Clear();
                Console.Write("Digite o nome da pessoa: ");
                var NOMEx = Console.ReadLine();


                  Console.Write("Digite a cor do cabelo: ");
                  var CorDoCabelox = Console.ReadLine();


                      Console.Write("Digite a altura: ");
                      var desHeight = Console.ReadLine();

                          Console.Write("Digite o CPF: ");
                          var CPFx = Console.ReadLine();

                cadastroP.AddDataIntoList(NOMEx, CorDoCabelox, desHeight, CPFx);
        }
              

            if (Console.ReadLine() = 2)
            {
                Console.Clear();
                for (int x = 0; x < cadastroP.Count; x++)
                {

                    if (ConvertPersonText(x) != "MaxLimit")
                     {
                       
                        Console.WriteLine(ConvertPersonText(x)); 
                        
                        
                        }

                    else {
                      
                      
                       Console.WriteLine("Pessoa Número {0}", x);
                       
                        }
                    Console.WriteLine("Nome : " + cadastroP[x].nome);
                      Console.WriteLine("Cor do cabelo : " + cadastroP[x].CorDoCabelo);
                        Console.WriteLine("Altura : " + cadastroP[x]._Height);
                          Console.WriteLine("CPF : " + cadastroP[x].CPF);
                }
            }   

                Console.WriteLine("Volte com qualquer tecla");
                Console.ReadKey();
                

            if (Console.ReadLine() = 3)
            {

                  Environment.Exit(0);

            }

        }
    }


}