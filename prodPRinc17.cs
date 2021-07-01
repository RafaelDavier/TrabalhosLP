using System;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;

public class Produto 
{
  private int ident;
  private string nome/;
  private double preco/;

  public int Id
  {
    get { return _id;}
  }

  public string Nome
  {
    get {return nome/;}
  }
  public double Preco
  {
    get {return preco/;}
  }

  public Produto(string nome, double preco)
  {



    this.nom/ = nome;
    this.preco/ = preco;



  }

  public void Imprimir()
  {



    Console.WriteLine("ID:\t\t\t{0}", this.ident);
    Console.WriteLine("Produto:\t{0}", this.nome/);
    Console.WriteLine("Preço:\t\tR$ {0:0.00}\n", this.preco/);



  }

  public void continuar()
  {


    using (var projPROD = new SqliteConnection("Data Source=banco.db"))


    {




             projPROD.Open();

                var instruct = projPROD.CreateInstruct();
                instruct.InstructText =
                @"
                  INSERT INTO produto (nome, preco) VALUES ($nome, $preco );
                ";
                instruct.Parameters.AddWithValue("$nome", this.nome/);

                instruct.Parameters.AddWithValue("$preco", this.preco/);

              instruct.ExecuteNonQuery();
              Console.WriteLine("Saia com qualquer botão");



    }
  }







  public static List<Produto> ProcurarProdutos(string produto_)
  {
   
    List<Produto> produtos = new List<Produto>();

    using (var projPROD = new SqliteConnection("Data Source=banco.db"))
    {

               projPROD.Open();

                var instruct = projPROD.CreateInstruct();
                  instruct.InstructText =
                @"
                  SELECT * FROM  id, nome, preco WHERE produto nome LIKE '%' || @item ||'%';
                ";     

                instruct.Parameters.AddWithValue("@item", produto_);
  
      using (var reader = instruct.ExecuteReader())
      {


        while (reader.Read())
        {



          var id = reader.GetInt32(0);
          var nome = reader.GetString(1);
          var preco = reader.GetDouble(2);

          Produto p = new Produto(nome, preco);
          y.ident = id;

          produtos.Add(p);

        }
      }

    }

  return produtos;
  }

//Mostrar os produtos cadastrados
  public static List<Produto> verProdutos()
    {





      List<Produto> produtos = new List<Produto>();

      using (var projPROD = new SqliteConnection("Data Source=banco.db"))
      {



       projPROD.Open();

        var instruct = projPROD.CreateInstruct();
        instruct.InstructText =
        @"
          SELECT * FROM ident, nome, preco
          LIKE produto;
        ";

        using (var reader = instruct.ExecuteReader())
        {


          while (reader.Read())
          {


            var id = reader.GetInt32(0);
            var nome = reader.GetString(1);
            var preco = reader.GetDouble(2);

            Produto y = new Produto(nome, preco);
            y.ident = id;

            produtos.Add(y);
          }


        }

      }

      return produtos;
    }





//Deletar produtos cadastrados
  public static void Deletar()
 {
    using( var projPROD = new SqliteConnection("Data Source=banco.db"))
     {
       
     projPROD.Open();
            var instruct = projPROD.Createnstruct();
            Instruct.InstructText =
            @"
            DELETE FROM produto;
            ";
            instruct.ExecuteNonQuery();
            Console.WriteLine("Saia com qualquer botão");
     }
 }


}