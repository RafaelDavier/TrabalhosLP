using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;


class Projcs {

   
  public static void Cadastrar()
  {
 
    Console.WriteLine("\n\nCadastro");
    Console.Write("Nome: ");



    string nome = Console.ReadLine();
    Console.Write("Preço: ");



    double preco = Convert.ToDouble(Console.ReadLine());
    Produto x = new Produto(nome, preco);
    x.Persistir();



  }

  public static void Listar()
  {



    Console.WriteLine("\n");
    List<Produto> produtos = Produto.verProdutos();




    foreach(var produto in produtos)
    {


      produto.Imprimir();


    }
    Console.WriteLine("Volte com qualuqer botão");



  }


  public static void Procurar()
  { 


    Console.Clear();
    Console.WriteLine("Qual produto você quer?");

    string procurar_ = Console.ReadLine();

 
            Console.Clear();
            Console.WriteLine("Resultado: {0}", procurar_);


  
    List<Produto> produtos = Produto.ProcurarProdutos(procurar_);
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
  
    Console.WriteLine("Volte com qualquer botão");
  }
 

 
    public static void Main(string[] args)
          {                 
                bool MostrarMenu = true;
                while (MostrarMenu)
                {
                    MostrarMenu = MenuPrincipal();
                }
          }




    private static bool MenuPrincipal()
    {

        Console.Clear();
          Console.WriteLine("1 - produtos");
            Console.WriteLine("2 - cadastrar");
             Console.WriteLine("3 - deletar");
               Console.WriteLine("4- pesquisa");
                 Console.WriteLine("5-fechar ");

                if (Console.ReadLine() = 1)
                {
                         
                  Listar();
                  Console.Read();    
                  return true;                         
                         
                }

                if (Console.ReadLine() = 2)
                {


                  Cadastrar();
                  Console.Read();                          
                  return true;


                }        

                if (Console.ReadLine() = 3)
                {



                    Produto.Deletar();
                    Console.Read();                          
                    return true;


                }

                if (Console.ReadLine() = 4)                  
                            Procurar();
                            Console.Read();   
                        return true;


                if (Console.ReadLine() = 5)
                {

                           Console.Clear();
                           return false;
                           
                        default:
                            return true;



                }




            }


